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
            int MAX = 100_000;
            int ITERATIONS = 11;

            double totalOrderedCreate = 0;
            double totalUnorderedCreate = 0;

            double totalOrderedGet = 0;

            double totalHeightOrdered = 0;
            double totalHeightUnordered = 0;

            IKeyValueMap<int, int> keyValueMap = null ;

            for (int c = 0; c < ITERATIONS; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }

                var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();
                var redblackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();

                keyValueMap = bstKeyValueMap;

                //Console.WriteLine("DictionaryKeyValueMap");
                // Console.WriteLine("BSTKeyValueMap");
                totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalHeightOrdered += dictionaryKeyValueMap.Height;

                totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);

                //Console.WriteLine("Unordered");
                intKeyValuePairs.Shuffle();
                keyValueMap.Clear();
                totalUnorderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalHeightUnordered += keyValueMap.Height;

                //bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                //CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
            }
            //Console.WriteLine("DictionaryKeyValueMap");
            Console.WriteLine(keyValueMap.GetType());

            Console.WriteLine("Ordered");
            Console.WriteLine(totalOrderedCreate / ITERATIONS);
            Console.WriteLine(totalHeightOrdered/ ITERATIONS);

            Console.WriteLine("Unordered");
            Console.WriteLine(totalUnorderedCreate / ITERATIONS);
            Console.WriteLine(totalHeightUnordered / ITERATIONS);



        }


        public static double CreateKeyValueMap<TKey, TValue>(
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
            return stopwatch.Elapsed.TotalSeconds;
            

        }


        //TODO
        public static double QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            return 0.0;
        }

        //TODO
        public static double RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            return 0.0;
        }
    }
}
