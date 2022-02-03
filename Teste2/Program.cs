using System;
using System.Collections.Generic;

namespace ListaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int> ();
            int? menorNumero = null;
            int? maiorNumero = null;
            List<int> numerosAcimaDe10 = new List<int>();
            List<int> numerosAcimaDe50 = new List<int>();
            float total = 0;
            Console.WriteLine("Digite 10  números");
            for (int i  = 0; i  < 10; i++)
            {
                int numero;
                bool repetido = false;
                do
                {
                    
                    numero = Convert.ToInt32(Console.ReadLine());
                    repetido =  numeros.Contains(numero);
                    if (repetido)
                    {
                        Console.WriteLine("Número repetido. Digite novamente");
                    }
                } while(repetido);

                numeros.Add(numero);
                if(menorNumero == null || numero < menorNumero)
                {
                    menorNumero = numero;
                }
                if (maiorNumero == null || numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
                if(numero > 10)
                {
                    numerosAcimaDe10.Add(numero);
                }
                if(numero > 50)
                {
                    numerosAcimaDe50.Add(numero);
                }
                total  += numero;

            }
            Console.WriteLine("Maior número: " + maiorNumero);
            Console.WriteLine("Menor número: " + menorNumero);
            Console.WriteLine("Média aritmética: " + total / 10f);
            Console.WriteLine("Números acima de 10");
            foreach(int n in numerosAcimaDe10)
            {
                Console.WriteLine(" " + n +" ");
            }
            Console.WriteLine("Números acima de 50");
            foreach (int n in numerosAcimaDe50)
            {
                Console.WriteLine(" " + n + " ");
            }

        }
       
    }
}
