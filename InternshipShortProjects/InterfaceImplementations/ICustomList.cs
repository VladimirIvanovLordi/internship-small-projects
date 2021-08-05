using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementations
{
    public interface ICustomList<T>
    {
        int Count { get; }

        void Add(T item);

        /// <summary>
        /// Removes the first occurence of an item in the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>false if item was not found and true otherwise</returns>
        bool Remove(T item);

        void Insert(int index, T item);

        T this[int index] { get; set; }
    }
}
