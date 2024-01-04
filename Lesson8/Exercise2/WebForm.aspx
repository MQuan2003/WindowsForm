<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Exercise2.WebForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>

</head>
    <body>
        <form id="form1" runat="server">
            <div>                
                <asp:Label ID="Label1" runat="server" Text="a" ></asp:Label>
                <asp:TextBox ID="Textbox1" runat="server" ></asp:TextBox><br /><br />
                <asp:Label ID="Label2" runat="server" Text="b" ></asp:Label>
                <asp:TextBox ID="Textbox2" runat="server"></asp:TextBox><br /><br />
                
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Add_Click" style="height: 26px" />
                <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Subtract_Click" style="height: 26px" />
                <asp:Button ID="Button3" runat="server" Text="Multiply" OnClick="Multiply_Click" style="height: 26px" />
                <asp:Button ID="Button4" runat="server" Text="Divide" OnClick="Divide_Click" style="height: 26px" />
                <br />
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </div>
        </form>
    </body>
</html>

