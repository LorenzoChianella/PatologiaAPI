<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patologie.aspx.cs" Inherits="ProvaAPIWeb.Patologie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Patologie</title>
    <meta name="description" content="Free Bootstrap Theme by BootstrapMade.com" />
    <meta name="keywords" content="free website templates, free bootstrap themes, free template, free bootstrap, free website template" />

    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Open+Sans|Raleway|Candal" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />

    <link href="./css/DataTables/css/jquery.dataTables.min.css" rel="stylesheet" />
    <script src="./scripts/modernizr-2.6.2.js"></script>
    <script src="./scripts/jquery-2.2.0.min.js"></script>
    <script src="./scripts/jquery-ui-1.10.2.min.js"></script>
    <script src="./scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="./scripts/MyScripts.js"></script>
    <script src="./scripts/bootstrap.min.js"></script>
</head>
<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">
    <!--#include file="templates/menu.tpl"-->

    <section class="container content-container">
    <form id="form1" runat="server">
         <div class="table-wrapper col-md-12">
                <h3>Tabella Patologie</h3>
                <div class="searchInput">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Cerca" />
                </div><br />

            <asp:GridView ID="GridView1" runat="server" Height="140px" Width="1269px" OnRowDeleting="Gridview1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCreated="GridView1_RowCreated" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />

                    <asp:CommandField ShowEditButton="True" />

                </Columns>
            </asp:GridView>

        </div>
        
        <asp:Button ID="btnInserisci" runat="server" Height="38px" Text="Inserisci nuova Patologia" Width="171px" OnClick="btnInserisci_Click" />
        
    </form>
    </section>

    <!--#include file="templates/footer.tpl"-->
</body>
</html>
