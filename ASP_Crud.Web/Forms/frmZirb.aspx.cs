using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_Crud.Business;
using ASP_Crud.Web.Models;

namespace ASP_Crud.Web.Forms
{
    public partial class frmZirb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Zi.Get(null).ToList();
            GridView1.DataBind();

            DropDownListTest.DataSource = Zi.Get(null).ToList(); 
            DropDownListTest.DataBind();
            DropDownListTest.DataTextField = "Data";
            DropDownListTest.DataValueField = "ID";
            DropDownListTest.DataBind();
        }

        protected void ButtonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Zi zi = new Zi();
                zi.Data = DateTime.Now;
                // radiobutton insert
                if(RadioButtonYes.Checked)
                {
                    zi.Checked = "Yes";
                }
                if (RadioButtonNo.Checked)
                {
                    zi.Checked = "No";
                }

                if (RadioButtonYesSolved.Checked)
                {
                    zi.Solved= "YesS";
                }
                if (RadioButtonNoSolved.Checked)
                {
                    zi.Solved = "NoS";
                }
                zi.Comments = TextBox2.Text;

                Zi.Insert(zi);
                MessageBox.Show("Inserted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected void DropDownListTest_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Zi.Get(null).Where(p => p.Comments == TextBox2.Text).FirstOrDefault().Data.ToString();

        }
    }
}