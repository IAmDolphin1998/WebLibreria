<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="WebLibreria.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="TitoloCarrello" runat="server">
        <h1>Carrello</h1>
    </div>

    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage"></asp:Literal>
    </p>

    <asp:GridView ID="ListaCarrello" runat="server" AutoGenerateColumns="false" ItemType="WebLibreria.Models.ProdottoCarrello" SelectMethod ="GetProdottiCarrello" CssClass="table table-striped table-bordered">
       <Columns>
           <asp:BoundField DataField="Prodotto.ProdottoID" HeaderText="ID" />
           <asp:BoundField DataField="Prodotto.Titolo" HeaderText="Nome" />
           <asp:BoundField DataField="Prodotto.Descrizione" HeaderText="Descrizione" />
           <asp:BoundField DataField="Prodotto.Prezzo" HeaderText="Prezzo" DataFormatString="{0:c}"/>
           <asp:TemplateField HeaderText="Quantità">
               <ItemTemplate>
                   <asp:TextBox ID="QuantitàProdotto" runat="server" Text="<%#: Item.Quantità %>"></asp:TextBox>
               </ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Totale">
               <ItemTemplate>
                   <%#: String.Format("{0:c}", (Convert.ToDouble(Item.Quantità)*Convert.ToDouble(Item.Prodotto.Prezzo))) %>
               </ItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="Rimuovi Prodotto">
               <ItemTemplate>
                   <asp:CheckBox ID="Rimuovi" runat="server" />
               </ItemTemplate>
           </asp:TemplateField>
       </Columns>
    </asp:GridView>
    <div>
        <strong>
            <asp:Label ID="LabelTotale" runat="server" Text="Totale Ordine: "></asp:Label>
            <asp:Label ID="Totale" runat="server"></asp:Label>
        <br />
        </strong>
        <br />
        <b>
            <asp:Button ID="Aggiorna" runat="server" Text="Aggiorna Carrello" OnClick="Aggiorna_Click" />
            <asp:Button ID="ConfermaAcquisto" runat="server" Text="Aquista" OnClick="ConfermaAcquisto_Click" />
        </b>
    </div>
</asp:Content>
