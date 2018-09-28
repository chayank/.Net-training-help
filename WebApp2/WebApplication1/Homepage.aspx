<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="WebApplication1.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>webform example</h1>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Home/Index">nav to mvc page</asp:HyperLink>
    </form>
</body>
</html>
