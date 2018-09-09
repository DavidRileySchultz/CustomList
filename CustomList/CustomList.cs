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
        public T[] newArray;

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
            newArray = new T[newCapacity];
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
            newArray = new T[newCapacity];
        }
        public T this[int index] //indexer
        {
            get
            {
                return newArray[index];
            }
            set
            {
                newArray[index] = value;
            }
        }
    }
}
