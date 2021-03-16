<%@ Page Title="Registrazione" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrazione.aspx.cs" Inherits="WebLibreria.Account.Registrazione" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Page.Title %></h2>

    <div class="form-horizontal">
        <h4>Creare un nuovo account</h4>
        <hr />

        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage"></asp:Literal>
        </p>

        <div>
            <asp:Label runat="server" AssociatedControlID="Nome" CssClass="col-md-2">Nome</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Nome" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Nome" CssClass="text-danger" ErrorMessage="Il campo Nome è obbligatorio!"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div>
            <asp:Label runat="server" AssociatedControlID="Cognome" CssClass="col-md-2">Cognome</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Cognome" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Cognome" CssClass="text-danger" ErrorMessage="Il campo Cognome è obbligatorio!"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div>
            <strong>
                <asp:Label ID="Sesso" runat="server" CssClass="col-md-2">Sesso</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:DropDownList ID="SessoScelta" runat="server" CssClass="form-control">
                    <asp:ListItem>Maschio</asp:ListItem>
                    <asp:ListItem>Femmina</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div>
            <asp:Label runat="server" AssociatedControlID="DataNascita" CssClass="col-md-2">Data di nascita</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="DataNascita" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="DataNascita" CssClass="text-danger" ErrorMessage="Il campo Data di nascita è obbligatorio!"></asp:RequiredFieldValidator>
            </div>
       </div>

        <div>
            <strong>
                <asp:Label ID="CittàNascita" runat="server" CssClass="col-md-2">Città di nascita</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:DropDownList ID="CittàNascitaScelta" runat="server" CssClass="form-control">
                    <asp:ListItem>Reggio Calabria</asp:ListItem>
                    <asp:ListItem>Cosenza</asp:ListItem>
                    <asp:ListItem>Catanzaro</asp:ListItem>
                    <asp:ListItem>Crotone</asp:ListItem>
                    <asp:ListItem>Vibo Valentia</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div>
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2">Posta elettronica (Nome utente)</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" CssClass="text-danger" ErrorMessage="Il campo Posta elettronica è obbligatorio!"></asp:RequiredFieldValidator>
            </div>
       </div>

        <div>
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="Il campo Password è obbligatorio!"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div>
            <asp:Label runat="server" AssociatedControlID="ConfermaPassword" CssClass="col-md-2">Conferma Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfermaPassword" CssClass="form-control" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="ConfermaPassword" CssClass="text-danger" ErrorMessage="Il campo Conferma Password è obbligatorio!"></asp:RequiredFieldValidator>
                <asp:CompareValidator runat="server" ControlToCompare="Password" Display="Dynamic" ControlToValidate="ConfermaPassword" CssClass="text-danger" ErrorMessage="La password e la password di conferma non corrispondono!"></asp:CompareValidator>
            </div>
        </div>

        <div>
            <div class="col-md-10">
                <asp:Button runat="server" OnClick="CreaUtente_Click" Text="Esegui registrazione" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
