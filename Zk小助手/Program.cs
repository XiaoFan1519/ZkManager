using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ZkManager.constant;
using System.Threading;

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

            // UI线程异常
            Application.ThreadException += Application_ThreadException;
            // 多线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

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

        /// <summary>
        /// 多线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            log.Error("UnhandledException", ex);
            throw new NotImplementedException();
        }

        /// <summary>
        /// UI线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            log.Error("ThreadException", ex);
            throw new NotImplementedException();
        }
    }
}
