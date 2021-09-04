<%@ Page Language="C#" UnobtrusiveValidationMode="None" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PayMoney.aspx.cs" Inherits="PennyJuice.PayMoney" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style type="text/css">
    
    .right{
        width: 200px;
        text-decoration: underline;
        font-weight: bold;
        font-size: 20px;
        text-align: center;
    }
    .txtstyle {         
    border-top-left-radius: 5px;         
    border-top-right-radius: 5px;         
    border-bottom-left-radius: 5px;         
    border-bottom-right-radius: 5px;         
    background: #FFFFFF no-repeat 2px 2px;         
    padding:1px 1px 1px 5px;         
    border:2px solid #2461BF;         
  }         
  .txtstyle:focus {         
    width: 160px;         
    transition: all 0.30s ease-in-out;         
    border: 4px solid #9999FF;         
  }
    .continue{      
       width : 140px;
       height : 50px;
    }
    .normaltxt{
        text-align: right;
    }
    .Button1 {
        background-color: cornflowerblue; 
        border: none;
        color: white;
        padding: 5px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
        border-radius: 12px;
        }
    .location{
        margin-left:350px;
        margin-top:80px;
    }
</style>
    <div class="location">
    <table style="background-color: #ffffff; filter: alpha(opacity=40); opacity: 0.95;border:1px solid black">
        <tr>
            <td class="right">Payment Information</td>
            <td></td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td></td><td><img src="Img/visa.png" /></td><td></td>
        </tr>
        <tr>
            <td class="normaltxt">Card Number: </td>
            <td>
                <asp:TextBox ID="Card" runat="server" class="txtstyle"></asp:TextBox ></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Card Name" ControlToValidate="Card" ForeColor="Red">*</asp:RequiredFieldValidator>
           </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr>
            <td class="normaltxt">Pin Number: </td>
            <td>
                <asp:TextBox ID="Pin" runat="server" class="txtstyle"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Pin Number" ControlToValidate="Pin" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr><td>&nbsp;</td></tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="ReqPin" runat="server" Text="Request Pin" OnClick="ReqPin_Click" cssClass="Button1"/>
                </td>
            <td></td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <tr><td>&nbsp;</td></tr>
        <tr>

            <td style="text-align: center;" colspan="3">
                <asp:ImageButton ID="ImageButton1" runat="server" src="Img/pay.png" OnClick="Pay_Click" CssClass="continue"/>
            </td>

        </tr>
    </table>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="The following problems have been encountered: " ShowSummary="true" ShowMessageBox="true" ForeColor="Red"/>
    </div>
</asp:Content>
