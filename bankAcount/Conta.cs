using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankAcount
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double saldo { get; set; }

        public string sacar(double qtde)
        {
            if(qtde > this.saldo)
            {
                string msg = "Valor indisponível";
                return msg; 
            }
            if(qtde < 0)
            {
                return "Espertinho, negativo não pode";
            }
            
            this.saldo -= qtde;
            return $"Novo Saldo {this.saldo}";
        }

        public void depositar(double qtde)
        {
            this.saldo += qtde;
        }

        public void setTitular(string nome)
        {
            this.Titular = nome;
        }
    }
}