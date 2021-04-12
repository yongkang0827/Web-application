<%@ Page Language="C#"  MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MakePayment.aspx.cs" Inherits="test2.LMY.ASPX.MakePayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <style>
        .imgSize2{
            width:180px;
          
        }

    </style>

        <div class="div1">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
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
            
            <br /><br />
            <table>
                  <tr><td>
                        <img src="../IMG/card.png" class="imgSize2"/></td></tr>
                <tr><td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Visa</asp:ListItem>
                        <asp:ListItem>Master</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Credit Card Type is required" ControlToValidate="RadioButtonList1">*</asp:RequiredFieldValidator>
                        
                    </td></tr>
                    <tr><td>
                        <asp:Label ID="lblCardNumber" runat="server" Text="Card Number"></asp:Label></td></tr>
                    <tr><td>
                        <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Card Number is required" ControlToValidate="txtCardNumber">*</asp:RequiredFieldValidator>
                   <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtCardNumber" OnServerValidate="CustomValidator1_ServerValidate" ErrorMessage="" ForeColor="Red" >*</asp:CustomValidator>
                       
                </td></tr>
                    <tr><td>
                        <asp:Label ID="lblCVV" runat="server" Text="Card Password" ></asp:Label></td></tr>
                    <tr><td>
                        <asp:TextBox ID="txtCVV" runat="server" TextMode="Password" class="pass"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ErrorMessage="Please enter card password" ControlToValidate="txtCVV">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter Password correctly" 
                            MinimumValue="100000" MaximumValue="999999" Type="Integer" ControlToValidate="txtCVV">*</asp:RangeValidator>

                </td></tr>
                    <tr><td>
                        <asp:Label ID="lblPin" runat="server" Text="Pin Number" ></asp:Label></td></tr>
                    <tr><td>
                        <asp:TextBox ID="txtPin" runat="server"></asp:TextBox>                        
                        </td>
                        <td class="auto-style1">
                            <asp:Button ID="btnPin" runat="server" Text="Pin Number" onClick="PinNumber"/>
                    </tr>
                <tr><td></td><td></td></tr>
                <tr><td></td><td></td></tr>
                <tr><td>
                    
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="The following problems have been encountered: " ShowSummary="true" ShowMessageBox="true" ForeColor="Red"/>
                    <br /><br />
                    <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" /></td><td class="auto-style1">
                    </td></tr>
               </table>

        </div>
</asp:Content>
