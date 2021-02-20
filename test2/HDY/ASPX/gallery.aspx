<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="test2.HDY.ASPX.gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .div1{
            font-family:cursive;
            text-align:center;
            left:1000px;
        }
        .div2{
            font-family:cursive;
            text-align:left;
        }
        .auto-style2 {
            height: 30px;
            width: 320px;
        }
        .auto-style3 {
            width: 320px;
        }
        .div3{
            left:480px;
            top:700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div4{
            left:480px;
            top:1200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div5{
            left:480px;
            top:1700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div6{
            left:480px;
            top:2200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
         .div7{
            left:480px;
            top:2700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div8{
            left:480px;
            top:3200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div9{
            left:480px;
            top:3700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div10{
            left:480px;
            top:4200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div11{
            left:480px;
            top:4700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        </style>
    <div class="div1">
        <h1>
            Galleries
        </h1>
    </div>
     <div class="div1">         
         <asp:DataList ID="DataList1" runat="server" HorizontalAlign="Justify" RepeatColumns="2" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34EBD2">
               <AlternatingItemStyle BackColor="#9ba2d1" ForeColor="#7e89cf" />
               <FooterStyle BackColor="#9ba2d1" Font-Bold="True" ForeColor="#7e89cf" />
               <HeaderStyle BackColor="#7e89cf" Font-Bold="True" ForeColor="#9ba2d1" />
               <ItemStyle BackColor="#40488f" ForeColor="#9ba2d1" />
            <ItemTemplate>
                <table>
                    <tr><td class="auto-style3"><%# Eval("PostId") %></td></tr>
                    <tr>
                       <td class="auto-style3"> <%# Eval("Title") %></td>
                    </tr>
                    <tr><td class="auto-style3"><asp:Image  Width="320" Height="150" ID="Image1" runat="server" /></td></tr>
                    <tr> 
                        <td class="auto-style3">
                            <h4>Price : <%# Eval("Price") %> </h4>
                            <h5>Quantity Remaining : <%# Eval("Quantity") %> </h5>

                        </td>

                    </tr>
                     <tr> <td class="auto-style3"> <%# Eval("Description") %> </td></tr>
                     <tr> <td class="auto-style3"> <h6>Upload Date: <%# Eval("DateUpload") %> </h6>  </td></tr>
                                        <tr><td class="auto-style2">
                                            &nbsp;</td></tr>
                    <tr><td class="auto-style3">
                        &nbsp;</td></tr>
               </table>
                            

            </ItemTemplate>
               <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Justify" />
            </asp:DataList>
           

         </div>

         <div class="div3">
         <table>
             <tr><td><asp:Button ID="btnOrder1" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav1" runat="server" Text="Add Favourite" OnClick="btnFav1_Click" />
                    <td><asp:Button ID="btnOrder2" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav2" runat="server" Text="Add Favourite" OnClick="btnFav2_Click" /></td></td></td></td></tr>

         </table>
         </div>
          <div class="div4">
         <table>
             <tr><td><asp:Button ID="btnOrder3" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav3" runat="server" Text="Add Favourite" OnClick="btnFav3_Click" />
                    <td><asp:Button ID="btnOrder4" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav4" runat="server" Text="Add Favourite" OnClick="btnFav4_Click" /></td></td></td></td></tr>

         </table>
         </div>
          <div class="div5">
         <table>
             <tr><td><asp:Button ID="btnOrder5" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav5" runat="server" Text="Add Favourite" OnClick="btnFav5_Click" />
                    <td><asp:Button ID="btnOrder6" runat="server" Text="Order" />
                     <td> <asp:Button ID="btnFav6" runat="server" Text="Add Favourite" OnClick="btnFav6_Click" /></td></td></td></td></tr>

         </table>
         </div>

        <div class="div6">
         <table>
             <tr><td><asp:Button ID="btnOrder7" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav7" runat="server" Text="Add Favourite" OnClick="btnFav7_Click" />
                    <td><asp:Button ID="btnOrder8" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav8" runat="server" Text="Add Favourite" OnClick="btnFav8_Click" /></td></td></td></td></tr>

         </table>
         </div>

        <div class="div7">
         <table>
             <tr><td><asp:Button ID="btnOrder9" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav9" runat="server" Text="Add Favourite" OnClick="btnFav9_Click" />
                    <td><asp:Button ID="btnOrder10" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav10" runat="server" Text="Add Favourite" OnClick="btnFav10_Click" /></td></td></td></td></tr>

         </table>
         </div>

         <div class="div8">
         <table>
             <tr><td><asp:Button ID="btnOrder11" runat="server" Text="Order" />
                 <td> <asp:Button ID="btnFav11" runat="server" Text="Add Favourite" OnClick="btnFav11_Click" />
                    <td><asp:Button ID="btnOrder12" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav12" runat="server" Text="Add Favourite" OnClick="btnFav12_Click" /></td></td></td></td></tr>

         </table>
         </div>

         <div class="div9">
         <table>
             <tr><td><asp:Button ID="btnOrder13" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav13" runat="server" Text="Add Favourite" OnClick="btnFav13_Click" />
                    <td><asp:Button ID="btnOrder14" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav14" runat="server" Text="Add Favourite" OnClick="btnFav14_Click" /></td></td></td></td></tr>

         </table>
         </div>

         <div class="div10">
         <table>
             <tr><td><asp:Button ID="btnOrder15" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav15" runat="server" Text="Add Favourite" OnClick="btnFav15_Click" />
                    <td><asp:Button ID="btnOrder16" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav16" runat="server" Text="Add Favourite" OnClick="btnFav16_Click" /></td></td></td></td></tr>

         </table>
         </div>

          <div class="div11">
         <table>
             <tr><td><asp:Button ID="btnOrder17" runat="server" Text="Order" />
                 <td><asp:Button ID="btnFav17" runat="server" Text="Add Favourite" OnClick="btnFav17_Click" />
                    <td><asp:Button ID="btnOrder18" runat="server" Text="Order" />
                     <td><asp:Button ID="btnFav18" runat="server" Text="Add Favourite" OnClick="btnFav18_Click" /></td></td></td></td></tr>

         </table>
         </div>

</asp:Content>