<%@ Page Title="Cerca Prodotto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CercaProdotto.aspx.cs" Inherits="WebLibreria.CercaProdotto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Page.Title %></h2>

    <div class="form-horizontal">
        <h4>Impostare i filtri di ricerca</h4>
        <hr />

        <div>
           <div>
            <strong>
                <asp:Label runat="server" CssClass="col-md-2">Titolo</asp:Label>
            </strong>   
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Titolo" CssClass="form-control"></asp:TextBox>
            </div>
           </div>
            
           <br />

           <div>
            <strong>     
                <asp:Label runat="server" CssClass="col-md-2">Autore</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Autore" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Editore</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Editore" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Genere</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Genere" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Categoria</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Categoria" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Edizione</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Edizione" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Prezzo DA</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PrezzoDA" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Prezzo A</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PrezzoA" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
        </div>

           <br />

           <div>
            <strong>
                <br />
                <asp:Label runat="server" CssClass="col-md-2">Novità</asp:Label>
            </strong>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Novità" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
           <br />
         </div>
    </div>
        
    <asp:Button runat="server" OnClick="Cerca_Click" Text="Cerca!" CssClass="btn btn-default" />
        
    <div>
        <br />
        <asp:GridView ID="ListaRisultati" runat="server" AutoGenerateColumns="false" ItemType="WebLibreria.Models.Prodotto" SelectMethod="Cerca" CssClass="table table-striped table-bordered">
           <Columns>
                <asp:BoundField DataField="ProdottoID" HeaderText="ID" />
                <asp:BoundField DataField="Titolo" HeaderText="Nome" />
                <asp:BoundField DataField="Prezzo" HeaderText="Prezzo" DataFormatString="{0:c}"/>
           </Columns>
        </asp:GridView>
    </div>
</asp:Content>
