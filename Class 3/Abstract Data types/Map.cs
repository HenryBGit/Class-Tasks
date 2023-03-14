using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    public class Map
    {
        private Dictionary<string, int> items;

        public Map()
        {
            items = new Dictionary<string, int>();
        }

        public void Add(string key, int value)
        {
            items[key] = value;
        }

        public int Remove(string key)
        {
            int value;
            if (!items.TryGetValue(key, out value))
            {
                throw new Exception("Key not found");
            }
            items.Remove(key);
            return value;
        }

        public int Lookup(string key)
        {
            int value;
            if (!items.TryGetValue(key, out value))
            {
                throw new Exception("Key not found");
            }
            return value;
        }

        public void Update(string key, int newValue)
        {
            if (!items.ContainsKey(key))
            {
                throw new Exception("Key not found");
            }
            items[key] = newValue;
        }
    }
}
