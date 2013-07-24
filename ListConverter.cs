using System;
using System.Collections.Generic;

namespace OEC.API.Example
{
    /// <summary>
    ///     This helper class used to convert objects from IEnumerable to IList interface
    /// </summary>
    /// <typeparam name="TSrc"></typeparam>
    /// <typeparam name="TDst"></typeparam>
    public class ListConverter<TSrc, TDst>
    {
        /// <summary>
        ///     Converts from IEnumerable to IList interface
        /// </summary>
        /// <param name="sourceList"> Source list</param>
        /// <param name="converter"> Conversion strategy</param>
        /// <returns>Return object than implement IList interface</returns>
        public static IList<TDst> FromIEnumerable(IEnumerable<TSrc> sourceList, Converter<TSrc, TDst> converter)
        {
            IList<TDst> destList = new List<TDst>();
            foreach (TSrc obj in sourceList)
                destList.Add(converter(obj));
            return destList;
        }

        /// <summary>
        ///     Converts from IEnumerable to IList interface
        /// </summary>
        /// <param name="sourceList">Source list</param>
        /// <param name="capacity">Capasity of list</param>
        /// <param name="converter">Conversion strategy</param>
        /// <returns>Return object than implement IList interface</returns>
        public static IList<TDst> FromIEnumerable(IEnumerable<TSrc> sourceList, int capacity,
            Converter<TSrc, TDst> converter)
        {
            IList<TDst> destList = new List<TDst>(capacity);
            foreach (TSrc obj in sourceList)
                destList.Add(converter(obj));
            return destList;
        }
    }
}