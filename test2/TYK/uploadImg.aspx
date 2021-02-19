<%@ Page Language="C#" MasterPageFile="~/Artist.Master" AutoEventWireup="true" CodeBehind="uploadImg.aspx.cs" Inherits="test2.TYK.uploadImg" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<style type="text/css">
    .upload{
        margin-left:200px;
        padding-top:100px;
        padding-bottom:100px;
    }
    .btnLayout{
        padding-top:50px;
    }

</style>

        <div class="upload">

            <table>
                <tr>
                    <td class="auto-style1">Image Id :</td>
                    <td>
                        <asp:Label ID="lblID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">Please upload your image here:&nbsp; </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Title :</td>
                    <td>
                        <asp:TextBox ID="txtTitle" runat="server" MaxLength="25"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Description :</td>
                    <td>
                        <asp:TextBox ID="txtDescribe" runat="server" MaxLength="99" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Number of stocks for sale :</td>
                    <td>
                        <asp:TextBox ID="txtStock" runat="server" TextMode="Number" min="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Selling Price :</td>
                    <td>

                        RM
                        <asp:TextBox ID="txtPrice" runat="server" TextMode="Number" step="0.01" min="0"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Date Upload :</td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Artist :</td>
                    <td>
                        <asp:TextBox ID="txtArtist" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="btnLayout">
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" Width="130px" /> &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                    </td>
                    <td class="btnLayout">
                        <asp:Button ID="BtnCancel" runat="server" PostBackUrl="~/TYK/Gallery.aspx" Text="Cancel" />
                    </td>
                </tr>


            </table>
        </div>
</asp:Content>
