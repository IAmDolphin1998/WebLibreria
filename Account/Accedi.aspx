<%@ Page Title="Accedi" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Accedi.aspx.cs" Inherits="WebLibreria.Account.Accedi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Page.Title %></h2>
    <hr />  
   
    <asp:Login ID="LogIn" runat="server" OnAuthenticate="LogIn_Authenticate"></asp:Login>
    
</asp:Content>
