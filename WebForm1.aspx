<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="linke_göre_resim.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx?id=1">anakart</asp:HyperLink>
        <div>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebForm2.aspx?id=2">hdd</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/WebForm2.aspx?id=3">ram</asp:HyperLink>
        </div>
    </form>
</body>
</html>
