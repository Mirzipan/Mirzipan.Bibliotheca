using System.Collections.Generic;
using UnityEngine.Pool;

namespace Mirzipan.Bibliotheca.Collections
{
    public class ListDictionary<TKey, TValue>: CollectionDictionary<TKey, List<TValue>, TValue>
    {
        #region Protected

        protected override List<TValue> CreateCollection()
        {
            return ListPool<TValue>.Get();
        }

        protected override List<TValue> CreateCollection(List<TValue> source)
        {
            var collection = ListPool<TValue>.Get();
            collection.AddRange(source);
            return collection;
        }

        protected override void DestroyCollection(List<TValue> collection)
        {
            ListPool<TValue>.Release(collection);
        }

        #endregion Protected
    }
}