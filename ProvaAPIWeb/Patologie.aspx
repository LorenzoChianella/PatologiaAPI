﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patologie.aspx.cs" Inherits="ProvaAPIWeb.Patologie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" Height="140px" Width="1269px" OnRowDeleting="Gridview1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCreated="GridView1_RowCreated" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />

                    <asp:CommandField ShowEditButton="True" />

                </Columns>
            </asp:GridView>

        </div>
        
        <asp:Button ID="btnInserisci" runat="server" Height="38px" Text="Inserisci nuova Patologia" Width="171px" OnClick="btnInserisci_Click" />
        
    </form>
</body>
</html>
