using System;

namespace investimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            InvestimentoComIR ir  = new InvestimentoComIR(4000, 1.2);
            InvestimentoSemIR semir = new InvestimentoSemIR(2000, 0.7);

            Console.WriteLine("Lucro InvestimentoComIR: " + ir.CalcularLucro(17));
            Console.WriteLine("Lucro InvestimentoSemIR: " + semir.CalcularLucro(10));

        }
    }

    public abstract class Investimento
    {
        private double valorInicial;
        private double jurosMensais;

        public double ValorInicial { get => valorInicial; set => valorInicial = value; }
        public double JurosMensais { get => jurosMensais; set => jurosMensais = value; }

        public  double JurosMensaisCalculo { get => jurosMensais / 100; }

        public virtual double CalcularLucro(int meses)
        {
            double x = Math.Pow(1 + JurosMensaisCalculo, meses);
            
            double v = (valorInicial * x) - valorInicial;
            return Math.Round(v, 2);
        }

        protected Investimento(double valorInicial, double jurosMensais)
        {
            ValorInicial = valorInicial;
            JurosMensais = jurosMensais;
        }
    }

    public class InvestimentoComIR : Investimento
    {
        public InvestimentoComIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
        }

        public override double CalcularLucro(int meses)
        {
            double desconto = 0;
            if(meses < 6)
            {
                desconto = 22.5;
            }
            else if (meses >= 6 && meses <= 12)
            {
                desconto = 20;
            }
            else if (meses >= 12 && meses <= 24)
            {
                desconto = 17.5;
            }
            else if (meses >= 24)
            {
                desconto = 15;
            }
            double l = base.CalcularLucro(meses);
            return Math.Round(l - (l * desconto / 100), 2);
        }



    }
    public class InvestimentoSemIR : Investimento
    {
        public InvestimentoSemIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
        }

        public override double CalcularLucro(int meses)
        {
            
            if(ValorInicial < 1000)
            {
               Console.WriteLine("O  valor inicial não pode ser menor que R$1000");
                return 0;
            }
            return base.CalcularLucro(meses);   
        }



    }

}
