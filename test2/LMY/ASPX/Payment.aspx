<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="test2.LMY.ASPX.Payment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <style>
        /*.div1{
            top:1000px;
            left:3000px;
        }*/
        .image{
            height:200px;
            width:200px;
        }
        .pdbtn{
            height:50px;
            width:220px;
            color: white;
            background-color:darkblue;
            text-align: center;
            cursor: pointer;
            font-family:cursive;
            font-size:large;
       }
    </style>
        <div class="div1">
            <asp:GridView ID="gvImages" runat="server" AutoGenerateColumns="False" OnRowDataBound="OnRowDataBound" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnItemCommand="Delete_ItemCommand" AutoPostBack="False">
    <Columns>
        <asp:BoundField DataField="OrderId" HeaderText="Order Id" />
        <asp:BoundField DataField="ImageName" HeaderText="Image Name" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:TemplateField HeaderText="Image" ControlStyle-CssClass="image">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" />
            </ItemTemplate>

<ControlStyle CssClass="image"></ControlStyle>
        </asp:TemplateField>
        <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
        <asp:TemplateField HeaderText="Buy?">
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <%--<asp:TemplateField HeaderText="Delete">
            <ItemTemplate>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="DeleteOrder"/>
                        
            </ItemTemplate>
        </asp:TemplateField>--%>
    </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
</asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [OrderId], [ImageName], [Price] FROM [OrderList]"></asp:SqlDataSource>
            <br />
            <br />
             

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="1">Credit / Debit Card</asp:ListItem>
                <asp:ListItem Value="2">Online Banking</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Payment Method" ControlToValidate="RadioButtonList1">*</asp:RequiredFieldValidator>

            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="The following problems have been encountered: " ShowSummary="true" ShowMessageBox="true"  ForeColor="Red"/>
            <asp:Button ID="btnBuy" runat="server" Text="Buy" CssClass="pdbtn" OnClick="btnBuy_Click"/>
            <br />
            <br />
            <br />
        </div>
</asp:Content>
