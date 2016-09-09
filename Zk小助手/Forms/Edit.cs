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
    public partial class Edit : Form
    {
        /// <summary>
        /// 配置项名称
        /// </summary>
        public string name;

        /// <summary>
        /// 配置项内容
        /// </summary>
        public string ip;

        /// <summary>
        /// 新增还是修改
        /// </summary>
        private bool isAdd = false;

        /// <summary>
        /// 新增模式的构造方法
        /// </summary>
        public Edit()
        {
            InitializeComponent();
            this.isAdd = true;
        }

        public Edit(string name, string ip)
        {
            InitializeComponent();
            this.name = name;
            this.ip = ip;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Shown(object sender, EventArgs e)
        {
            if (!isAdd)
            {
                textBox_Name.Text = name;
                textBox_Ip.Text = ip;
            }
            
        }
    }
}
