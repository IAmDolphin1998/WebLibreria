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
                    <b>Totale Ordine: </b><%#: Item.PrezzoOrdine %>
                </td>
            </div>
            <%--<asp:ListView ID="ProdottiOrdinati" runat="server" ItemType="WebLibreria.Models.Prodotto" SelectMethod="ProdottiOrdinati_GetData">
                <ItemTemplate>
                    <div>
                        <td>
                            <img src="Immagini/<%#: Item.ImmaginePercorso %>" width="150" height="280" style="padding-right: 10px;"/>
                        </td>
                        <td>

                        </td>
                    </div>
                </ItemTemplate>
            </asp:ListView>--%>
            <br />
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
