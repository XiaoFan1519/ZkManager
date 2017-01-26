using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZkManager;
using ZooKeeperNet;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCreate()
        {
            ZkClient client = new ZkClient("127.0.0.1:2181", 3000);
            client.create("/fan", CreateMode.Persistent);
            client.close();
        }
    }
}
