using System;
using System.Globalization;

namespace ProblemaContaBancária
{
    class ContaBancaria
    {

        private double SaldoConta;
        private static double Taxa = 5.0;
        public int NumConta { get; }
        public string NomeTitular { get; set; }

        public ContaBancaria(int numConta, string nome, double valorIni)
        {
            NumConta = numConta;
            NomeTitular = nome;
            SaldoConta = valorIni;
        }

        public ContaBancaria(int numConta, string nome)
        {
            NumConta = numConta;
            NomeTitular = nome;
        }

        public double Saldo
        {
            get { return SaldoConta; }

        }


        public void AdicionarDeposito(double valorDeposito)
        {
            SaldoConta += valorDeposito;
        }
        public void RemoverSaque(double valorSaque)
        {
            SaldoConta -= valorSaque + Taxa;
        }

        public override string ToString()
        {
            return $"Conta: {NumConta}, " +
                $"Titular: {NomeTitular}, " +
                $"Saldo: $ {SaldoConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
