<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificaPatologia.aspx.cs" Inherits="ProvaAPIWeb.ModificaPatologia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
</body>
</html>
