using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Sqli
{
    public partial class mainpage : System.Web.UI.Page
    {
        private readonly string cs = "Data Source=Prince-A\\SQLEXPRESS2019;Initial Catalog=SQLI;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"]==null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim()!="")
            {
            Tuple<bool, string> searchtext = Security.Check(TextBox1.Text.Trim(), Request.PhysicalApplicationPath , "MainpageSecurityConf.config");
                if (searchtext.Item1==true)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = cs;
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = con;
                    command.CommandText = "SELECT * FROM Books WHERE BookName like N'%" + searchtext.Item2 + "%' ";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    { 
                        HtmlGenericControl a = new HtmlGenericControl("a");
                        a.InnerText = reader[1].ToString();
                        a.Attributes["href"] = reader[2].ToString();
                        a.Attributes["class"] = "resText";
                        a.Attributes["target"] = "blank";
                        search_results.Controls.Add(a);
                        search_results.Controls.Add(new HtmlGenericControl("hr"));
                    }
                    reader.Close();
                    con.Close();
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "x3", "alert('U used Forbidden Character !');", true);
                }

            }
           





        }
    }
}