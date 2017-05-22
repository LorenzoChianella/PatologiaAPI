<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medici.aspx.cs" Inherits="ProvaAPIWeb.Medici" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Height="145px" Width="749px" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:Button ID="btnInserisciNuovo" runat="server" Height="39px" Text="Inserisci nuovo medico" Width="144px" OnClick="btnInserisciNuovo_Click"/>
    </form>
</body>
</html>
