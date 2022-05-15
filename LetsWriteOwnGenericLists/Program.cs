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

            Console.WriteLine("---------------------------------------");

            MyDictionary<string,string> myDictionary = new MyDictionary<string,string>();

            myDictionary.Add("Book","Kitap");
            myDictionary.Add("Table", "Masa");
            myDictionary.Add("Pencil","Kalem");

            

            foreach (var item in myDictionary.ItemsKey)
            {
                Console.WriteLine("Keys:"+item);
            }

            Console.WriteLine();

            foreach (var item in myDictionary.ItemsValue)
            {
                Console.WriteLine("Values:" + item);
            }

            Console.WriteLine();

            Console.WriteLine("Toplam Key Sayısı: {0}",myDictionary.CountKey);
            Console.WriteLine("Toplam Value Sayısı: {0}", myDictionary.CountValue);



            Console.ReadLine();

        }
    }
}
