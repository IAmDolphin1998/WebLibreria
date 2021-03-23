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

    <h2>Storico Ordini</h2>

    <div>
        <asp:DropDownList runat="server" ID="SceltaFasciaPrezzo">
            <asp:ListItem Value="0-1000000" Selected="True">-- Seleziona una opzione --</asp:ListItem>
            <asp:ListItem>0-10</asp:ListItem>
            <asp:ListItem>10-50</asp:ListItem>
            <asp:ListItem>50-100</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList runat="server" ID="SceltaMesi">
            <asp:ListItem Selected="True" Value="100">-- Seleziona una opzione --</asp:ListItem>
            <asp:ListItem Value="3">Ordini degli ultimi 3 mesi</asp:ListItem>
            <asp:ListItem Value="6">Ordini degli ultimi 6 mesi</asp:ListItem>
        </asp:DropDownList>
        <asp:Button runat="server" OnClick="Filtra_Click" Text="Filtra"/>
    </div>

    <p></p>

    <asp:ListView ID="StoricoDeiOrdini" runat="server" ItemType="WebLibreria.Models.Ordine" SelectMethod="GetOrdiniUtente">
        <EmptyDataTemplate>
            <td>Nessun Ordine Effettuato!</td>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <td></td>
        </EmptyItemTemplate>
        <ItemTemplate>
            <div>
                <td>
                    <b>ID Ordine: </b><%#: Item.OrdineID %>
                </td>
                <td>
                    <b>Ordine Effettuato il: </b><%#: Item.DataOrdine %>
                </td>
                <td>
                    <b>Totale Ordine: </b><%#: String.Format("{0:c}", Item.PrezzoOrdine) %>
                </td>
            </div>
            <br />
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
