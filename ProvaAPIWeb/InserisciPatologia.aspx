<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InserisciPatologia.aspx.cs" Inherits="ProvaAPIWeb.InserisciPatologia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Inserisci Patologia</title>
    <meta name="description" content="Free Bootstrap Theme by BootstrapMade.com" />
    <meta name="keywords" content="free website templates, free bootstrap themes, free template, free bootstrap, free website template" />

    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Open+Sans|Raleway|Candal" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>

<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">

    <!--#include file="templates/menu.tpl"-->



    <div class="container">

        <div class="col-md-3"></div>
        <div class="col-md-6">
            <section class="container content-container">
                <form runat="server">
                    <fieldset>
                        <legend>Inserimento Nuova Patologia</legend>
                        <div class="form-group">
                            <label for="txtcodice">Codice:</label>
                            <asp:TextBox ID="txtcodice" runat="server" class="form-control" CssClass="auto-style2" Width="191px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtnome">Nome:</label>
                            <asp:TextBox ID="txtnome" runat="server" class="form-control" CssClass="auto-style1" Width="198px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtdescrizione">Descrizione:</label>
                            <asp:TextBox ID="txtdescrizione" runat="server" class="form-control" Rows="5" TextMode="MultiLine" Width="238px"></asp:TextBox>
                        </div>


                        <asp:Button ID="btnSalva" runat="server" Height="31px" OnClick="btnSalva_Click" Text="Salva" Width="100px" />

                    </fieldset>
                </form>
            </section>
        </div>

        <div class="col-md-2"></div>



    </div>
    <!--#include file="templates/footer.tpl"-->


</body>
</html>
