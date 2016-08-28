using log4net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ZooKeeperNet;

namespace ZkManager
{
    public class ZkClient
    {
        /// <summary>
        /// 日志类
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(ZkClient));

        /// <summary>
        /// zk变量
        /// </summary>
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

        /// <summary>
        /// 同步的构造方法，
        /// 只有等收到连接成功的通知，
        /// 或者超时才会返回。
        /// 当选择异步时，IsConected 属性失效。
        /// </summary>
        /// <param name="connectString">要链接的ip字符串</param>
        /// <param name="sessionTimeout">超时时间</param>
        /// <param name="sync">同步，还是异步(同步需要等待连接结果)</param>
        public ZkClient(string connectString, int sessionTimeout, bool sync = true)
        {
            if (sync)
            {
                syncConnectZk(connectString, sessionTimeout);
            }
            else
            {
                asyncConnectZk(connectString, sessionTimeout);
            }
        }

        /// <summary>
        /// 同步连接zk
        /// </summary>
        /// <param name="connectString">要链接的ip字符串</param>
        /// <param name="sessionTimeout">超时时间</param>
        private void syncConnectZk(string connectString, int sessionTimeout)
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

        /// <summary>
        /// 异步连接zk
        /// </summary>
        /// <param name="connectString">要链接的ip字符串</param>
        /// <param name="sessionTimeout">超时时间</param>
        private void asyncConnectZk(string connectString, int sessionTimeout)
        {
            zk = new ZooKeeper(connectString,
                new TimeSpan(0, 0, 0, 0, sessionTimeout), null);
        }

        /// <summary>
        /// 查找指定路径下的子节点
        /// </summary>
        /// <param name="path">指定路径</param>
        /// <returns>路径下的子节点</returns>
        public List<string> getChildren(string path)
        {
            IEnumerable<string> collection = zk.GetChildren(path, false);
            List<string> list = new List<string>(collection);
            list.Sort();
            return list;
        }

        /// <summary>
        /// 将strData已指定编码格式保存到zk上。默认strData的格式为UTF-8
        /// </summary>
        /// <param name="path">路径地址</param>
        /// <param name="strData">要保存的文本</param>
        /// <param name="dstEncode">指定编码格式</param>
        public void setData(string path, string strData, Encoding dstEncode)
        {
            byte[] data = Encoding.Convert(Encoding.UTF8, dstEncode, strData.GetBytes());
            zk.SetData(path, data, -1);
        }

        /// <summary>
        /// 获取指定节点上的内容，根据指定的编码格式。
        /// </summary>
        /// <param name="path">节点路径</param>
        /// <param name="dstEncode">指定的编码格式</param>
        /// <returns></returns>
        public string getData(string path, Encoding dstEncode)
        {
            byte[] data = zk.GetData(path, false, null);
            return dstEncode.GetString(data);
        }

        /// <summary>
        /// 删除指定节点，当有子节点时无法删除。
        /// </summary>
        /// <param name="path">节点路径</param>
        public void delete(string path)
        {
            zk.Delete(path, -1);
        }

        /// <summary>
        /// 关闭与zk的连接
        /// </summary>
        public void close()
        {
            // C#的zookeerper退出时候，
            // 会超时等待才返回，这里使用线程解决等待的问题。
            if (null != zk)
                new Thread(() =>
                {
                    zk.Dispose();
                });
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
