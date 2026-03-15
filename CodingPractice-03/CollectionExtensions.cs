using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Console;


static class CollectionExtensions
{
    // 컬렉션 비어있는지 검사
    public static bool IsEmpty<T> (this ICollection<T> collection)
    {
        return collection.Count == 0;
    }
    // 컬렉션 요소 들어있는지 검사
    public static bool HasItems<T> (this ICollection<T> collection)
    {
        return collection.Count >= 1;
    }
    
    public static void Foreach<T> (this IList<T> list, Action<T> action)
    {
        foreach (var item in list)
        {
            action(item);
        }
    }
}