﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiplication.aspx.cs" Inherits="FlashCards.Multiplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Math Flash Cards - Multiplication</title>
    <!-- Bootstrap -->
    <link href="content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" class="form-inline" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
              <h1>Multiplication Flash Cards</h1>
            </div>
        </div>      
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:Label ID="multiplicandLabel" class="control-label" runat="server" Text=""></asp:Label> &times; 
                            <asp:Label ID="multiplierLabel" class="control-label" runat="server" Text=""></asp:Label> = 
                            <asp:TextBox ID="answerTextBox" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                        </div>
                            <asp:Button ID="checkAnswerButton" runat="server" class="btn btn-primary" Text="Check Answer" OnClick="checkAnswerButton_Click" />
                    </div>
                </div>
            </div>
        </div>   
        <div class="row">
            <div class="col-md-12">
                <p>
                    <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
                </p>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-12">
                <p></p>
                <p>
                    <asp:Label ID="streakLabel" runat="server" Text="Streak: "></asp:Label>
                    <asp:Label ID="countLabel" runat="server" Text="0"></asp:Label>
                </p>
            </div>
        </div>
    </div>   
        
        
       
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
