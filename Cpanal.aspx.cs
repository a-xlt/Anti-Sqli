using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Sqli
{
    public partial class Cpanal : System.Web.UI.Page
    {
       

        protected void Page_Init(object sender, EventArgs e)
        {
            ConfLoad(DropDownList1.SelectedValue);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }
        
        protected void SubmitBTN_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath(DropDownList1.SelectedValue));
            XmlNode method1 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method1']");
            XmlNode method2 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method2']");
            XmlNode method3 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method3']");
            
            if (m1.Checked == true){method1.Attributes["value"].Value = "true";}
            else{method1.Attributes["value"].Value = "false";}
            
            if (m2.Checked == true){method2.Attributes["value"].Value = "true";}
            else{ method2.Attributes["value"].Value = "false"; }
            
            if (m3.Checked == true){ method3.Attributes["value"].Value = "true"; }
            else{ method3.Attributes["value"].Value = "false"; }
            doc.Save(Server.MapPath(DropDownList1.SelectedValue));
        }

        protected void m1_CheckedChanged(object sender, EventArgs e)
        {
            if (m1.Checked==true)
            {
                m2.Checked = false;
                m3.Checked = false;
            }
        }

        protected void m2_CheckedChanged(object sender, EventArgs e)
        {
            if (m2.Checked == true)
            {
                m1.Checked = false;
                m3.Checked = false;
            }
        }

        protected void m3_CheckedChanged(object sender, EventArgs e)
        {
            if (m3.Checked == true)
            {
                m2.Checked = false;
                m1.Checked = false;
            }
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            ConfLoad(DropDownList1.SelectedValue);
        }

        protected void ConfLoad(string page_name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath(page_name));
            XmlNode method1 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method1']");
            XmlNode method2 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method2']");
            XmlNode method3 = doc.SelectSingleNode("/configuration/appSettings/add[@key='method3']");

            if (method1.Attributes["value"].Value == "true")
                m1.Checked = true;
            else
                m1.Checked = false;

            if (method2.Attributes["value"].Value == "true")
                m2.Checked = true;
            else
                m2.Checked = false;

            if (method3.Attributes["value"].Value == "true")
                m3.Checked = true;
            else
                m3.Checked = false;
        }
    }
}