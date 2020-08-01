<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="foodanddrinks.aspx.cs" Inherits="foody.foodanddrinks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <script type="text/javascript">

        $(document).ready(function () {



            $('#GridView1').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();


        });

       </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" ></asp:GridView>

</asp:Content>
