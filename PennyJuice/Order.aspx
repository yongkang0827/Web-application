<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="PennyJuice.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
    .div1{
        width:100%;
        text-align:center;
        font-size:x-large;
    }

    .Button1 {
        background-color:limegreen;
        border: none;
        color: white;
        padding: 15px 25px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        margin-top:30px;
        margin-left:80%;
        }
    .continue{   
       margin-left:850px;
       width : 180px;
       height : 90px;
    }
    .ChkBoxClass input {width:50px; height:50px;}
    .location{
        margin-top:100px;
    }
</style>
    <div class="location">
        <h1>Order List</h1>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server"  ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT [Image], [ProductName], [Price], [Quantity] FROM [Order]" 
            DeleteCommand="DELETE FROM [Order] WHERE [ProductName] = @ProductName" 
            InsertCommand="INSERT INTO [Order] ([Image], [ProductName], [Price], [Quantity]) VALUES (@Image, @ProductName, @Price, @Quantity)" 
            UpdateCommand="UPDATE [Order] SET [Image] = @Image, [Price] = @Price, [Quantity] = @Quantity WHERE [ProductName] = @ProductName" >
            <DeleteParameters>
                <asp:Parameter Name="ProductName" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Image" Type="String" />
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="Price" Type="String" />
                <asp:Parameter Name="Quantity" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Image" Type="String" />
                <asp:Parameter Name="Price" Type="String" />
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="Quantity" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:GridView ID="GridView1" runat="server" DataKeyNames="Image,ProductName,Price"  CssClass="div1" DataSourceID="SqlDataSource1"  CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  OnRowDeleting="GridView1_RowDeleting" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Order">
                    <ItemTemplate>
                        <asp:CheckBox ID="checkBox1" runat="server" CssClass="ChkBoxClass"></asp:CheckBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField  HeaderText="Product">
                    <ItemTemplate>
                        <asp:Image ID="Image1" Width="300px" Height="300px" runat="server" ImageUrl='<%# Eval("Image") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProductName" HeaderText="Name" ReadOnly="true">
                </asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="Unit Price(RM)"  ReadOnly="true">
                </asp:BoundField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity">
                </asp:BoundField>
                <asp:CommandField HeaderText="Update" ShowEditButton="True" ButtonType="Image" EditImageUrl="~/Img/edit.png" UpdateImageUrl="~/Img/confirm.png" CancelImageUrl="~/Img/no.png"/>
                <asp:CommandField HeaderText="Cancel" ShowDeleteButton="True" ButtonType="Image" DeleteImageUrl="~/Img/cancel.png"/>

            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" src="Img/next.png" OnClick="Button1_Click" CssClass="continue"/>
    </div>


   
</asp:Content>