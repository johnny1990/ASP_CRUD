using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASP_Crud.Web.Forms
{
    public partial class frmDropDownListBind : System.Web.UI.Page
    {
        string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Aplicatii VS\\ASP_Crud\\ASP_Crud.Web\\App_Data\rohatash.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            string com = "Select * from UserDetail";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from UserDetail where id = '" + DropDownList1.SelectedValue + "'", con);
            SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adpt.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label1.Text = "record found";
        }
    }
}