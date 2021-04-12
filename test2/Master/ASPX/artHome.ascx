<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="artHome.ascx.cs" Inherits="test2.Master.ASPX.artHome" %>
 <style>
    .slideshow{
        text-align: center;
        padding-bottom:50px;
        }
   .container1{
       text-align:center;
       margin-left:10%;
       font-family:cursive;
      
   }
   .content{
       padding-left:7%;
       padding-right:7%;
       padding-bottom:100px;
       font-family:cursive;
   }
    .content1{
       padding-left:7%;
       padding-right:7%;
       padding-bottom:30px;
       font-family:cursive;
   }
   .imgBet{
       padding-left:50px;
   }
   .describeRight{
       padding-left:50px;
   }
   .describeLeft{
       padding-right:50px;
   }
    </style>

        <div class="content1">
        <asp:Label ID="lblName1" runat="server"> </asp:Label>
        <asp:Label ID="lblLoginTime1" runat="server" Text=""></asp:Label>
        </div>
    <div class="slideshow">
        
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000" > </asp:Timer>
            <asp:Image ID="Image1" runat="server" Width="700" Height="500" />
        </ContentTemplate>
    </asp:UpdatePanel>
  </div>

    <div class="content">
      
    <table>
        <tr><td><h1>Welcome to Become Our Team !</h1></td></tr>
       
        <tr><td><h2>Improves Productivity</h2>
            <br />
            <p>Teams that work together are more productive and motivated toward company goals.</p>
            </td>
            <td><asp:Image ID="IMG2" runat="server" ImageUrl="~/Master/IMG/arthome2.jpg" /> </td>
           
           </tr>
        <tr>
            <td><asp:Image ID="IMG3" runat="server" ImageUrl="~/Master/IMG/arthome3.jpg" /> </td>
            <td><h2> A Synergy of Ideas</h2>
                <br />
                <p>Working as a team therefore not only resolves obstacles but also improves workflow speed.</p>
            </td>
        </tr>
        <tr>
            <td><h2>A Fulfilling Meaningful Experience</h2>
                <br />
                <p>Teamwork is a panacea-like so many other variables where successful companies operate on a day-to-day basis. And that’s why it is dubbed a “fulfilling meaningful experience.”</p></td>
            <td><asp:Image ID="IMG4" runat="server" ImageUrl="~/Master/IMG/arthome4.png" Height="404px" Width="712px" /></td>
        </tr>
         <tr>
            <td colspan="2">
                <asp:Image ID="IMG1" runat="server" ImageUrl="~/Master/IMG/arthome1.jpg" Width="1513px" />
            </td>
        </tr>
    </table>


</div>
    <table class="container1">
        <h3>Gallery Artwork</h3>
        <tr><td class="imgBet">
           
            <asp:ImageButton ID="ImageButton3" runat="server" Height="200px" Width="200px" ImageUrl="~/LMY/IMG/Death Masks.jpg" PostBackUrl="~/HDY/ASPX/gallery.aspx" /></td><td class="imgBet">
                <asp:ImageButton ID="ImageButton4" runat="server" Height="200px" Width="200px" ImageUrl="~/HDY/IMG/Machines for Suffering.jpeg" PostBackUrl="~/HDY/ASPX/gallery.aspx" /></td><td class="imgBet">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="200px" Width="200px" ImageUrl="~/LMY/IMG/Prodromes.jpg" PostBackUrl="~/HDY/ASPX/gallery.aspx" /></td><td class="imgBet">
                        <asp:ImageButton ID="ImageButton6" runat="server" Height="200px" Width="200px" ImageUrl="~/LMY/IMG/Torso of a Woman.jpg" PostBackUrl="~/HDY/ASPX/gallery.aspx" /></td></tr>
        <tr><td >
            <asp:Label ID="lblDeathmask" runat="server" Text="Death Masks"></asp:Label></td><td>
                <asp:Label ID="lblMachine" runat="server" Text="Machines for Suffering"></asp:Label></td><td>
                    <asp:Label ID="lblProdromes" runat="server" Text="Prodromes"></asp:Label></td><td>
                        <asp:Label ID="lblTorso" runat="server" Text="Torso of Woman"></asp:Label></td></tr>
    </table>