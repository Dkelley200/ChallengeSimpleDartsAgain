<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDartsAgain.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            position: relative;
            top: 1px;
            left: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/dartboard.jpg" />
        </p>
        <p>
            <br />
            <asp:Button ID="okButton" runat="server" Text="OK" OnClick="okButton_Click" CssClass="newStyle1"  />
        </p>
        <div>
        </div>
        <blockquote>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </blockquote>
    </form>
</body>
</html>
