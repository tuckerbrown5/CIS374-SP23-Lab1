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
            int ITERATIONS = 11;

            double totalOrderedCreate = 0;
            double totalUnorderedCreate = 0;

            double totalOrderedGet = 0;
            double totalUnorderedGet = 0;

            double totalOrderedRemove = 0;
            double totalUnorderedRemove = 0;

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

                // Ordered
                //var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                //keyValueMap = dictionaryKeyValueMap;
                //totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalHeightOrdered += keyValueMap.Height;

                //BST
                //var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                //keyValueMap = bstKeyValueMap;
                //totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalHeightOrdered += keyValueMap.Height;

                //RedBlack
                //var RedBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();
                //keyValueMap = RedBlackKeyValueMap;
                //totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalHeightOrdered += keyValueMap.Height;

                //AVL
                var AVLKeyValueMap = new AVLTreeKeyValueMap<int, int>();
                keyValueMap = AVLKeyValueMap;
                totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalHeightOrdered += keyValueMap.Height;

                // Unordered
                //intKeyValuePairs.Shuffle();
                //dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                //totalOrderedCreate += CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //totalHeightOrdered += dictionaryKeyValueMap.Height;

                // Unordered BST
                //bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                //totalOrderedCreate += CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                //totalHeightOrdered += bstKeyValueMap.Height;

                // Unordered RedBlack
                //RedBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();
                //totalOrderedCreate += CreateKeyValueMap<int, int>(RedBlackKeyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(RedBlackKeyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(RedBlackKeyValueMap, intKeyValuePairs);
                //totalHeightOrdered += RedBlackKeyValueMap.Height;

                // Unordered AVL
                AVLKeyValueMap = new AVLTreeKeyValueMap<int, int>();
                totalOrderedCreate += CreateKeyValueMap<int, int>(AVLKeyValueMap, intKeyValuePairs);
                totalOrderedGet += QueryKeyValueMap<int, int>(AVLKeyValueMap, intKeyValuePairs);
                totalOrderedRemove += RemoveKeyValueMap<int, int>(AVLKeyValueMap, intKeyValuePairs);
                totalHeightOrdered += AVLKeyValueMap.Height;

            }

            Console.WriteLine(keyValueMap.GetType());

            Console.WriteLine("Ordered");
            Console.WriteLine(totalOrderedCreate / ITERATIONS);
            Console.WriteLine(totalOrderedGet / ITERATIONS);
            Console.WriteLine(totalOrderedRemove / ITERATIONS);
            Console.WriteLine(totalHeightOrdered/ ITERATIONS);

            Console.WriteLine("Unordered");
            Console.WriteLine(totalUnorderedCreate / ITERATIONS);
            Console.WriteLine(totalOrderedGet / ITERATIONS);
            Console.WriteLine(totalOrderedRemove / ITERATIONS);
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

            return stopwatch.Elapsed.TotalSeconds;
            

        }


        public static double QueryKeyValueMap<TKey, TValue>(
            IKeyValueMap<TKey, TValue> keyValueMap,
            List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Get(kvp.Key);
            }

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalSeconds;
        }

        public static double RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Remove(kvp.Key);
            }

            stopwatch.Stop();

            return stopwatch.Elapsed.TotalSeconds;
        }
    }
}
