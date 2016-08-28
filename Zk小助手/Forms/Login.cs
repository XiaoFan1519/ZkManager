using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZkManager
{
    public partial class Login : Form
    {
        /// <summary>
        /// 本地配置项类
        /// </summary>
        private Config config;
        public Login(Config config)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            this.config = config;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            foreach (string key in config.GetKets())
            {
                ListBox_IpList.Items.Add(key);
            }
            
        }
    }
}
