using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        /// ekleme operasyonu
        /// encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        ///Güncelleme operasyonu
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        ///Topla kısmında void kullanmadık ve int tipinde geriye değer döndürebiliyoruz.döndürdüğümüz değeri ise işlem sonrasında bile kullanabiliyoruz.
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        //topla2 işlemini yapıp sonucu ekrana yazdırır.Void kullanma amacı ise buna benzerdir.Void'de return işlemi yapılmaz.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
