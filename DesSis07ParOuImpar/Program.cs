using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis07ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par(0) ou Impar(1): ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();

            int cont = num;

            while (cont <= 20) 
            {
                Console.WriteLine(cont);
                cont+=2;
            }




            Console.ReadKey();
        }
    }
}
