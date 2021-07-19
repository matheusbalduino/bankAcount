using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankAcount
{
    public class contaPoup: Conta, Tributavel
    {
        public double tributo { get; set; }
        public void addJuros(double juros = 0.1)
        {
            this.saldo = this.saldo * juros;
        }

        public double addTributo()
        {
            return this.saldo * 0.3;
        }
    }
}