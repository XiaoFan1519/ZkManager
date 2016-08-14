using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ZkManager
{
    public class Config
    {
        private IDictionary<string, string> configs = 
            new Dictionary<string, string>();

        public bool Remove(string key)
        {
            return configs.Remove(key);
        }

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

        public bool Contains(string key)
        {
            return configs.ContainsKey(key);
        }

        /// <summary>
        /// 读取配置文件，并保存到内存中
        /// </summary>
        /// <param name="path">文件路径</param>
        public void load(string path)
        {
            StreamReader sr = new StreamReader(path);
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

        public void save(string path)
        {
            StreamWriter sw = new StreamWriter(path, false);

            foreach (var entry in configs)
            {
                string line = string.Format("{0}={1}", entry.Key, entry.Value);
                sw.WriteLine(line);
            }

            sw.Close();
        }
    }
}
