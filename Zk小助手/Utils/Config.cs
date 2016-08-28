using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ZkManager
{
    /// <summary>
    /// 操作cfg配置文件
    /// </summary>
    public class Config
    {
        private IDictionary<string, string> configs = 
            new Dictionary<string, string>();

        /// <summary>
        /// 删除指定名称的配置项
        /// </summary>
        /// <param name="key">配置项名称</param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            return configs.Remove(key);
        }

        /// <summary>
        /// 获取、新增和保存指定配置项
        /// </summary>
        /// <param name="key">配置项名称</param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                if (this.Contains(key))
                {
                    return configs[key];
                }
                return null;
            }
            set
            {
                if (Contains(key))
                {
                    configs[key] = value;
                }
                else
                {
                    configs.Add(key, value);
                }
            }
        }

        /// <summary>
        /// 检查指定名称的配置项是否已经存在
        /// </summary>
        /// <param name="key">配置项名称</param>
        /// <returns></returns>
        private bool Contains(string key)
        {
            return configs.ContainsKey(key);
        }

        /// <summary>
        /// 读取配置文件，并保存到内存中
        /// </summary>
        /// <param name="path">文件路径</param>
        public void Load(string path)
        {
            FileStream stream = File.Exists(path) ? File.OpenRead(path) : File.Create(path);
            StreamReader sr = new StreamReader(stream);
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                // 防止value里面也有=
                int index = line.IndexOf('=');
                if (index == -1)
                {
                    continue;
                }

                string key = line.Substring(0, index);
                string value = line.Substring(index + 1);
                this[key] = value;
            }

            sr.Close();
        }

        /// <summary>
        /// 将内存中的配置项保存到文件中，已覆盖的形式保存
        /// </summary>
        /// <param name="path">文件路径</param>
        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path, false);

            foreach (var entry in configs)
            {
                string line = string.Format("{0}={1}", entry.Key, entry.Value);
                sw.WriteLine(line);
            }

            sw.Close();
        }

        /// <summary>
        /// 移除内存中的所有配置项
        /// </summary>
        public void Clear()
        {
            configs.Clear();
        }

        /// <summary>
        /// 返回内存中配置项的数量
        /// </summary>
        public int Count
        {
            get
            {
                return configs.Count;
            }
        }

        /// <summary>
        /// 返回所有配置项的key值
        /// </summary>
        /// <returns></returns>
        public ICollection<string> GetKets()
        {
            return configs.Keys;
        }
    }
}
