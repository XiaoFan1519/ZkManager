using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void getChildNode(TreeNode root, string path)
        {
            List<string> nodes = zkClient.getChildren(path);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.zkClient.close();
        }
    }
}
