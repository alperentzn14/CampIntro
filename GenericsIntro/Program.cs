using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ile calısmak istiyoruz.int ,bool,decimal vs de olabilir.
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Alperen");
            Console.WriteLine("Hello World!");
        }
    }
}
