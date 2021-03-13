<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="Personal_Blog.JayantAdmin.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Query List</title>
    <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../Content/Site.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body >
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-4 col-xs-12 col-sm-6">

                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h3 class="panel-title">&nbsp; List Of Users
                            </h3>
                        </div>
                        <div class="panel-body">
                            <asp:GridView ID="grduser" runat="server"  AutoGenerateColumns="false" EmptyDataText="No Record Found" CssClass="table table-responsive">
                                <Columns>
                                    <asp:TemplateField HeaderText="Serial No" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center">
                                        <ItemTemplate>
                                             <%# Container.DataItemIndex+1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Name" HeaderText="User Name" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                     <asp:BoundField DataField="Email" HeaderText="User Mail"  HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                     <asp:BoundField DataField="Phone" HeaderText="User Contact"  HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                     <asp:BoundField DataField="Subjct" HeaderText="User Subject"  HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                     <asp:BoundField DataField="Msg" HeaderText="User Message"  HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                    <asp:BoundField DataField="CrDate" DataFormatString="{0:dd-MM-yy}" HeaderText="Regitered On"  HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                     <asp:BoundField DataField="CrTime" DataFormatString="{0:dd-MM-yy}" HeaderText="Last Updated On" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                                   <asp:TemplateField HeaderText="Actions" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center">
                                        <ItemTemplate>
                                           <asp:HyperLink ID="hyp" runat="server" Text="Mail" Target="_blank" NavigateUrl='#' ></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>