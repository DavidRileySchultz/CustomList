using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        private int count { get; set; }
        private int newCapacity { get; set; }
        public T[] array { get; set; }

        public int Count
        {
            get {return count;}
            private set {count = value;}
        }
        public int Capacity
        {
            get {return newCapacity;}
            private set {newCapacity = value;}
        }
        public CustomList()
        {
            count = 0;
            newCapacity = 4;
            array = new T[newCapacity];
        }
        public CustomList(int startingCapacity)
        {
            count = 0;
            if (startingCapacity >= 0)
            {
                newCapacity = startingCapacity;
            }
            else
            {
                newCapacity = 4;
            }
            array = new T[newCapacity];
        }
        public T this[int index] //indexer
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in array)
            {
                yield return element;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T addNewValue)
        {
            count++;
            T[] newArray;

            if (count > newCapacity)
            {
                newCapacity *= 2;
                newArray = new T[newCapacity];

                for (int i = 0; i < count - 1; i++)
                {
                    newArray[i] = array[i];
                }

                newArray[count - 1] = addNewValue;
                array = newArray;
            }
            else
            {
                array[count - 1] = addNewValue;
            }
        }
        public void Remove(T valueToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(valueToRemove))
                {
                    count--;
                    for (; i < count; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    array[count] = default(T);
                    break;
                }
            }
        }
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                list3.Add(list1.array[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                list3.Add(list2.array[i]);
            }

            return list3;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for(int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1.array[i].Equals(list2.array[j]))
                    {
                        list1.Remove(list2.array[j]);
                        i--;
                        break;

                    }
                }
            }
            return list1;
        }
    }
}
