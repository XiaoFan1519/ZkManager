using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ZkManager.Forms
{
    public partial class Main : Form
    {
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
                        treeNode.Nodes.Add("");
                    }
                });
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
            textBox_NodePath.Text = (string)e.Node.Tag;
        }

        private void menuReconnect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
