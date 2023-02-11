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
            int MAX = 100000;

            for (int c = 0; c < 10; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }

                var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                //var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();

                Console.WriteLine("DictionaryKeyValueMap");
                // Console.WriteLine("BSTKeyValueMap");
                Console.WriteLine("Ordered");
                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);

                Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                //CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
            }

        }


        public static void CreateKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey,TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs )
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // do the work

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Add(kvp.Key, kvp.Value);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            

        }


        //TODO
        public static void QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
           
        }

        //TODO
        public static void RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            
        }
    }
}
