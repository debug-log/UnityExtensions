using System;
using System.Linq;
using System.Collections.Generic;

public static class EnumerableExtension
{
    /// <summary>
    /// Shuffle the enumerable.
    /// </summary>
    public static IEnumerable<T> Shuffle<T> (this IEnumerable<T> source)
    {
        return source.OrderBy (x => Guid.NewGuid ());
    }
    
    /// <summary>
    /// Returns a random item from the enumerable.
    /// </summary>
    public static T GetRandomElement<T> (this IEnumerable<T> source)
    {
        return source.Shuffle ().Take(1).Single();
    }

    /// <summary>
    /// Returns n-random elements from the enumerable.
    /// </summary>
    public static IEnumerable<T> GetRandomElements<T> (this IEnumerable<T> source, int count)
    {
        return source.Shuffle ().Take (count);
    }
}
