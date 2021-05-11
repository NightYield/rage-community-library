using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageCommunity.Library.Extensions
{
    public static class EnumerableExtensions
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Shuffle this <paramref name="list"/>
        /// </summary>
        /// <remarks>
        /// <para>Source:</para>
        /// <para><a href="https://stackoverflow.com/questions/273313/randomize-a-listt">Stack Overflow</a></para>
        /// <para><a href="https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle">Fisher–Yates shuffle</a></para>
        /// </remarks>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                int k = Random.Next(n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }
        /// <summary>
        /// Gets random element of this list
        /// </summary>
        /// <param name="list">The list to get the element of</param>
        /// <param name="shuffle">If set to <c>true</c>, this <paramref name="list"/> will be shuffled</param>
        /// <returns>The selected <typeparamref name="T"/> element</returns>
        /// <remarks>Source: <a href="https://github.com/alexguirre/Wilderness-Callouts/blob/master/src/Extensions.cs#L551">Github</a></remarks>
        public static T GetRandomElement<T>(this IList<T> list, bool shuffle = false)
        {
            if (list == null || list.Count <= 0)
                return default;

            if (shuffle) list.Shuffle();
            return list[Random.Next(list.Count)];
        }

        /// <summary>
        /// Gets random element of this enumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumarable"></param>
        /// <param name="shuffle">If set to <c>true</c>, this <paramref name="enumarable"/> will be shuffled</param>
        /// <returns>The selected <typeparamref name="T"/> element</returns>
        /// <remarks>Source: <a href="https://github.com/alexguirre/Wilderness-Callouts/blob/master/src/Extensions.cs#L551">Github</a></remarks>
        public static T GetRandomElement<T>(this IEnumerable<T> enumarable, bool shuffle = false)
        {
            if (enumarable == null || enumarable.Count() <= 0)
                return default;

            T[] array = enumarable.ToArray();
            return GetRandomElement(array, shuffle);
        }

        /// <summary>
        /// Gets a number of random element of this list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="numberOfElements">The number of element that will be given</param>
        /// <param name="shuffle">If set to <c>true</c>, this <paramref name="list"/> will be shuffled</param>
        /// <returns>A number of random elements from a collection</returns>
        /// <remarks>Source: <a href="https://github.com/alexguirre/Wilderness-Callouts/blob/master/src/Extensions.cs#L551">Github</a></remarks>
        public static IList<T> GetRandomNumberOfElements<T>(this IList<T> list, int numberOfElements, bool shuffle = false)
        {
            List<T> givenList = new List<T>(list);
            List<T> l = new List<T>();
            for (int i = 0; i < numberOfElements; i++)
            {
                T t = givenList.GetRandomElement(shuffle);
                givenList.Remove(t);
                l.Add(t);
            }
            return l;
        }

        /// <summary>
        /// Gets a number of random element of this enumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumarable"></param>
        /// <param name="numberOfElements">The number of element that will be given</param>
        /// <param name="shuffle">If set to <c>true</c>, this <paramref name="enumarable"/> will be shuffled</param>
        /// <returns>A number of random elements from a collection</returns>
        /// <remarks>Source: <a href="https://github.com/alexguirre/Wilderness-Callouts/blob/master/src/Extensions.cs#L551">Github</a></remarks>
        public static IEnumerable<T> GetRandomNumberOfElements<T>(this IEnumerable<T> enumarable, int numberOfElements, bool shuffle = false)
        {
            List<T> givenList = new List<T>(enumarable);
            List<T> l = new List<T>();
            for (int i = 0; i < numberOfElements; i++)
            {
                T t = givenList.Except(l).GetRandomElement(shuffle);
                l.Add(t);
            }
            return l;
        }
    }
}
