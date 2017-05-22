<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InserisciMedico.aspx.cs" Inherits="ProvaAPIWeb.InserisciMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <section class="container content-container">

            <fieldset>
                <legend>Inserimento NUovo Medico</legend>
                <div class="form-group">
                    <label for="txtnome">Nome: <span style="color: red;">*</span></label>
                    <asp:TextBox ID="txtnome" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtcognome">Cognome: <span style="color: red;">*</span></label>
                    <asp:TextBox ID="txtcognome" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtdatanascita">Data di nascita: <span style="color: red;">*</span></label>
                    <asp:TextBox ID="txtdatanascita" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtluogo">Luogo di nascita: <span style="color: red;">*</span></label>
                    <asp:TextBox ID="txtluogo" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtcodicefiscale">Codice fiscale: <span style="color: red;">*</span></label>
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
                    <label for="txttel">Telefono:</label>
                    <asp:TextBox ID="txttel" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtcell">Mobile:</label>
                    <asp:TextBox ID="txtcell" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtemail">Email:</label>
                    <asp:TextBox ID="txtemail" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtcodalbo">Codice albo:</label>
                    <asp:TextBox ID="txtcodalbo" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtcodmedico">Codice medico:</label>
                    <asp:TextBox ID="txtcodmedico" runat="server" class="form-control"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnSalva" runat="server" Text="Inserisci" Width="142px" OnClick="btnSalva_Click" />
                </div>

                
            </fieldset>

        </section>
    </form>
</body>
</html>
