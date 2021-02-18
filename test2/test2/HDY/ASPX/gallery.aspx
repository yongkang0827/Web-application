<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="test2.HDY.ASPX.gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .div1{
            font-family:cursive;
            text-align:left;
        }
        .div2{
            font-family:cursive;
            text-align:left;
        }
    </style>
    <div class="div1">
        <h1>
            Galleries
        </h1>
    </div>
     <div class="div1">         
           <asp:DataList ID="DataList1" runat="server" HorizontalAlign="Justify" RepeatColumns="3" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34ebd2">
               <AlternatingItemStyle BackColor="White" ForeColor="#34ebd2" />
               <FooterStyle BackColor="#5534eb" Font-Bold="True" ForeColor="#f8f7fa" />
               <HeaderStyle BackColor="#5534eb" Font-Bold="True" ForeColor="#f8f7fa" />
               <ItemStyle BackColor="#5534eb" ForeColor="#f8f7fa" />
            <ItemTemplate>
                <table>
                    <tr>
                       <td> <%# Eval("Title") %></td>
                    </tr>
                    <tr><td><asp:Image  Width="320" Height="150" ID="Image1" runat="server" /></td></tr>
                    <tr> 
                        <td>
                            <h4>Price : <%# Eval("Price") %> </h4>
                            <h5>Quantity Remaining : <%# Eval("Quantity") %> </h5>

                        </td>

                    </tr>
                     <tr> <td> <%# Eval("Description") %> </td></tr>
                     <tr> <td> <h6>Upload Date: <%# Eval("DateUpload") %> </h6>  </td></tr>
                                        <tr><td>
                                            <asp:Button ID="btnView" runat="server" Text="Details" />

                                         </td></tr>
                    <tr><td>
                        <asp:Button ID="btnAdd" runat="server" Text="Favourite" OnClick="btnAdd_Click" /></td></tr>
               </table>
                            

            </ItemTemplate>
               <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
            <br />
            <br />

         </div>
</asp:Content>
