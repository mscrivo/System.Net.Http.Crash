using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace NetStandardLib
{
    public static class EnumerableExtensions
    {
        //[Pure]
        //public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> enumerable)
        //{
        //    return enumerable.ToDictionary(kvp => kvp.Key, kvp => kvp.Value).ToReadOnlyDictionary();
        //}

        //[Pure]
        //public static IReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> enumerable, IEqualityComparer<TKey> comparer)
        //{
        //    return enumerable.ToDictionary(kvp => kvp.Key, kvp => kvp.Value, comparer);
        //}
    }
}
