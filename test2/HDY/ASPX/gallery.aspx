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
            left:780px;
            top:700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div3a{
            left:1120px;
            top:700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div4{
            left:780px;
            top:1200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div4a{
            left:1120px;
            top:1200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div5{
            left:780px;
            top:1700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div5a{
            left:1120px;
            top:1700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div6{
            left:780px;
            top:2200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div6a{
            left:1120px;
            top:2200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
         .div7{
            left:780px;
            top:2700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
         .div7a{
            left:1120px;
            top:2700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div8{
            left:780px;
            top:3200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div8a{
            left:1120px;
            top:3200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div9{
            left:780px;
            top:3700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div9a{
            left:1120px;
            top:3700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div10{
            left:780px;
            top:4200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div10a{
            left:1120px;
            top:4200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div11{
            left:780px;
            top:4700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div11a{
            left:1120px;
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
         <asp:DataList ID="DataList1" runat="server" HorizontalAlign="center" RepeatColumns="2" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34EBD2">
               <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
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
    <div class="btnPosition">
          <div class="div3">
         <table>
             <tr><td><asp:Button ID="btnOrder1" runat="server" Text="Order" OnClick="btnOrder1_Click" />
                 <td><asp:Button ID="btnFav1" runat="server" Text="Add Favourite" OnClick="btnFav1_Click" />
                    </td></td></tr>

         </table>
         </div>
          <div class="div3a">
              <table>
                  <tr><td><asp:Button ID="btnOrder2" runat="server" Text="Order" OnClick="btnOrder2_Click" />
                     <td><asp:Button ID="btnFav2" runat="server" Text="Add Favourite" OnClick="btnFav2_Click" /></td></td></tr>
              </table>
          </div>
          <div class="div4">
         <table>
             <tr><td><asp:Button ID="btnOrder3" runat="server" Text="Order" OnClick="btnOrder3_Click" />
                 <td><asp:Button ID="btnFav3" runat="server" Text="Add Favourite" OnClick="btnFav3_Click" />
                    </td></td></tr>

         </table>
         </div>
          <div class="div4a">
              <table>
                  <tr>
                      <td><asp:Button ID="btnOrder4" runat="server" Text="Order" OnClick="btnOrder4_Click" />
                     <td><asp:Button ID="btnFav4" runat="server" Text="Add Favourite" OnClick="btnFav4_Click" /></td></td>
                  </tr>
              </table>
          </div>
          <div class="div5">
         <table>
             <tr><td><asp:Button ID="btnOrder5" runat="server" Text="Order" OnClick="btnOrder5_Click" />
                 <td><asp:Button ID="btnFav5" runat="server" Text="Add Favourite" OnClick="btnFav5_Click" />
                   </td></td></tr>

         </table>
         </div>

        <div class="div5a">
            <table>
                <tr>
                     <td><asp:Button ID="btnOrder6" runat="server" Text="Order" OnClick="btnOrder6_Click" />
                     <td> <asp:Button ID="btnFav6" runat="server" Text="Add Favourite" OnClick="btnFav6_Click" /></td></td>
                </tr>
            </table>
        </div>

        <div class="div6">
         <table>
             <tr><td><asp:Button ID="btnOrder7" runat="server" Text="Order" OnClick="btnOrder7_Click" />
                 <td><asp:Button ID="btnFav7" runat="server" Text="Add Favourite" OnClick="btnFav7_Click" />
                    </td></td></tr>

         </table>
         </div>
        
        <div class="div6a">
            <table>
                <tr>
                    <td><asp:Button ID="btnOrder8" runat="server" Text="Order" OnClick="btnOrder8_Click" />
                     <td><asp:Button ID="btnFav8" runat="server" Text="Add Favourite" OnClick="btnFav8_Click" /></td></td>
                </tr>
            </table>
        </div>

        <div class="div7">
         <table>
             <tr><td><asp:Button ID="btnOrder9" runat="server" Text="Order" OnClick="btnOrder9_Click" />
                 <td><asp:Button ID="btnFav9" runat="server" Text="Add Favourite" OnClick="btnFav9_Click" />
                    </td></td></tr>

         </table>
         </div>

         <div class="div7a">
             <table>
                 <tr>
                     <td><asp:Button ID="btnOrder10" runat="server" Text="Order" OnClick="btnOrder10_Click" />
                     <td><asp:Button ID="btnFav10" runat="server" Text="Add Favourite" OnClick="btnFav10_Click" /></td></td>
                 </tr>
             </table>
         </div>

         <div class="div8">
         <table>
             <tr><td><asp:Button ID="btnOrder11" runat="server" Text="Order" OnClick="btnOrder11_Click" />
                 <td> <asp:Button ID="btnFav11" runat="server" Text="Add Favourite" OnClick="btnFav11_Click" />
                    </td></td></tr>

         </table>
         </div>

         <div class="div8a">
             <table>
                 <tr>
                     <td><asp:Button ID="btnOrder12" runat="server" Text="Order" OnClick="btnOrder12_Click" />
                     <td><asp:Button ID="btnFav12" runat="server" Text="Add Favourite" OnClick="btnFav12_Click" /></td></td>
                 </tr>
             </table>
         </div>

         <div class="div9">
         <table>
             <tr><td><asp:Button ID="btnOrder13" runat="server" Text="Order" OnClick="btnOrder13_Click" />
                 <td><asp:Button ID="btnFav13" runat="server" Text="Add Favourite" OnClick="btnFav13_Click" />
                    </td></td></tr>

         </table>
         </div>

          <div class="div9a">
              <table>
                  <tr>
                      <td><asp:Button ID="btnOrder14" runat="server" Text="Order" OnClick="btnOrder14_Click" />
                     <td><asp:Button ID="btnFav14" runat="server" Text="Add Favourite" OnClick="btnFav14_Click" /></td></td>
                  </tr>
              </table>
          </div>

         <div class="div10">
         <table>
             <tr><td><asp:Button ID="btnOrder15" runat="server" Text="Order" OnClick="btnOrder15_Click" />
                 <td><asp:Button ID="btnFav15" runat="server" Text="Add Favourite" OnClick="btnFav15_Click" />
                   </td></td></tr>

         </table>
         </div>

        <div class="div10a">
            <table>
                <tr>
                     <td><asp:Button ID="btnOrder16" runat="server" Text="Order" OnClick="btnOrder16_Click" />
                     <td><asp:Button ID="btnFav16" runat="server" Text="Add Favourite" OnClick="btnFav16_Click" /></td></td>
                </tr>
            </table>
        </div>

          <div class="div11">
         <table>
             <tr><td><asp:Button ID="btnOrder17" runat="server" Text="Order" OnClick="btnOrder17_Click" />
                 <td><asp:Button ID="btnFav17" runat="server" Text="Add Favourite" OnClick="btnFav17_Click" />
                    </td></td></tr>

         </table>
         </div>

        <div class="div11a">
            <table>
                <tr>
                    <td><asp:Button ID="btnOrder18" runat="server" Text="Order" OnClick="btnOrder18_Click" />
                     <td><asp:Button ID="btnFav18" runat="server" Text="Add Favourite" OnClick="btnFav18_Click" /></td></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>