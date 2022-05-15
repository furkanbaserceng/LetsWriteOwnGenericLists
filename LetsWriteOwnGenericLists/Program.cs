using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsWriteOwnGenericLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.MyAdd(5);
            myList.MyAdd(10);

            foreach (var item in myList.Items)
            {
                Console.WriteLine("Dizi elemanı:{0}",item);
            }


            Console.WriteLine("Dizinin eleman sayısı:{0}", myList.MyLength);


            Console.ReadLine();

        }
    }
}
