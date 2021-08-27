<%@ Page Language="C#" MasterPageFile="~/Main.Master"AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PennyJuice.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link href="style/menu.css" rel="stylesheet" />
    <div>
        <h1>Juice List</h1>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal" RepeatColumns="3" CellSpacing="30" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <div style="text-align:center;box-shadow:20px" >
                    <asp:ImageButton ID="ProfilePic" runat="server" Width="400px" Height="400px" CssClass="pic" ImageUrl='<%# Eval("Image") %>' CommandName="viewArtist" CommandArgument='<%# Eval("Id") %>'  />
                    <br />
                    <asp:Label ID="fullnameLabel" runat="server" Font-Size="20px" Font-Bold="true" Text='<%# Eval("JuiceName") %>' />
                    <br />
                    <asp:Label ID="emailLabel" runat="server" ForeColor="Silver" Text='<%# Eval("Price") %>' />
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [JuiceName], [Price], [Image] FROM [Juice]"></asp:SqlDataSource>
    </div>
    


   
</asp:Content>
