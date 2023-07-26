<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sqli.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="App_Themes/bootstrap.min.css" rel="stylesheet" />
    <title>Book Library</title>
</head>
<body style="background-color: #D3D0CB;">
    <form class="container-fluid p-5" id="form1" runat="server" style="height: auto; background-color: #9FB1BC; border-radius: 17px;">

        <h2 align="center"><i>Welcome To The Library</i> </h2>
        <hr />

        <div style="background-color: #3E6073; padding: 10px;">
            <div class="mb-3 mt-3">
                <label for="emailtxt" class="form-label">Email:</label>
                <input type="text" class="form-control" id="emailtxt" runat="server" placeholder="Enter email" />
            </div>
            <div class="mb-3">
                <label for="passwordtxt" class="form-label">Password:</label>
                <input type="password" class="form-control" id="passwordtxt" runat="server" placeholder="Enter password" />
            </div>
            <asp:Button ID="loginBTN" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="loginBTN_Click" />

        </div>
    </form>
</body>
</html>
