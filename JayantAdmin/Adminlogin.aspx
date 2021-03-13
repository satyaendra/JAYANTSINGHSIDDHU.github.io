<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminlogin.aspx.cs" Inherits="Personal_Blog.JayantAdmin.Adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login </title>
    <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Css/global.css" rel="stylesheet" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body style="background-image:url('imge/sexy-girl.jpg')">
    <div class="container-fluid ">
        <div class="row">
            <div class="col-md-4 col-sm-4 col-xs-12"></div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <!--Form Start-->

                <form class="form-conatiner" runat="server">
                    <h1>Admin Login</h1>
  <div class="form-group">
    <label for="exampleInputEmail1">Email / UserId / Phone</label>
    <input type="email" class="form-control" id="txtemail" runat="server" placeholder="Email / UserId / Phone"/>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
    <input type="password" class="form-control" id="txtPassword" runat="server" placeholder="Password"/>
  </div>
  
  <div class="checkbox">
    <label>
      <input type="checkbox"/> Remember me
    </label>
  </div>
  <asp:button ID="btnsub" type="submit" runat="server" Text="Login" class="btn btn-success btn-block" onclick="btnsub_Click"></asp:button>
      <asp:Label ID="lblmsg" runat="server"></asp:Label>   
    
</form>

                <!--Form Start-->
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12"></div>
        </div>

    </div>
</body>
</html>
