using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szinkeveres
{
    class Program
    {
        public static void feladat01(string[] szinek)
        {
            int eredmeny = 1;
            int lehetosegek = szinek.Length;
            int ismetlodes = 1;
            int forCiklusVege = 1;
            if (szinek.Length > 1)
            {
                for (int k = szinek.Length - 1; k >= 2; k--)
                {
                    for (int i = szinek.Length - 1; i > forCiklusVege; i--)
                    {
                        lehetosegek *= i;

                    }
                    forCiklusVege++;
                    for (int j = k; j > 0; j--)
                    {
                        ismetlodes *= j;
                    }
                    eredmeny += (lehetosegek / ismetlodes);
                    lehetosegek = szinek.Length;
                    ismetlodes = 1;
                } 
            }
            else
            {
                eredmeny = 0;
            }

            Console.WriteLine($"A listából keverhető különböző színek száma: {eredmeny}");         

        }
        static void Main(string[] args)
        {
            string[] szinek = new string[5] {"piros", "kék", "zöld", "sárga", "lila"};

            feladat01(szinek);

            Console.ReadKey();
        }
    }
}
