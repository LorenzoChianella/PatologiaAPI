<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificaPaziente.aspx.cs" Inherits="ProvaAPIWeb.ModificaPaziente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Modifica Paziente</title>
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
                <form id="formPaziente" runat="server">
                    <fieldset>
                        <legend>Modifica Paziente</legend>
                       <div class="form-group">
                            <label for="txtnome">Nome: <span style="color: red;" >*</span></label>
                            <asp:TextBox ID="txtnome" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtcognome">Cognome: <span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtcognome" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtdatanascita">Data di Nascita: <span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtdatanascita" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtluogo">Luogo di Nascita: <span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtluogo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtcodicefiscale">Codice Fiscale: <span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtcodicefiscale" runat="server" class="form-control" MaxLength="16"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtresidenza">Residenza: <span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtresidenza" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtprovincia">Provincia:</label>
                            <asp:TextBox ID="txtprovincia" runat="server" class="form-control" MaxLength="2"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtindirizzo">Indirizzo:</label>
                            <asp:TextBox ID="txtindirizzo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txttel">Telefono Fisso:</label>
                            <asp:TextBox ID="txttel" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtcell">Telefono Mobile:</label>
                            <asp:TextBox ID="txtcell" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtemail">Email:</label>
                            <asp:TextBox ID="txtemail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                        </div>
                        <div class="form-group">

                            <label for="CodiceSanitario">Codice Sanitario: <span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtcodicesanitario" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="ddlmedico">Medico:</label><br />
                            <asp:DropDownList ID="ddlmedico" runat="server" DataSourceID="SqlDataSource1" DataValueField="codice" DataTextField="dottore" Width="100%" ></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="txtsesso">Sesso:</label>
                            <asp:TextBox ID="txtsesso" runat="server" class="form-control" MaxLength="1"></asp:TextBox>
                        </div>
                        <div class="form-group">

                            <label for="txtcap">CAP:<span style="color: red;">*</span></label>
                            <asp:TextBox ID="txtcap" runat="server" class="form-control" MaxLength="5"></asp:TextBox>
                        </div>
                        <br />
                        <div class="btn-group">
                            <asp:Button ID="btnsalva" runat="server" Text="Salva Modifiche" class="btn btn-primary" OnClick="btnsalva_Click" Style="margin-right: 10px" />
                            <a href="Pazienti.aspx" class="btn btn-primary">Annulla</a>
                        </div>
                    </fieldset>
                </form>
            </section>
        </div>
    </div>

    <!--#include file="templates/footer.tpl"-->

    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.easing.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/custom.js"></script>
    <!--<script src="contactform/contactform.js"></script>-->

</body>
</html>
