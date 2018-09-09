using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count { get; set; }
        private int newCapacity { get; set; }
        public T[] array;

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
    }
}
