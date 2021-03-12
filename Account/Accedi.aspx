<%@ Page Title="Accedi" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Accedi.aspx.cs" Inherits="WebLibreria.Account.Accedi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Page.Title %></h2>

    <div class="form-horizontal">
        <h4>Accedi con le tue credenziali</h4>
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
            <div class="col-md-10">
                <asp:Button runat="server" OnClick="LogIn_Click" Text="Accedi" CssClass="btn btn-default" />
            </div>
        </div>

    </div>
</asp:Content>
