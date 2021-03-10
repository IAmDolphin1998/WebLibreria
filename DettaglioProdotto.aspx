<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DettaglioProdotto.aspx.cs" Inherits="WebLibreria.DettaglioProdotto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="DettagliodelProdotto" runat="server" ItemType="WebLibreria.Models.Prodotto" SelectMethod="GetProdotto">
        <ItemTemplate>
            <div>
                <h1><%#: Item.Titolo %></h1>
            </div>
            <br />
            <table>
                <td>
                    <img src="Immagini/<%#: Item.ImmaginePercorso %>" width="200" height="295"/>
                </td>
                <td>
                        <b>Descrizione: </b><%#: Item.Descrizione %>
                        <br />
                        <span><b>ISBN: </b><%#: Item.ISBN %></span>
                        <br />
                        <span><b>Autore: </b><%#: Item.Autore %></span>
                        <br />
                        <span><b>Editore: </b><%#: Item.Editore %></span>
                        <br />
                        <span><b>Genere: </b><%#: Item.Genere %></span>
                        <br />
                        <span><b>Categoria: </b><%#: Item.Categoria %></span>
                        <br />
                        <span><b>Edizione: </b><%#: Item.Edizione %></span>
                        <br />
                        <span><b>Numero pagine: </b><%#: Item.NumeroPagine %></span>
                        <br />
                        <span><b>Prezzo: </b><%#: String.Format("{0:c}", Item.Prezzo) %></span>
                        <br />
                        <span><b>Disponibilità: </b><%#: Item.Disponibilità ? "Disponibilità immediata" : "Non disponibile" %></span>
                        <br />
                        <span><b>Data pubblicazione: </b><%#: Item.DataInserimento.Year %></span>
                        <br />
                        <span><b>Novità: </b><%#: Item.Novità %></span>
                        <br />
                    </td>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
