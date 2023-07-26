<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainpage.aspx.cs" Inherits="Sqli.mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="App_Themes/bootstrap.min.css" rel="stylesheet" />
    <style>
        #Button1{
            background-color: aliceblue;
            border-radius: 0px 17px 17px 0px;
        }
        .searchT
        {
            background: linear-gradient(180deg, #B9C1C4 0%, #6E8898 100%);
            border-radius: 17px 0px 0px 17px;
            color:whitesmoke;
        }
        .resText{
            font-family: 'Kurale';
font-style: normal;
font-weight: 400;
font-size: 32px;
line-height: 47px;
text-decoration-line: underline;
background: linear-gradient(180deg, #C01DDB 19.06%, #5C6D78 51.35%, #C41DDF 88.33%);
-webkit-background-clip: text;
-webkit-text-fill-color: transparent;
background-clip: text;
text-fill-color: transparent;
        }
    </style>
    <title>Book Library</title>
</head>
<body>
    <form class="container-fluid p-5" id="form1" runat="server" style=" height:auto; background-color: #9FB1BC;border-radius: 17px;">
      
        <h2 align="center" > <i><u>Welcome To The Library</u></i> </h2>
        <hr/>
        <div class="input-group mb-3">
            
            <asp:TextBox ID="TextBox1"  runat="server" CssClass="form-control searchT" ToolTip="write book name here..."></asp:TextBox>
            
            <asp:Button CssClass="btn sea" OnClick="Button1_Click" ID="Button1" runat="server" Text="Search" />

            
        </div>
            <br />
        <br />
        <div runat="server" id="search_results">

            </div>
    </form>
</body>
</html>
