using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bankAcount
{
    public partial class Default : System.Web.UI.Page
    {
        contaPoup cp = new contaPoup();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                cp.saldo = 2000;
                txtSaldo.Text = cp.saldo.ToString();
                Session["nome"] = "fulano";
                txtTitular.Text = Session["nome"].ToString();
            }

        }

        protected void btnTitular_Click(object sender, EventArgs e)
        {
            cp.setTitular(txtTitular.Text);
            Session["nome"] = cp.Titular;
        }

        protected void btnTransfere_Click(object sender, EventArgs e)
        {
            cp.saldo = Convert.ToDouble(txtSaldo.Text);
            string msg = cp.sacar(Convert.ToDouble(txtTransf.Text));
            txtSaldo.Text = cp.saldo.ToString();
            
            lblMsg.Text = msg;
        }

        protected void lista()
        {
            var contas = new List<Conta>();

            contaInvest invest = new contaInvest();

            invest.setTitular("João");

            contas.Add(invest);
            contas.Add(invest);


        }

        protected void btnTributo_Click(object sender, EventArgs e)
        {
            TotalizaTributo t = new TotalizaTributo();
            contaInvest ci = new contaInvest();
            ci.saldo = 3000;
            cp.saldo = Convert.ToDouble(txtSaldo.Text);
            t.acumula(cp);
            t.acumula(ci);

            txtTributo.Text = t.Total.ToString();
        }
    }
}