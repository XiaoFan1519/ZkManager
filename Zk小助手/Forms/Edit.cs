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

        public Edit()
        {
            InitializeComponent();
        }
    }
}
