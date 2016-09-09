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
        /// 配置项
        /// </summary>
        private Config config;

        /// <summary>
        /// 窗口返回结果
        /// </summary>
        private DialogResult result;

        /// <summary>
        /// 新增模式的构造方法
        /// </summary>
        public Edit(Config config)
        {
            InitializeComponent();
            this.isAdd = true;
            this.config = config;
        }

        public Edit(string name, string ip, Config config)
        {
            InitializeComponent();
            this.name = name;
            this.ip = ip;
            this.config = config;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if ("" == textBox_Name.Text || "" == textBox_Ip.Text)
            {
                MessageBox.Show("名称或地址不能为空。");
                return;
            }

            name = textBox_Name.Text;
            ip = textBox_Ip.Text;

            if (isAdd)
                doAdd();
            else
                doEdit();
        }

        private void Edit_Shown(object sender, EventArgs e)
        {
            if (!isAdd)
            {
                textBox_Name.Text = name;
                textBox_Ip.Text = ip;
            }
        }

        /// <summary>
        /// 新增操作
        /// </summary>
        private void doAdd()
        {
            string value = config[name];
            if (null != value)
            {
                MessageBox.Show("该名称已存在！");
                return;
            }

            config[name] = ip;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        private void doEdit()
        {

        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
