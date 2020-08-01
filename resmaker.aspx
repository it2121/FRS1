<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="resmaker.aspx.cs" Inherits="foody.resmaker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




    <script type="text/javascript">
        $(document).ready(function () {

          

            $(".table1").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();

        });
     
    </script>
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Add a Reservation </h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                                     <img width="100px" src="imgs/tt.png" />

                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-12">
                        <label>Table ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-2" ID="TextBox1" runat="server" placeholder="ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                              
                           </div>
                        </div>
                     </div>
                     
                  
                      </div>
                          <div class="row" >
                     <div class="col-md-6"   >
                                      <label>Food</label>
                        <div class="form-group">
                           <asp:ListBox CssClass="form" ID="ListBox1" runat="server" SelectionMode="Multiple" Rows="5"  Font-Size="16" Width="100%" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"  >
                         
                           </asp:ListBox>
                                                        <asp:PlaceHolder  runat="server" ID="ph" />

                        </div>
                  </div> 

                                <div class="col-md-6">
                                      <label>Drinks</label>
                        <div class="form-group">
                           <asp:ListBox CssClass="form" ID="ListBox2" runat="server" SelectionMode="Multiple" Rows="5"  Font-Size="16"  Width="100%" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged">
                            
                           </asp:ListBox>
                                                                                    <asp:PlaceHolder runat="server" ID="ph2" />

                        </div>
                  </div> 


                          </div>

              
                  <div class="row">
                     <div class="col-md-4">
                        &nbsp;<div class="form-group">
                        </div>
                     </div>
                     <div class="col-md-4">
                        &nbsp;<div class="form-group">
                        </div>
                     </div>
                     <div class="col-md-4">
                        &nbsp;<div class="form-group">
                        </div>
                     </div>
                  </div>
                      <div class="row">
                     <div class="col">
                        <center>
                          <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server" Text="Set Order" OnClick="LinkButton1_Click" ></asp:LinkButton>
                           
                        
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-12">
                        <div class="form-group">
                      </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-8 mx-auto">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-outline-primary" runat="server" Text="Make a Reservation" OnClick="Button2_Click"   />
                     </div>
                  </div>
               </div>
            </div>
            
            <br>
         </div>
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>List</h4>
                        </center>
                     </div>
                  </div>
                

                     
                       
                  
                     
                <div class="row">
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered table1" ID="GridView1" runat="server" ></asp:GridView>
                     
                     
                     

                     
                     
                     
                     
                     </div>
                 
                   
               
                    
               </div>
            </div>


         </div>

      </div>
            <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">

      <div class="form-group">

                      <asp:GridView class="table table-striped table-bordered table-light" ID="GridView2" runat="server"  >
                          
                        </asp:GridView>
                        
                        </div>
                     </div>
           </div>
                                        </div>
  </div>

   </div>

</asp:Content>
