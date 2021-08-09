using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementations
{
    class CustomList<T> : ICustomList<T>, IEnumerable<T>
    {
        const int INDEX_BASE_SIZE = 8;


        public T this[int index]
        {
            get
            {
                return listOfElements[index];
            }
            set
            {
                listOfElements[index] = value;
            }
        }

        T[] listOfElements = new T[INDEX_BASE_SIZE];

        //this field will be used both to track the number of elements in the Custom list
        //as well as the last index (as the last index is Count - 1)
        public int Count { get; private set; }

        public CustomList()
        {
            Count = 0;
        }

        public CustomList(T[] initialElements)
        {
            //TO make it work with the Add() Method
            Count = initialElements.Count();

            foreach (var item in initialElements)
            {
                Add(item);
            }
        }


        public void Add(T item)
        {
            Insert(Count, item);
        }

        public void Insert(int index, T item)
        {
            if (index > Count)
            {
                throw new ArgumentOutOfRangeException("Cannot insert an element outside of the size of the list.");
            }
            else if (Count == listOfElements.Length)
            {
                //resize takes the original array creates a new one with the new size
                //then copies the elements from the original to the new one and finally replaces the old one with the new 
                Array.Resize(ref listOfElements, listOfElements.Length + INDEX_BASE_SIZE);
            }

            for (int i = Count - 1; i >= index; i--)
            {
                listOfElements[i + 1] = listOfElements[i]; 
            }

            listOfElements[index] = item;
            Count += 1;
        }

        public int Find(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(listOfElements[i]))
                {
                    return i;
                }
            }

            return -1;
        }


        public bool Remove(T item)
        {
            int itemIndex = Find(item);

            if (itemIndex == -1)
            {
                return false;
            }

            Count -= 1;

            for (int i = itemIndex; i < Count; i++)
            {
                listOfElements[i] = listOfElements[i + 1];
            }

            listOfElements[Count] = default;
            return true;
        }

        //I don't quite understand how that works yet and how to change it to fit what I want it to do
        //what it currently does that I want to change is that because the way I work with my custom list is with a resized array
        //when I use foreach it returns all values in that array including the defaults such as 0 for int which are still not assigned
        //by the user
        //tomorrow 6/8/2021 I will read up on it a little bit more and perhaps ask a friend
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)listOfElements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listOfElements.GetEnumerator();
        }
    }
}
