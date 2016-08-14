using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZkManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ZkManager.Tests
{
    [TestClass()]
    public class ConfigTests
    {
        private Config configs = new Config();

        [ClassInitialize()]
        public static void init(TestContext testContext)
        {
            FileStream fs = File.Create("test.cfg");
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("xf=fx");
            sw.WriteLine("111=AAA");
            sw.WriteLine("222=BBB");
            sw.Close();
        }

        [ClassCleanup()]
        public static void clearUp()
        {
            File.Delete("test.cfg");
        }

        [TestInitialize()]
        public void before()
        {
            configs["1"] = "AAA";
            configs["2"] = "BBB";
            configs["3"] = "CCC";
            configs["3"] = "DDD";
        }

        [TestMethod()]
        public void AddTest()
        {
            configs["4"] = "DDD";
        }

        [TestMethod()]
        public void RemoveTest()
        {
            bool ret = configs.Remove("1");
            if (!ret)
                Assert.Fail();
        }

        [TestMethod()]
        public void loadTest()
        {
            configs.Load("test.cfg");

            string value = configs["111"];

            if (value != "AAA")
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void saveTest()
        {
            configs["saveTest"] = "Test";
            configs.Save("test.cfg");

            // 检测保存后的文件是否可以正确读写
            configs.Load("test.cfg");
            string value = configs["saveTest"];
            if (value != "Test")
            {
                Assert.Fail();
            }

            File.Delete("test.cfg");
            configs.Save("test.cfg");
        }

        [TestMethod()]
        public void getTest()
        {
            string value = configs["3"];
            if (value != "DDD")
            {
                Assert.Fail();
            }

            value = configs["111"];
            if (value != null)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void CountTest()
        {
            if (configs.Count != 3)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void clearTest()
        {
            configs.Clear();
            if (configs.Count != 0)
            {
                Assert.Fail();
            }
        }
    }
}