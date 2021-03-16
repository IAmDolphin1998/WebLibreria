<%@ Page Title="Profilo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profilo.aspx.cs" Inherits="WebLibreria.Account.Profilo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2><%: Page.Title %></h2>
    </div>
    <asp:FormView ID="InformazioniUtente" runat="server" ItemType="WebLibreria.Models.Utente" SelectMethod="GetUtente">
        <ItemTemplate>
            <td>
                <b>Nome: </b><%#: Item.Nome %>
                <br />
                <b>Cognome: </b><%#: Item.Cognome %>
                <br />
                <b>Sesso: </b><%#: Item.SessoUtente %>
                <br />
                <b>Data di nascita: </b><%#: Item.DataNascita.ToString("dd/MM/yyyy") %>
                <br />
                <b>Città di nascita: </b><%#: Item.CittàNascita %>
                <br />
                <b>Email: </b><%#: Item.Email %>
            </td>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
