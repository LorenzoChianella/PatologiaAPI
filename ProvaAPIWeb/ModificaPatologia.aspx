﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificaPatologia.aspx.cs" Inherits="ProvaAPIWeb.ModificaPatologia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Modifica Patologia</title>
    <meta name="description" content="Free Bootstrap Theme by BootstrapMade.com" />
    <meta name="keywords" content="free website templates, free bootstrap themes, free template, free bootstrap, free website template" />

    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Open+Sans|Raleway|Candal" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body  id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">

    <!--#include file="templates/menu.tpl"-->

    <div class="container">

        <div class="col-md-3"></div>
        <div class="col-md-6">
    <section class="container content-container">
        <form id="formPatologia" runat="server">
            <fieldset>
                <legend>Modifica Patologia</legend>
                <div class="form-group">
                    <label for="txtcod_patologia">Codice:</label>
                    <br />
                    <asp:TextBox ID="txtcod_patologia" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtnome">Nome:</label>
                    <asp:TextBox ID="txtnome" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtdescrizione">Descrizione:</label>
                    <asp:TextBox ID="txtdescrizione" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                </div>
                <br />
                <div class="btn-group">

                    <asp:Button ID="btnSalva" runat="server" Height="34px" Text="Salva" Width="148px" OnClick="btnSalva_Click"/>

                </div>
            </fieldset>

        </form>

    </section>
            </div>
    </div>

    <!--#include file="templates/footer.tpl"-->

</body>
</html>
