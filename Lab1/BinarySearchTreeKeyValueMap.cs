using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class BinarySearchTreeKeyValueMap<TKey, TValue>: IKeyValueMap<TKey, TValue>
    {
        private BinarySearchTreeMap<TKey, TValue> binarySearchTreeMap = new BinarySearchTreeMap<TKey, TValue>();

    }
}