﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace éretségi
{
    class Program
    {
        struct éretségi
        {
            public string nev;
            public double matek;
            public double tori;
            public double nyelv;
            public double szakmai;
            public double magyar;
            public double osz_atlag;
            public double tan_atlag;
            /* legjobb legroszabb és 4,5 felet*/
        }
        static void Main(string[] args)
        {
            Console.Write("Hány tanuló éretségizet?\n");
            int n = Convert.ToInt32(Console.ReadLine());
            éretségi[] brrr = new éretségi[n];
            Console.WriteLine("Kérem a tanulók \n");
            for (int i = 0; i < brrr.Length; i++)
            {
                Console.Write("A tanuló neve: \n");
                brrr[i].nev = Console.ReadLine();
                Console.Write("\nMatek jegye:");
                brrr[i].matek= Convert.ToDouble(Console.ReadLine());
                Console.Write("\nTöri jegye:");
                brrr[i].tori = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nNyelv jegye:");
                brrr[i].nyelv = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nSzakmai jegye:");
                brrr[i].szakmai = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nMagyar jegye:");
                brrr[i].magyar = Convert.ToDouble(Console.ReadLine());
                brrr[i].osz_atlag=
            }
        }
    }
}