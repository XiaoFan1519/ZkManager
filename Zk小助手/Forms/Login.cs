using log4net;
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
        /// 日志类
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Login));
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
            // 将配置项显示到列表框中
            foreach (string key in config.GetKets())
            {
                ListBox_IpList.Items.Add(key);
            }
            
        }
    }
}
