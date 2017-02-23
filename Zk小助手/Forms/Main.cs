using log4net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZooKeeperNet;
using static ZooKeeperNet.KeeperException;

namespace ZkManager.Forms
{
    public partial class Main : Form
    {
        /// <summary>
        /// 日志类
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));

        /// <summary>
        /// zk工具类
        /// </summary>
        private ZkClient zkClient;

        /// <summary>
        /// 本次连接的连接名称
        /// </summary>
        private string name;

        /// <summary>
        /// 本次连接的ip信息
        /// </summary>
        private string ip;

        public Main(ZkClient client, string name, string ip)
        {
            // 初始化
            this.zkClient = client;
            this.name = name;
            this.ip = ip;
            InitializeComponent();
        }

        // 获取子节点信息
        private void getChildNode(TreeNode root, string path)
        {
            root.Nodes.Clear();

            List<string> nodes = null;

            try
            {
                nodes = zkClient.getChildren(path);
            }
            catch (Exception ex)
            {
                log.Debug("Exception", ex);
                MessageBox.Show("异常：" + ex.Message);
            }

            // 子节点为0，直接返回
            if (null == nodes || 0 == nodes.Count)
            {
                return;
            }

            foreach (string node in nodes)
            {
                TreeNode treeNode = new TreeNode(node);
                // 该子节点的全路径名
                string childPath = "";

                if (path.EndsWith("/"))
                {
                    childPath = path + node;
                }
                else
                {
                    childPath = path + "/" + node;
                }

                treeNode.Tag = childPath;
                root.Nodes.Add(treeNode);
                // 为了防止网络延迟造成的卡顿，这里只判断是否有子节点。
                new Thread(delegate () {
                    List<string> childNodes = null;
                    try
                    {
                        childNodes = zkClient.getChildren(childPath);
                    }
                    catch (NoAuthException ex)
                    {
                        childNodes.Add("没有权限");
                        log.Debug("NoAuthException", ex);
                    }

                    if (childNodes.Count > 0)
                    {
                        nodeTree.BeginInvoke((Action) delegate () {
                            treeNode.Nodes.Add("");
                        });
                    }
                }).Start();
            }
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.zkClient.close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = name + " - " + ip;
            comboBox_Encoding.SelectedIndex = 0;
            getChildNode(nodeTree.Nodes[0], "/");
        }

        private void nodeTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodePath = (string)e.Node.Tag;
            textBox_NodePath.Text = nodePath;

            Encoding encode = null;

            try
            {
                encode = getSelectedEncoding();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("错误的编码格式！请修改或重新选择。");
                comboBox_Encoding.Focus();
                log.Debug("Error Encode Name.", ex);
                return;
            }

            // 因为从zk获取节点会有短暂的卡顿，但会造成界面闪烁，所以用线程来处理
            new Thread(() =>
            {
                string nodeValue = null;

                try
                {
                    nodeValue = zkClient.getData(nodePath, encode);
                }
                catch (NoAuthException ex)
                {
                    nodeValue = "没有权限";
                    log.Debug("NoAuthException", ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("异常：" + ex.Message);
                    log.Debug("Exception", ex);
                }
                richTextBox_NodeValue.BeginInvoke((Action)delegate () {
                    richTextBox_NodeValue.Text = nodeValue;
                });
            }).Start();
        }

        private void menuReconnect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void nodeTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            getChildNode(node, (string)node.Tag);
        }

        /// <summary>
        /// 获取用户选择的编码
        /// </summary>
        /// <returns>返回指定编码对象</returns>
        /// <exception cref="ArgumentException" />
        private Encoding getSelectedEncoding()
        {
            string name = comboBox_Encoding.Text;
            return Encoding.GetEncoding(name);
        }

        private void comboBox_Encoding_Leave(object sender, EventArgs e)
        {
            string name = comboBox_Encoding.Text;
            try
            {
                Encoding.GetEncoding(name);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("错误的编码格式！请修改或重新选择。");
                comboBox_Encoding.Focus();
                log.Debug("Error Encode Name.", ex);
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            // 要设置值的节点全路径
            string nodePath = textBox_NodePath.Text;
            // 要设置的值 默认UTF-8
            string nodeValue = richTextBox_NodeValue.Text;

            Encoding encode = null;
            try
            {
                encode = getSelectedEncoding();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("错误的编码格式！请修改或重新选择。");
                comboBox_Encoding.Focus();
                log.Debug("Error Encode Name.", ex);
                return;
            }

            zkClient.setData(nodePath, nodeValue, encode);
        }

        private void menuUpdate_Click(object sender, EventArgs e)
        {
            TreeNode node = nodeTree.SelectedNode;
            TreeNodeMouseClickEventArgs @event = new TreeNodeMouseClickEventArgs(node, new MouseButtons(), 0, 0, 0);
            nodeTree_NodeMouseClick(sender, @event);
        }

        private void memuRefresh_Click(object sender, EventArgs e)
        {
            TreeNode node = nodeTree.SelectedNode;

            if (null == node)
            {
                node = nodeTree.Nodes[0];
                return;
            }

            getChildNode(node, (string)node.Tag);
        }

        private void addMenuI_Click(object sender, EventArgs e)
        {
            TreeNode node = nodeTree.SelectedNode;

            // 如果为空，则默认根节点
            if (null == node)
            {
                node = nodeTree.Nodes[0];
            }

            new Add(node, zkClient).ShowDialog();
        }

        // 删除节点，包括子节点
        private void delNode(string path)
        {
            List<string> childNodes = zkClient.getChildren(path);
            foreach(string node in childNodes)
            {
                delNode(path + "/" + node);
            }
            zkClient.delete(path);
        }

        private void delMenu_Click(object sender, EventArgs e)
        {
            TreeNode node = nodeTree.SelectedNode;
            string path = (string)node.Tag;
            try
            {
                List<string> childNodes = zkClient.getChildren((string)node.Tag);
                if (childNodes.Count > 0)
                {
                    if (DialogResult.No == MessageBox.Show("节点 " + path + " 存在子节点，是否全部删除？", "提示", MessageBoxButtons.YesNo))
                    {
                        return;
                    }
                }
                else
                {
                    if (DialogResult.No == MessageBox.Show("确定删除节点 " + path + "？", "提示", MessageBoxButtons.YesNo))
                    {
                        return;
                    }
                }
                delNode(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("删除节点 " + path + "失败！");
                log.Debug("Error Delete Node.", ex);
            }

            node.Parent.Nodes.Remove(node);
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
