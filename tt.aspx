<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tt.aspx.cs" Inherits="foody.tt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <meta charset="utf-8">

    <script src="bootstrap/js/jquery-3.3.1.slim.min.js"></script>


    <script src="datatables/js/jquery.dataTables.min.js"></script>


        <link href="datatables/css/jquery.dataTables.min.css" rel="stylesheet" />


		<link rel="stylesheet" href="css/style.css">

    <script type="text/javascript">
     
        $(document).ready(function () {



            $('#GridView1').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();


        });
      
    </script>
</head>
<body>
    <form id="form1" runat="server">
  

                  <div id="content" class="p-4 p-md-5 pt-5">
                                                     <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" ></asp:GridView>

           
		</div>

        </div>
    </form>
</body>
</html>
