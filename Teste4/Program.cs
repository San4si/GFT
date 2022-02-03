using System;
using System.Collections.Generic;
using System.Linq;
namespace Sequencia
{
    class Program
    {
        static void Main(string[] args) 
        {
            ProcessarString("55 2 1 854 963 520 1 0 98 8");
            ProcessarString("");
            ProcessarString("2 3 5 44 8 99 6 55 72 3 01 25");
            ProcessarString("98 99 100 101 102 103 105 105");
            ProcessarString("1");
            ProcessarString(Console.ReadLine());
        }

        static void ProcessarString(string str)
        {
            List<string> listString =  str.Split(" ").ToList();
            
            int? maiorNumero = null;
            int soma = 0;
            foreach (string s in listString)
            {
                int n;
                if(int.TryParse(s, out n))
                {
                    if (maiorNumero == null || n > maiorNumero)
                    {
                        maiorNumero = n;
                    }
                    soma += n;
                }
            }
            
            Console.WriteLine("O maior número é " + maiorNumero);
            Console.WriteLine("A soma dos valores é " + soma);

        }
    }
}
