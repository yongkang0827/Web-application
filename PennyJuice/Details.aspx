<%@ Page Language="C#" MasterPageFile="~/Main.Master"AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="PennyJuice.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="style/detail.css" rel="stylesheet" />
    <div style="width:75%; margin: 0 auto;margin-top:80px;">
            <asp:DataList ID="DataList2" runat="server" DataKeyField="id" DataSourceID="SqlDataSource2" Width="80%" >
                <ItemTemplate>
                    <div class="artistTop">
                        <h4></h4>
                        <h1><asp:Label ID="lblJuiceName" runat="server" Text='<%# Eval("JuiceName") %>' /></h1>
                    </div>

                    <table class="artworkBox">
                        <tr>
                            <td class="artBox">
                                <img id="myImg" src='<%# Eval("Image") %>' alt='<%# Eval("JuiceName") %>' style="width:95%" />
                            </td>
                            <td class="detailBox">
                                <h1><asp:Label ID="ArtNameLabel" runat="server" Text='<%# Eval("JuiceName") %>' /></h1>
                                <asp:Label ID="ArtDescLabel" runat="server" Text='<%# Eval("Description") %>' />
                                <br /><br />
                                <div class="tooltip-ex"><strong><i onclick="pawWishList(this)" class="fa fa-paw black"></i></strong><br>
                                    <span class="tooltip-ex-text tooltip-ex-right">Wish List!</span>
                                </div>
                                <br /> <br />
                                <hr />
                                <br /><br /><br />
                                Price: RM 
                                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                                <br /><br />
                                <asp:Button ID="btnPurchase" class="btnstyle" runat="server" Text="Add To Cart" OnClick="BtnPurchase_Click"/>
                            </td>
                        </tr>
                    </table>

                    <!-- The Modal -->
                    <div id="myModal" class="modal">
                        <span class="close">&times;</span>
                        <img class="modal-content" id="img01">
                        <div id="caption"></div>
                    </div>
                    
                </ItemTemplate>
            </asp:DataList>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [JuiceName], [Description], [Price], [Image] FROM [Juice] WHERE (Id = @id)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>


        </div>
    <script>
        // Get the modal
        var modal = document.getElementById("myModal");

        // Get the image and insert it inside the modal - use its "alt" text as a caption
        var img = document.getElementById("myImg");
        var modalImg = document.getElementById("img01");
        var captionText = document.getElementById("caption");
        img.onclick = function () {
            modal.style.display = "block";
            modalImg.src = this.src;
            captionText.innerHTML = this.alt;
        }

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("close")[0];

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = "none";
        }

        function pawWishList(x) {
            if (x.classList.contains("red")) {
                x.classList.remove("red");
                x.classList.add("black");
            }
            else {
                x.classList.remove("black");
                x.classList.add("red");
            }
        }

    </script>

</asp:Content>