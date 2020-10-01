using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cég
{
    class Program
    {
        struct cég
        {
            public string ceg_nev;
            public double nap_1;
            public double nap_2;
            public double nap_3;
            public double ize;

        }
        static void Main(string[] args)
        {
            Console.Write("Hány cég van?\n");
            int n = Convert.ToInt32(Console.ReadLine());
            cég[] brrr = new cég[n];
            Console.WriteLine("Kérem a cégek napi összegét\n");
            for (int i = 0; i < brrr.Length; i++)
            {
                Console.Write("A cég neve: \n");
                brrr[i].ceg_nev = Console.ReadLine();
                Console.Write("\nElső napi bevétel:");
                brrr[i].nap_1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nMásodik napi bevétel:");
                brrr[i].nap_2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nHarmadik napi bevétel:");
                brrr[i].nap_3 = Convert.ToDouble(Console.ReadLine());
                brrr[i].ize = brrr[i].nap_3-brrr[i].nap_1;
                Console.WriteLine("{0} volt a nyereség", brrr[i].ize);
            }
                Console.ReadLine();

        }
    }
}