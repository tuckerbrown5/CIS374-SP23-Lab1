using System;
using System.Collections.Generic;

namespace Lab1
{
    public class DictionaryKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
    }
}
