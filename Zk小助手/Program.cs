using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZkManager.constant;

namespace ZkManager
{
    static class Program
    {
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

            try
            {
                Application.Run(new Login());
            }
            catch(Exception e)
            {

            }
            finally
            {
                config.Save(Constant.ZK_CFG);
            }
        }
    }
}
