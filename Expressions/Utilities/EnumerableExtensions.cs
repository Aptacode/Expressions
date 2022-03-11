using System;
using System.Collections.Generic;
using System.Linq;

namespace Aptacode.Expressions.Utilities;

public static class EnumerableExtensions
{
    public static IEnumerable<T> TakeLastItems<T>(this IEnumerable<T> source, int count)
    {
        var tempList = source as T[] ?? source.ToArray();
        return tempList.Skip(Math.Max(0, tempList.Length - count));
    }
}