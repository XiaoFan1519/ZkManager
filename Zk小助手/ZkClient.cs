using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ZooKeeperNet;

namespace ZkManager
{
    class ZkClient
    {
        private ZooKeeper zk;

        /// <summary>
        /// 是否连接成功
        /// </summary>
        private bool isConnected = false;

        public bool IsConected
        {
            get
            {
                return isConnected;
            }
        }

        public ZkClient(string connectString, int sessionTimeout)
        {
            CountdownEvent countDownEvent = new CountdownEvent(1);
            zk = new ZooKeeper(connectString, 
                new TimeSpan(0, 0, 0, 0, sessionTimeout),
                new ZkConnectWatch(countDownEvent));
            // 这里并没有连接到zk，所以对zk进行了一层封装，保证构造方法执行完就能知道zk是否连接成功
            if (countDownEvent.Wait(sessionTimeout))
            {
                isConnected = true;
            }
        }
    }

    /// <summary>
    /// 专门用于连接时候的Watcher
    /// </summary>
    class ZkConnectWatch : IWatcher
    {
        private CountdownEvent countDownEvent;

        public ZkConnectWatch(CountdownEvent countDownEvent)
        {
            this.countDownEvent = countDownEvent;
        }

        public void Process(WatchedEvent @event)
        {
            if(@event.State == KeeperState.SyncConnected)
            {
                countDownEvent.Signal();
            }
        }
    }
}
