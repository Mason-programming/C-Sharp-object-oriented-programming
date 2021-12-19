<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kirby.aspx.cs" Inherits="finalProject1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #C0C0C0">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <div>
            <center><h1>Object oriented Programming Final Project</h1></center>
        </div>
        <br />
        <br />
        <div>
           <center><h2>Your Name: 
               
               <asp:TextBox ID="TextBox1" runat="server" Width="442px"></asp:TextBox>
               
               </h2> </center> 
        </div>
        <center><asp:Label ID="Label1" runat="server" ForeColor="#CC3300"></asp:Label></center>
        <br />
        <div>
            <center><h2>Web Project: NY State Drivers Licence Exam</h2></center>
            <br />
            <center>
                
                <asp:ImageButton ID="ImageButton1" runat="server" Height="332px" ImageUrl="~/AA18_Regera_2000x900_f0a8e249-da2d-4bd6-9b08-e07a488b87fb_2048x.jpg" OnClick="ImageButton1_Click" Width="658px" />
                
            </center>
        </div>
        <br />
        <div>
            <center><h2>Click the image above to take the test</h2></center>
        </div>
    </form>
</body>
</html>
