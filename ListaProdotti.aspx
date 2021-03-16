<%@ Page Title="HomePage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProdotti.aspx.cs" Inherits="WebLibreria.ListaProdotti" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>WebLibreria</h1>
    </div>

    <section>
        <div>
            <hgroup>
                <h2>Prodotti</h2>
            </hgroup>
            <asp:ListView ID="ListadeiProdotti" runat="server" DataKeyNames="ProdottoID" ItemType="WebLibreria.Models.Prodotto" SelectMethod="GetProdotti">
               <EmptyDataTemplate>
                   <table>
                       <tr>
                           <td>Nessun dato presente nel nostro archivio!</td>
                       </tr>
                   </table>
               </EmptyDataTemplate>
               <EmptyItemTemplate>
                   <td />
               </EmptyItemTemplate> 
               <ItemTemplate>
                       <table>
                           <td>
                               <a href="DettaglioProdotto.aspx?ProdottoID=<%#: Item.ProdottoID %>">
                                       <img src="Immagini/<%#: Item.ImmaginePercorso %>" width="200" height="295" style="padding-right: 10px;"/>
                               </a>
                           </td>
                           <td>
                               <a href="DettaglioProdotto.aspx?ProdottoID=<%#: Item.ProdottoID %>">
                                       <span>
                                           <%#: Item.Titolo %>
                                       </span>
                                   </a>
                               <br />
                                   <span>
                                       <b>Descrizione:</b><%#: Item.Descrizione %></span><br />
                               <span><b>Prezzo:</b><%#: String.Format("{0:c}", Item.Prezzo) %></span>
                               <br />
                               <a href="AggiungiCarrello.aspx?ProdottoID=<%#: Item.ProdottoID %>"><b>Aggiungi nel carrello</b>
                               </a> 
                       </table>
                   <p>&nbsp</p>
               </ItemTemplate>
            </asp:ListView>
        </div>
    </section>

</asp:Content>
