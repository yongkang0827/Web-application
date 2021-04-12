<%@ Page Language="C#"  MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="OnlinePayment.aspx.cs" Inherits="test2.LMY.ASPX.OnlinePayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <style>
        .div1{
            margin-left:500px;
        }
    </style>
    <div class="div1">
    <table border="1">
                <tr>
                    <td>Image Name</td><td>Quantity</td><td>Price</td><td>Total Price</td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAllName" runat="server" Text=""></asp:Label></td><td>
                        <asp:Label ID="lblAllQuant" runat="server" Text=""></asp:Label></td><td>
                            <asp:Label ID="lblAllPrice" runat="server" Text=""></asp:Label></td><td>
                                <asp:Label ID="lblAllTotalPrice" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>&nbsp;</td><td></td><td></td><td></td>
                </tr>
                <tr>
                    <td></td><td></td><td>Total Prices</td><td>
                        <asp:Label ID="lblTotalPay" runat="server" Text="Label"></asp:Label></td>
                </tr>
            </table>

    <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
   
    <table>
        
        <tr>
            <td>Select Bank</td><td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Maybank</asp:ListItem>
                    <asp:ListItem>Public Bank</asp:ListItem>
                    <asp:ListItem>Hong Leong Bank</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Bank Type is required" ControlToValidate="DropDownList1">*</asp:RequiredFieldValidator>
                                </td>
        </tr>
        <tr>
            <td>Account Name</td><td>
                <asp:TextBox ID="txtAccName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Account Name" ControlToValidate="txtAccName">*</asp:RequiredFieldValidator>
                                 </td>
        </tr>
        <tr>
            <td>Account Number</td><td>
                <asp:TextBox ID="txtAccNum" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Account Number" ControlToValidate="txtAccNum">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Account Number must be 11 number"
                        ControlToValidate="txtAccNum" ValidationExpression="^[0-9]{11}"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Description</td><td>
                <asp:TextBox ID="txtDescrip" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter Description" ControlToValidate="txtDescrip">*</asp:RequiredFieldValidator>
                                </td>
        </tr>
        <tr>
            <td>Pin Number</td><td>
                <asp:TextBox ID="txtPin" runat="server"></asp:TextBox></td>
            <td>
                    </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnSearchPin" runat="server" Text="Pin Number" OnClick="btnSearchPin_Click" /></td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr><td>&nbsp;</td></tr>
      </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="The following problems have been encountered: " ShowSummary="true" ShowMessageBox="true" ForeColor="Red"/>
    <table>
        <tr>
            <td>

                <asp:Button ID="btnPay" runat="server" Text="Pay" OnClick="btnPay_Click" /></td><td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
        </div>
</asp:Content>
