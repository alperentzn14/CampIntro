using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,double,bool,decimal,float vs DEĞER TİPLERDİR
            ///diziler,classlar,abstract class,interface,string vs REFERANS TİPLERDİR
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 150;
            product1.UnitsInStock = 10;
            //1. kullanım şekli

            Product product2 = new Product { Id = 1, CategoryId = 2, ProductName = "Masa", UnitPrice = 150, UnitsInStock = 10 };
            //2. kullanım şekli.




            ProductManager productManager = new ProductManager();
            productManager.Add(product1);          
            Console.WriteLine(product1.ProductName);
            /*productManager.Topla2(3 , 2);
            int toplamSonucu=productManager.Topla(3 , 2);
            Console.WriteLine(toplamSonucu * 2);*/

        }
    }
}
