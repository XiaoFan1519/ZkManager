using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZkManager.Forms;

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
            foreach (string key in config.GetKets())
            {
                ListBox_IpList.Items.Add(key);
                log.Debug(key, new Exception("aaa"));
            }
            
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            new Edit().ShowDialog();
        }
    }
}
