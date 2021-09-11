using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //generic class ile list oluşturuyoruz..
    class MyList<T>
    {
        //constructor metod class'ı bir yerde NEW lersek otomatik calışır.
        // metodun constructor olduğunu Class'la aynı isimle olmasından Anlarız.
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        //istediğimiz veri türü ile çalışabiliriz.
        public void Add(T item)
        {
            //newleme işleminde referans numaraları kaybolmaması için geçici diziden yararlanıyoruz.
            T[] tempArray = items;

            //dizinin eleman sayısını 1 arttır.
            items = new T[items.Length + 1];

            //tempArray de tuttuğumuz değerleri items e ekliyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                Console.WriteLine(i);
            }
            items[items.Length - 1] = item;
        }

    }
}
