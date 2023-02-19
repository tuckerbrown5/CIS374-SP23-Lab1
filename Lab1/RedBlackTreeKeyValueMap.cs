using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    //TODO
    public class RedBlackTreeKeyValueMap<TKey, TValue>: IKeyValueMap<TKey, TValue>
    {
        public RedBlackTreeKeyValueMap()
        {
        }
        private RedBlackTreeMap<TKey, TValue> redBlackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => redBlackTreeMap.Height;

        public int Count => redBlackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            redBlackTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            redBlackTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            return redBlackTreeMap.Remove(key);
        }

        public void Clear()
        {
            redBlackTreeMap.Clear();
        }
    }
}