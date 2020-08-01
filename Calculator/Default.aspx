<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Calculator</h1>
        <p class="lead">We encourage you to do it mentally but always have your back!</p>
        <p><a href="https://www.youtube.com/channel/UCosJ16GN2g2tGsVQnGK9pvA" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" Width="150px" />
            </h2>
            </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" Width="150px" />
            </h2>
            
        </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" Width="150px" />
            </h2>
           
        </div>
        
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="+" Width="150px" />
            </h2>
           
        </div>

        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="Delete" Width="150px" />
            </h2>
           
        </div>
    </div>

    <div class="row">
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="4" Width="150px" />
            </h2>
         </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="5" Width="150px" />
            </h2>
            
        </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="6" Width="150px" />
            </h2>
           
        </div>
        
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="-" Width="150px" />
            </h2>
            </div>
         <div class="col-md-2">
            <h2>
                <asp:Button ID="Button18" runat="server" OnClick="Button18_Click" Text="C" Width="150px" />
            </h2>
           
        </div>
    </div>

    <div class="row">
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="7" Width="150px" />
            </h2>
            
                    </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="8" Width="150px" />
            </h2>
            
        </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="9" Width="150px" />
            </h2>
           
        </div>
        
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="x" Width="150px" />
            </h2>
           
        </div>
         <div class="col-md-2">
            <h2>
                <asp:Button ID="Button19" runat="server" OnClick="Button19_Click" Text="!" Width="150px" />
            </h2>
           
        </div>
    </div>

    <div class="row">
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button13" runat="server" Text="." Width="150px" OnClick="Button13_Click" />
            </h2>
            
                    </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="0" Width="150px" />
            </h2>
            
        </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button15" runat="server" Text="=" Width="150px" OnClick="Button15_Click" />
            </h2>
           
        </div>
        
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button16" runat="server" OnClick="Button16_Click" Text="/" Width="150px" />
            </h2>
           
        </div>
        <div class="col-md-2">
            <h2>
                <asp:Button ID="Button20" runat="server" OnClick="Button16_Click" Text="Sqrt" Width="150px" />
            </h2>
           
        </div>
    </div>

    <div class="row">
        <div class="col-md-12"
            <p class="lead"><asp:Label ID="Label1" runat="server" Text=".." BorderStyle="Double" Width="100px" BackColor="#CCCCFF" Font-Bold="True" Font-Size="20pt" Height="40px"></asp:Label>
                RESULT = 
            <asp:Label ID="Label2" runat="server" Text=".." BorderStyle="Double" Width="100px" BackColor="#CCCCFF" BorderColor="Black" Font-Bold="True" Font-Size="20pt" Height="40px"></asp:Label>
                </p>
            </div>

    </div>
</asp:Content>
