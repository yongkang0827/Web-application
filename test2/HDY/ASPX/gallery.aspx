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
            left:500px;
            top:700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div4{
            left:500px;
            top:1200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div5{
            left:500px;
            top:1700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div6{
            left:500px;
            top:2200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
         .div7{
            left:500px;
            top:2700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div8{
            left:500px;
            top:3200px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div9{
            left:500px;
            top:3700px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div10{
            left:500px;
            top:4150px;
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
                 <td><asp:ImageButton ID="imgBtn1" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px"/>
                    <td><asp:Button ID="btnOrder2" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn2" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px"/></td></td></td></td></tr>

         </table>
         </div>
          <div class="div4">
         <table>
             <tr><td><asp:Button ID="btnOrder3" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgBtn3" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px"/>
                    <td><asp:Button ID="btnOrder4" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn4" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px"/></td></td></td></td></tr>

         </table>
         </div>
          <div class="div5">
         <table>
             <tr><td><asp:Button ID="btnOrder5" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgBtn5" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn5_Click1"/>
                    <td><asp:Button ID="btnOrder6" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn6" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn6_Click"/></td></td></td></td></tr>

         </table>
         </div>

        <div class="div6">
         <table>
             <tr><td><asp:Button ID="btnOrder7" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgBtn7" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn7_Click"/>
                    <td><asp:Button ID="btnOrder8" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn8" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn8_Click"/></td></td></td></td></tr>

         </table>
         </div>

        <div class="div7">
         <table>
             <tr><td><asp:Button ID="btnOrder9" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgBtn9" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn9_Click"/>
                    <td><asp:Button ID="btnOrder10" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn10" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn10_Click"/></td></td></td></td></tr>

         </table>
         </div>

         <div class="div8">
         <table>
             <tr><td><asp:Button ID="btnOrder11" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgbtn11" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgbtn11_Click"/>
                    <td><asp:Button ID="btnOrder12" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn12" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn12_Click"/></td></td></td></td></tr>

         </table>
         </div>

         <div class="div9">
         <table>
             <tr><td><asp:Button ID="btnOrder13" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgBtn13" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn13_Click"/>
                    <td><asp:Button ID="btnOrder14" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn14" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn14_Click"/></td></td></td></td></tr>

         </table>
         </div>

         <div class="div10">
         <table>
             <tr><td><asp:Button ID="btnOrder15" runat="server" Text="Order" />
                 <td><asp:ImageButton ID="imgBtn15" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn15_Click"/>
                    <td><asp:Button ID="btnOrder16" runat="server" Text="Order" />
                     <td><asp:ImageButton ID="imgBtn16" runat="server" ImageUrl="~/LMY/IMG/love.jpg" Height="65px" Width="78px" OnClick="imgBtn16_Click"/></td></td></td></td></tr>

         </table>
         </div>

</asp:Content>