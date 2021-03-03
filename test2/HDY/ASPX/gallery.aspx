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
            left:580px;
            top:680px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div3a{
            left:900px;
            top:680px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div4{
            left:580px;
            top:1150px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div4a{
            left:900px;
            top:1150px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div5{
            left:580px;
            top:1620px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div5a{
            left:900px;
            top:1620px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div6{
            left:580px;
            top:2080px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
        .div6a{
            left:900px;
            top:2080px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
         .div7{
            left:580px;
            top:2540px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
         .div7a{
            left:900px;
            top:2540px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div8{
            left:580px;
            top:3050px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div8a{
            left:900px;
            top:3050px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div9{
            left:580px;
            top:3510px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
          .div9a{
            left:900px;
            top:3510px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div10{
            left:580px;
            top:3970px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div10a{
            left:900px;
            top:3970px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div11{
            left:580px;
            top:4430px;
            position:absolute;
            width: 239px;
            height: 35px;
        }
           .div11a{
            left:900px;
            top:4430px;
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
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
     <div class="div1">         
         <asp:DataList ID="DataList1" runat="server" HorizontalAlign="center" RepeatColumns="2" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34EBD2" OnItemCommand="Add_ItemCommand" AutoPostBack="False">
               <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                <table>
                    <tr><td>&nbsp;</td></tr>
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
                                            <asp:Button ID="Button1" runat="server" Text="Add Favourite" CommandArgument='<%# Eval("Title") %>' CommandName="Addfavourite" AutoPostBack="False"/>
                                            </td></tr>
                    <tr><td class="auto-style3">
                        <asp:Button ID="Button2" runat="server" Text="Details" CommandArgument='<%# Eval("Title") %>' CommandName="Details" AutoPostBack="False"/>
                        </td></tr>
               </table>
                            

            </ItemTemplate>
               <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Justify" />
            </asp:DataList>
           

         </div>
  
</asp:Content>