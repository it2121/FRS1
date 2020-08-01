<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="foody.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        


    <script type="text/javascript">
        $(document).ready(function () {

            $(document).ready(function () {
                $('#Gridview1').DataTable();
            });

            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            $('.table1').DataTable();
        });
    </script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                        <asp:GridView class="table table-striped table-bordered" ID="GridView11" runat="server" ></asp:GridView>
         
</asp:Content>


