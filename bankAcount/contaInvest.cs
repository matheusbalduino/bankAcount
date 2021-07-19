using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankAcount
{
    public class contaInvest: Conta, Tributavel
    {
        public double tributo { get; set; }
        public void addJuros()
        {
            this.saldo = this.saldo * 0.2;
        }
        public double addTributo()
        {
            return this.saldo * 0.3;
        }
    }
}