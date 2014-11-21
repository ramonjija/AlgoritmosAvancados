using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosAvancadosI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = { 4, 2, 1, 3 };
            int[,] vet2 = new int[4,4];   
            int n = vet.Length;
            int i;
            int b;
            int c = 4;
            int s;


            for (i = 0; i <= n-1; i++)
            {
                vet2[i,0] = 1;
            }

            for (b = 1; b <= c; c++)
            {
                vet2[0,b] = 0;

                for (i = 1; i <= n; i++)
                {
                    s = vet2[i - 1,b];
                    if (s == 0 && vet[i] <= b)
                    {
                        s = vet2[i - 1,b - vet[i]];
                    }
                    vet2[i,b] = s;
                }
            }
            Console.WriteLine(vet2[n,c]);
        }
    }
}
