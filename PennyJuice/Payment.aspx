<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="PennyJuice.Payment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<style type="text/css">
    
    .auto-style2 {
        width: 147px;
        text-align: center;
    }
    .right{
        text-align: right;
    }
    .continue{      
       width : 120px;
       height : 50px;
    }
   table{
       border: 1px solid black;
        table-layout: fixed;
        width: 600px;
   }
   .ship{
       width: 147px;
        text-align: center;
        text-decoration: underline;
        font-weight: bold;
   }
    
    .auto-style3 {
        width: 149px;
        text-align: center;
    }
    .auto-style4 {
        width: 149px;
        text-indent: 40px;
    }
    .txtstyle {         
    border-top-left-radius: 5px;         
    border-top-right-radius: 5px;         
    border-bottom-left-radius: 5px;         
    border-bottom-right-radius: 5px;         
    background: #FFFFFF no-repeat 2px 2px;         
    padding:1px 1px 1px 5px;         
    border:2px solid #9900FF;         
  }         
  .txtstyle:focus {         
    width: 160px;         
    transition: all 0.30s ease-in-out;         
    border: 4px solid #9999FF;         
  }
  .total{
        font-weight: bold;
  }
    .mydropdownlist
    {
      color: #fff;
      padding: 5px 10px;
     border-radius: 5px;
        background-color: #cc2a41;
    }
     .location{
        margin-left:300px;
        margin-top:80px;
    }
</style>
    <div class="location">
    <table style="background-color: #ffffff; filter: alpha(opacity=40); opacity: 0.95;border:1px solid red">
        <tr>
            <td></td>
            <td></td>
            <td class="auto-style3"><img src="Img/secure_payment.png" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Order Information" class="ship"></asp:Label></td>
            <td></td>
            <td class="auto-style3">* Required Fields</td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td colspan="3">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ProductName], [Price], [Quantity] FROM [Payment]"></asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Width="594px" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                        <asp:BoundField DataField="Price" HeaderText="Price (RM)" SortExpression="Price" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center"/>
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td></td> 
            <td class="right">
                <asp:Label ID="Label3" runat="server" Text="Total :" class="total"></asp:Label> </td>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td></td>
            <td class="auto-style4"></td>
        </tr>
        
        <tr><td>------------------------------------</td><td>------------------------------------</td><td>------------------------</td></tr>
        <tr>
            <td class="ship">Shipping Information</td><td></td><td class="auto-style3"></td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td class="right">Name: </td>
            <td><asp:TextBox ID="Name" runat="server" class="txtstyle"></asp:TextBox></td>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your name" ControlToValidate="Name" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
         </tr>
         <tr>
            <td class="right">Address: </td>
            <td><asp:TextBox ID="Address" runat="server" class="txtstyle"></asp:TextBox></td>
             <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Account Number" ControlToValidate="Address">*</asp:RequiredFieldValidator>
             --%></tr>
         <tr>
            <td class="right">Zip/Postal Code: </td>
            <td><asp:TextBox ID="Postal" runat="server" class="txtstyle"></asp:TextBox></td>
             <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter postal code" ControlToValidate="Postal" ForeColor="Red">*</asp:RequiredFieldValidator>--%>
             <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="Postal" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>--%>
        </tr>
        <tr>
            <td class="right">Country: </td>
            <td><asp:DropDownList ID="DropDownList1" runat="server" CssClass="mydropdownlist">
                <asp:ListItem>Malaysia</asp:ListItem>
                <asp:ListItem>Thailand</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem>Singapore</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td class="right">Email: </td>
            <td><asp:TextBox ID="Email" runat="server" class="txtstyle"></asp:TextBox></td>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email is required" ControlToValidate="Email" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email must end in @gmail.com" ControlToValidate="Email" ValidationExpression="\w+([-+.']\w+)*@(?:gmail).com" ForeColor="Red">*</asp:RegularExpressionValidator>
       --%> </tr>
        <tr>
            <td></td><td></td><td class="auto-style3">
                <asp:ImageButton ID="ImageButton1" runat="server" src="Img/continue.png" OnClick="Pay_Click" CssClass="continue"/>
                </td>
        </tr>
    </table>
    <%--<asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="The following problems have been encountered: " ShowSummary="true" ShowMessageBox="true" ForeColor="Red"/>
    --%>
        </div>
</asp:Content>
