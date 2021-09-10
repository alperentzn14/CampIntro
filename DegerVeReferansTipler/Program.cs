using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int s1 = 10;
            int s2 = 20;
            s1 = s2;
            s2 = 30;
            
            Console.WriteLine(s1);
        }
    }
}
