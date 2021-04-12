<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="editCustProfile.aspx.cs" Inherits="test2.LHY.ASPX.editCustProfile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .buttonUpdate {
        background-color: blue;
        border: none;
        color: white;
        padding: 5px 30px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        }
        .buttonUpdate:hover {
                opacity:0.5;
                 color: white;
            }
        table.form{
            
            table-layout: auto;
            font-size: 20px;
            margin-left:auto;
            margin-right:45%;

        }
    </style>
    <table class="form">
            <tr><td colspan="2">
                <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label></td></tr>
            <tr><td colspan="2">
                <asp:TextBox ID="txtUsername" runat="server" class="textfield" placeholder="Username"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfUsername" runat="server" ErrorMessage="Username is required" ControlToValidate="txtUsername" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td></tr>
            <tr><td colspan="2">
                <asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label></td></tr>
            <tr><td colspan="2">
                <asp:TextBox ID="txtPhone" runat="server" class="textfield" placeholder="01xxxxxxxxx"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfPhone" runat="server" ErrorMessage="Phone number is required" ControlToValidate="txtPhone" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validPhone" runat="server" ErrorMessage="Phone should be only number" ControlToValidate="txtPhone" ValidationExpression="^\d+$" ForeColor="Red">*</asp:RegularExpressionValidator>
                </td></tr>

             <tr><td colspan="2">
                <asp:Label ID="lblNewPassw" runat="server" Text="New Password" ></asp:Label></td></tr>
            <tr><td colspan="2">
                <asp:TextBox ID="txtPassw" runat="server" TextMode="Password" class="pass"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfPassw" runat="server" ErrorMessage="Password is required" ControlToValidate="txtPassw" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="validPassw" runat="server" ErrorMessage="Password must be 6 characters" ControlToValidate="txtPassw" ValidationExpression="\w{6}" ForeColor="Red">*</asp:RegularExpressionValidator>
                </td></tr>
            <tr><td colspan="2">
                <asp:Label ID="lblComfirmPassw" runat="server" Text=" Comfirm Password" ></asp:Label></td></tr>
            <tr><td colspan="2">
                <asp:TextBox ID="txtComfirmPassw" runat="server" TextMode="Password" class="pass"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfConfirmPassw" runat="server" ErrorMessage="Comfirm password is required" ControlToValidate="txtComfirmPassw" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td></tr>
            <tr><td colspan="2" >
                &nbsp;<tr><td colspan="2">
                <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" Width="167px" OnClick="BtnUpdate_Click" class="buttonUpdate"/>
                </td></tr>
        </table>

    <asp:ValidationSummary ID="vsCreateUser" runat="server" showMessageBox="true" ShowSummary="false"/>

</asp:Content>

