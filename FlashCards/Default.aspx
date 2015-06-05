<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FlashCards.Default" %>

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Math Flash Cards</title>
    <!-- Bootstrap -->
    <link href="content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" class="form-inline" runat="server">  
    <div class="container">
        <div class="row">
            <div class="col-md-12">
              <h1>Math Flash Cards</h1>
            </div>
        </div>      
        <div class="row">
            <div class="col-md-6">
                <div class="panel panel-default">
                    <div class="panel-body">
                        Addition
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="panel panel-default">
                    <div class="panel-body">
                        Subtraction
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <asp:Button ID="MultiplicationButton" runat="server" Text="Multiplication" CssClass="btn btn-primary" OnClick="MultiplicationButton_Click" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="panel panel-default">
                    <div class="panel-body">
                        Division
                    </div>
                </div>
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
