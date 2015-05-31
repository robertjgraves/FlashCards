<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FlashCards.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Multiplication Flash Cards</h1>
        <p>
            <asp:Label ID="multiplicandLabel" runat="server" Text=""></asp:Label> &times; 
            <asp:Label ID="multiplierLabel" runat="server" Text=""></asp:Label> = 
            <asp:TextBox ID="answerTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
           <asp:Button ID="checkAnswerButton" runat="server" Text="Check Answer" OnClick="checkAnswerButton_Click" />
           <asp:Button ID="newCard" runat="server" Text="Get New Card" OnClick="newCard_Click" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="streakLabel" runat="server" Text="Streak: "></asp:Label>
            <asp:Label ID="countLabel" runat="server" Text="0"></asp:Label>
        </p>

    
    </div>
    </form>
</body>
</html>
