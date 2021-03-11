<%@ Page Title="Registrazione" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrazione.aspx.cs" Inherits="WebLibreria.Account.Registrazione" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Page.Title %></h2>

    <div class="form-horizontal">
        <h4>Creare un nuovo account</h4>
        <hr />

        <div>
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2">Posta elettronica</asp:Label>
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
