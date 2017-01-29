using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZooKeeperNet;

namespace ZkManager.Forms
{
    public partial class Add : Form
    {
        /// <summary>
        /// 日志类
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Main));

        /// <summary>
        /// 要新增节点的父路径
        /// </summary>
        private string path;

        /// <summary>
        /// 要新增节点对应的父窗口组件
        /// </summary>
        private TreeNode node;

        /// <summary>
        /// zk
        /// </summary>
        private ZkClient zkClient;

        public Add(TreeNode node, ZkClient zkClient)
        {
            InitializeComponent();
            path = (string)node.Tag;
            if ("/".Equals(path))
            {
                path = "";
            }
            this.node = node;
            this.zkClient = zkClient;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            fullPath.Text = path + "/";
        }

        private void newNodeName_TextChanged(object sender, EventArgs e)
        {
            fullPath.Text = path + "/" + newNodeName.Text;
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string newVal = newNodeName.Text;
            if ("".Equals(newVal))
            {
                MessageBox.Show("请输入节点名。");
                return;
            }

            try
            {
                string fullPath = path + "/" + newVal;
                zkClient.create(fullPath, CreateMode.Persistent);
                TreeNode newNode = new TreeNode(newVal);
                newNode.Tag = fullPath;
                node.Nodes.Add(newNode);

                // 没展开就刷新，展开则新增
                if (!node.IsExpanded)
                {
                    node.Expand();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("创建节点 " + newVal + " 失败。");
                log.Debug("Create Error.", ex);
                return;
            }

            Close();
        }
    }
}
