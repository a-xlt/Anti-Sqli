<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cpanal.aspx.cs"
Inherits="Sqli.Cpanal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="App_Themes/bootstrap.min.css" rel="stylesheet" />

    <title>Book Library</title>
  </head>
  <body>
    <form
      class="container-fluid p-5"
      id="form1"
      runat="server"
      style="height: auto; background-color: #9fb1bc; border-radius: 17px"
    >
      <h2 align="center"><i>Welcome To The Library</i></h2>
      <hr />
      <div style="background-color: #3e6073; padding: 10px">
        <h4 align="center">
          Choose The methods to Protect The site From SQL Injection
        </h4>
        <hr />
          <asp:DropDownList  ID="DropDownList1" runat="server" CssClass="form-select" AutoPostBack="true" OnTextChanged="DropDownList1_TextChanged">
              <asp:ListItem  Text="Main Page" Value="MainpageSecurityConf.config" Selected="True" ></asp:ListItem>
              <asp:ListItem  Text="Login Page" Value="LoginSecurityConf.config"></asp:ListItem>
          </asp:DropDownList>
          <br />
          <br />
          <h5>
          <asp:CheckBox
            ID="m1"
            runat="server"
            Text="Replace The Forbidden Charecter with Blanks"
              AutoPostBack="true"
              OnCheckedChanged="m1_CheckedChanged"
          />
        </h5>
        <br /><br />
        <h5>
          <asp:CheckBox
            ID="m2"
            runat="server"
            Text="Replace The Forbidden Charecter with words"
              AutoPostBack="true"
              OnCheckedChanged="m2_CheckedChanged"
          />
        </h5>
        <br /><br />
        <h5>
          <asp:CheckBox
            ID="m3"
            runat="server"
            Text="Show message with Error Entry"
              AutoPostBack="true"
              OnCheckedChanged="m3_CheckedChanged"
          />
        </h5>
        <br /><br />
        
        <asp:Button
          ID="SubmitBTN"
          runat="server"
          Text="Submit Change"
          CssClass="btn btn-success"
          OnClick="SubmitBTN_Click"
        />
      </div>
    </form>
  </body>
</html>
