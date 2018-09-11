using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            myList.Add(12);
            myList.Add(10);
            myList.Add(9);
            myList2.Add(12);
            myList2.Add(32);
            myList2.Add(9);
            CustomList<int> myList3 = myList - myList2;
            foreach (int element in myList3)
                {
                Console.WriteLine(element);

                }
           
            Console.ReadKey();
           

            

           

            
        }
    }
}
