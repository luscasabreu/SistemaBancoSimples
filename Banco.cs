using System;
using System.Globalization;
namespace Course
{
    class Banco
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Banco(int numeroconta, string nome)
        {
            this.NumeroConta = numeroconta;
            this.Nome = nome;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia, double taxa = 5.00)
        {
            Saldo -= quantia + taxa;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", " + 
                "Titular: " + Nome + ", " 
                + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
