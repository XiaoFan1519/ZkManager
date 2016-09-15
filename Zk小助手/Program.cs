using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ZkManager.constant;

namespace ZkManager
{
    static class Program
    {
        /// <summary>
        /// 日志类
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config config = new Config();
            config.Load(Constant.ZK_CFG);
            Login loginFrm = new Login(config);
            try
            {
                Application.Run(loginFrm);
            }
            catch(Exception e)
            {
                log.Error(e.Message, e);
            }
            finally
            {
                config.Save(Constant.ZK_CFG);
            }
        }
    }
}
