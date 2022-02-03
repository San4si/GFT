using System;
using System.Collections.Generic;

namespace Cargos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int totalStarter = 0;
            int totalJunior =  0;
            int totalSênior = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Informe o nome da " + (i  + 1) + " pessoa: ");
                string nome =  Console.ReadLine();
                
                Console.Write("Informe o cargo da " + (i + 1) + " pessoa: ");
                string cargo = Console.ReadLine();

                Pessoa pessoa = new Pessoa(nome, cargo);

                if (pessoa.Cargo.Equals("Starter"))
                {
                    totalStarter++;
                }
                else if (pessoa.Cargo.Equals("Junior"))
                {
                    totalJunior++;
                }
                else  if (pessoa.Cargo.Equals("Sênior"))
                {
                    totalSênior++;
                }

            }
            Console.WriteLine("Total de pessoas");
            Console.WriteLine("Starter: " + totalStarter);
            Console.WriteLine("Junior: " + totalJunior);
            Console.WriteLine("Sênior: " + totalSênior);
        }
    }

    public class Pessoa
    {
        private String nome;
        private String cargo;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Nome { get => nome; set => nome = value; }

        public Pessoa(string nome, string cargo)
        {
            if(!cargo.Equals("Starter") && !cargo.Equals("Junior") && !cargo.Equals("Sênior"))
            {
                cargo  = "Sênior";
            }
            Cargo = cargo;
            Nome = nome;
        }
    }
}
