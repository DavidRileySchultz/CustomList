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
            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList2.Add(2);
            myList2.Add(4);
            myList2.Add(6);
            CustomList<int> myList3 = (myList.Zip(myList2));
            //foreach (int element in myList3.Zip())
                //{
                Console.WriteLine(myList3);
                //break;
               // }
           
            Console.ReadKey();
           

            

           

            
        }
    }
}
