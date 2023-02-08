using System;
using System.Collections.Generic;
using System.Diagnostics;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 10000;

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }

                //var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                //Console.WriteLine("DictionaryKeyValueMap");
                Console.WriteLine("BSTKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
            }

        }


        public static void CreateKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey,TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs )
        {
            

        }


        public static void QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
           
        }

        public static void RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            
        }
    }
}
