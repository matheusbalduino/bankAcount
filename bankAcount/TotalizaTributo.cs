using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bankAcount
{
    class TotalizaTributo
    {
        public double Total { get; private set; }
        public void acumula(Tributavel contas)
        {
            this.Total += contas.addTributo();
        }
    }
}