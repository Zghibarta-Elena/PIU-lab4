using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab4
{
    internal class Program
    {
        static readonly string ALFABET = "abcdefghijklmnopqrstuwxyz";

        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Trebuie sa dai cel putin un argument");
            };
            int[] count_litere = new int[ALFABET.Length];
            for (int i=0;i<args.Length;i++)
            {
                count_litere[ALFABET.IndexOf(args[i].ToLower()[0])]++;
            }
            string[][] cuvinte_sortate = new string[ALFABET.Length][];
            for(int i=0;i<ALFABET.Length;i++)
            {
                cuvinte_sortate[i] = new string[count_litere[i]];
            }
            for (int i = 0; i < args.Length; i++)
            {
                int index_litera = ALFABET.IndexOf(args[i].ToLower()[0]);

                cuvinte_sortate[index_litera][(count_litere[index_litera]--)-1] = args[i] ;
            }
            foreach(string[] linie in cuvinte_sortate) 
            {
                foreach (string cuvant in linie)
                {
                    Console.Write($"{cuvant}, ");
          
                }
                Console.WriteLine();
            }
        }
    }
}
