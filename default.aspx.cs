using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Sqli
{
    
    public partial class Default : System.Web.UI.Page
    {
        private readonly string cs = "Data Source=Prince-A\\SQLEXPRESS2019;Initial Catalog=SQLI;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBTN_Click(object sender, EventArgs e)
        {
            if (emailtxt.Value.Trim()!="" && passwordtxt.Value.Trim()!= "")
            {
                Tuple<bool,string> email = Security.Check(emailtxt.Value, Request.PhysicalApplicationPath,"LoginSecurityConf.config");
                Tuple<bool, string> password = Security.Check(passwordtxt.Value , Request.PhysicalApplicationPath,"LoginSecurityConf.config");
                if (email.Item1==true && password.Item1==true)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = cs;
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = con;
                    command.CommandText = "SELECT * FROM Login WHERE username = N'"+email.Item2+"' AND password = N'"+password.Item2+"'";
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()==true)
                    {
                        Session["login"] = "ok";
                        Response.Redirect("mainpage.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "x3", "alert('Email OR Password Is Wrong !');", true);
                    }

                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "x3", "alert('U used Forbidden Character !');", true);
                }
            }

            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "x3", "alert('Email AND Password Is Required !');", true);
            }

        }
    }
}