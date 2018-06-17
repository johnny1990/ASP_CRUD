using ASP_Crud.Business;
using ASP_Crud.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Crud.Web.Forms
{
  
    public partial class frmProduse : System.Web.UI.Page
    {
  
        protected void Page_Load(object sender, EventArgs e)
        {
          
            List<string> cat = new List<string>();
            cat.Add("c1");
            cat.Add("c2");
            DropDownList1.DataSource = cat;
            DropDownList1.DataBind();

            //List<string> tva = new List<string>();
            //tva.Add("19");
            //tva.Add("24");
            //tva.Add("5");
            //tva.Add("0");
            //DropDownList2.DataSource = tva;
            //DropDownList2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Produse prod = new Produse();
                prod.Produs = TextBox2.Text;
                prod.Pret = decimal.Parse(TextBox4.Text);
                prod.Cantitate = int.Parse(TextBox5.Text);
                prod.Categorie = DropDownList1.SelectedValue;
                Produse.Insert(prod);
                MessageBox.Show("salvat cu succes Produs");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //DE ADAUGAT MAIN CONNECTION STRING!!!!!!
        }
    }
}