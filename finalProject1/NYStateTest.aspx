<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NYStateTest.aspx.cs" Inherits="finalProject1.NYStateTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #C0C0C0">
<head runat="server" style="background-color: #999999">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>First Name: <asp:TextBox ID="TextBox1" runat="server" Width="401px" TabIndex="1"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last Name: 
                <asp:TextBox ID="TextBox2" runat="server" Width="414px" TabIndex="2"></asp:TextBox>
            </h3>
        </div>
        <br />
       
        <h3>Your Address<asp:TextBox ID="TextBox3" runat="server" Width="1241px" TabIndex="3"></asp:TextBox>
        </h3>
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="#CC3300"></asp:Label>
        <br />
       <center> <div style="border-style: solid; border-width: 1px">
            <h3>1.<asp:TextBox ID="TextBox4" runat="server" Width="263px" TabIndex="4"></asp:TextBox>
&nbsp;&nbsp; 6.<asp:TextBox ID="TextBox9" runat="server" Width="263px" TabIndex="9"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 11.<asp:TextBox ID="TextBox14" runat="server" Width="263px" TabIndex="14"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 16.<asp:TextBox ID="TextBox19" runat="server" Width="263px" TabIndex="19"></asp:TextBox>
&nbsp;</h3>
            <h3>2.<asp:TextBox ID="TextBox5" runat="server" Width="263px" TabIndex="5"></asp:TextBox>
&nbsp;&nbsp; 7.<asp:TextBox ID="TextBox10" runat="server" Width="263px" TabIndex="10"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 12.<asp:TextBox ID="TextBox15" runat="server" Width="263px" TabIndex="15"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 17.<asp:TextBox ID="TextBox20" runat="server" Width="263px" TabIndex="20"></asp:TextBox>
&nbsp;</h3>
            <h3>3.<asp:TextBox ID="TextBox6" runat="server" Width="263px" TabIndex="6"></asp:TextBox>
&nbsp;&nbsp; 8.<asp:TextBox ID="TextBox11" runat="server" Width="263px" TabIndex="11"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 13.<asp:TextBox ID="TextBox16" runat="server" Width="263px" TabIndex="16"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 18.<asp:TextBox ID="TextBox21" runat="server" Width="263px" TabIndex="21"></asp:TextBox>
&nbsp;</h3>
            <h3>4.<asp:TextBox ID="TextBox7" runat="server" Width="263px" TabIndex="7"></asp:TextBox>
&nbsp;&nbsp; 9.<asp:TextBox ID="TextBox12" runat="server" Width="263px" TabIndex="12"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 14.<asp:TextBox ID="TextBox17" runat="server" Width="263px" TabIndex="17"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 19.<asp:TextBox ID="TextBox22" runat="server" Width="263px" TabIndex="22"></asp:TextBox>
&nbsp;</h3>
            <h3>5.<asp:TextBox ID="TextBox8" runat="server" Width="263px" TabIndex="8"></asp:TextBox>
&nbsp; 10.<asp:TextBox ID="TextBox13" runat="server" Width="263px" TabIndex="13"></asp:TextBox>
&nbsp;&nbsp; 15.<asp:TextBox ID="TextBox18" runat="server" Width="263px" TabIndex="18"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 20.<asp:TextBox ID="TextBox23" runat="server" Width="263px" TabIndex="23"></asp:TextBox>
&nbsp;</h3>
        </div>
           </center>
       
        <p>
            &nbsp;</p>
        <br />
        <h3>Correct answers: 
            <asp:Label ID="Label1" runat="server" ForeColor="#0066FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; You Pass or Fail:
            <asp:Label ID="Label2" runat="server" ForeColor="#0066FF"></asp:Label>
        </h3>
        <h3><asp:Label ID="Label3" runat="server" ForeColor="#CC3300"></asp:Label></h3>
        <br />
        <br />

       
        <div style="margin-left: 120px">
            <asp:Button ID="Button1" runat="server" Height="57px" OnClick="Button1_Click" Text="Exam Score " Width="201px" TabIndex="24" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="55px" OnClick="Button2_Click" style="margin-left: 15px" Text="Clear" Width="181px" TabIndex="25" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="53px" OnClick="Button3_Click" Text="Exit" Width="159px" TabIndex="26" />
            <br />
        </div>
        <br />
        <div>

            <asp:Calendar ID="Calendar1" runat="server" Height="321px" Width="507px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

        </div>
        <h3>Your Exam Date: <asp:Label ID="Label5" runat="server"></asp:Label>
        </h3>

       
    </form>
</body>
</html>
