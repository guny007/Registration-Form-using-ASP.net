<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration_Form.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
            height: 184px;
            margin-top: 43px;
        }
        .auto-style2 {
            width: 92px;
        }
        .auto-style3 {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Study Hub"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="Small" ForeColor="#FF9966" Text="Registration Form"></asp:Label>
        <table class="auto-style1" style="background-color: #FF9900">
            <tr>
                <td class="auto-style2">Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="124px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="132px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Contact</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="124px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">E-Mail</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="124px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" Height="26px" Width="124px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" style="background-color: #FF9900">
                    <br />
                    <asp:Button ID="Button1" runat="server" BackColor="#66FF33" ForeColor="Black" OnClick="Button1_Click" Text="Register" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="#FF0066"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
