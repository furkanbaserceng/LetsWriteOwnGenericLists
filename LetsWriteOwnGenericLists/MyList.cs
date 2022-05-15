using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsWriteOwnGenericLists
{
    public class MyList<T>
    {
        T[] arrays;

        public MyList()
        {
            arrays = new T[0];
        }

        /// <summary>
        /// Diziye yeni eleman ekleme metodu.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            T[] tempArray = arrays;             //newlenince referans kaybolmasın diziye geçiçi diziye aktarıldı.referanslar eşitlendi.
            arrays = new T[arrays.Length + 1];  //eleman sayısı 1 arttı.
            for (int i = 0; i < tempArray.Length; i++)
            {
                arrays[i] = tempArray[i];       //yeni referans numarası alınıp eleman sayısı artırılmasına rağmen eski elemanları geçici diziden almış olduk.
            }
            arrays[arrays.Length - 1] = item;   //yeni eleman var olan diziye eklenmiş oldu.
        }

        /// <summary>
        /// Dizinin eleman sayısını döndüren getter.
        /// </summary>
        public int MyLength
        {
            get { return arrays.Length; }
        }

        /// <summary>
        /// Dizinin elemanlarını döndüren getter.
        /// </summary>
        public T[] Items
        {
            get { return arrays; }
        }

    }
}
