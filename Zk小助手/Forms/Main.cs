using log4net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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

        public Main(ZkClient client, string name)
        {
            // 初始化
            this.zkClient = client;
            this.name = name;

            InitializeComponent();
        }

        // 获取子节点信息
        private void getChildNode(TreeNode root, string path)
        {
            root.Nodes.Clear();

            List<string> nodes = zkClient.getChildren(path);
            // 子节点为0，直接返回
            if (0 == nodes.Count)
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
                // 为了防止递归造成的卡顿，这里只判断是否有子节点。
                new Thread(delegate () {
                    List<string> childNodes = zkClient.getChildren(childPath);
                    if (childNodes.Count > 0)
                    {
                        nodeTree.Invoke((Action) delegate () {
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
                string nodeValue = zkClient.getData(nodePath, encode);
                richTextBox_NodeValue.Invoke((Action)delegate () {
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
    }
}
