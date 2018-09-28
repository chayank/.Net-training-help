
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <script src="jquery.js"></script>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-primary">
	          <a class="navbar-brand">
	            <img src="Images/logo.png"  height="30" alt="">
	          </a>
	          <div class="collapse navbar-collapse" id="navbarNavDropdown">
	          
	          </div>
	</nav>

    	
		
		<div class="text-center text-primary"><h2>Add New Stock</h2></div>
		
		<div class="form-div">
            <form id="form1" runat="server">
        
			
                Stock Details:<br />
                <asp:TextBox ID="tbstk_name"  class="form-control border border-primary"  aria-describedby="StockName" style="width: 300px;"  placeholder="Stock Name" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="tbstk_price" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="tbstk_qty" runat="server"></asp:TextBox>
                <br />
                <br />
                Stock status:<br />
                <asp:DropDownList ID="ddlstk_status" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Selected="True">Active</asp:ListItem>
                    <asp:ListItem>InActive</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Stock" />
        
			
            </form>
            </div>
      

</body>
</html>
