<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="foody.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
		<meta charset="utf-8">


		<link href="https://cdn.rawgit.com/michalsnik/aos/2.1.1/dist/aos.css" rel="stylesheet">

    	
    	<link rel="icon" href="images/logo.png">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

	
   <div id="Welcome">
	  		<!---Start navigation Bar -->
	  
			<!--- End Navigation Bar -->
			<!--- Start Carousel -->
			<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
				<ol class="carousel-indicators">
					<li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
				    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
				    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
				</ol>
				<div class="carousel-inner">
					<div class="carousel-item active">
				    	<img class="d-block w-100 img-fluid img-slider" src="images/slider1.jpg" alt="First slide">
				    	<div class="carousel-caption">
						    <h2>Welcome!</h2>
							<p>...</p>
						</div>
				    </div>
				    <div class="carousel-item">
				      	<img class="d-block w-100 img-fluid img-slider" src="images/slider2.jpg" alt="Second slide">
				      	<div class="carousel-caption">
						    <h2>Traditional Italian Cuisine</h2>
							<p>...</p>
						</div>
				    </div>
				    <div class="carousel-item">
				      	<img class="d-block w-100 img-fluid img-slider" src="images/slider3.jpg" alt="Third slide">
				      	<div class="carousel-caption">
						    <h2>Selected Products</h2>
							<p>...</p>
						</div>
				    </div>
				</div>
				<a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
					<span class="carousel-control-prev-icon" aria-hidden="true"></span>
				    <span class="sr-only">Previous</span>
				</a>
				<a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
					<span class="carousel-control-next-icon" aria-hidden="true"></span>
				    <span class="sr-only">Next</span>
				</a>
			</div>
		</div>
			<!--- End of Carousel -->
			<!--- Restaurant-->
		<div class="container">
		 	<div class="row" id="Restaurant">
	    		<div class="col navMenu">
	     		 	<h2 class="text-center" >~ Restaurant ~</h2>
	    		</div>
  			</div>
  			<div class="row bg-light" >
  				<div class="col-md-6">
  					<h3>Location</h3>
  					<p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
  					<h5>A Unique Experience</h5>
  					<p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
  				</div>
  				<div class="col-md-6" data-aos="fade-up">
  					<img class="img-fluid" src="images/location.jpg">
  				</div>
  			</div>
  			<div class="row bg-light"><br></div>
  			<div class="row bg-light">
  				<div class="col-md-6 order-md-1 order-2" data-aos="fade-up">
  					<img class="img-fluid " src="images/cuisine.jpg">
  				</div>
  				<div class="col-md-6 order-md-12 order-1">
  					<h3>Cuisine</h3>
  					<p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
  					<h5>A Unique Experience</h5>
  					<p>Thanks for stopping by. We are the last authentic Italian restaurant in Milan, serving delicious Italian cuisine cooked by the best chefs. It only takes a few minutes to browse through our website and check out our menu. We hope you'll soon join us for a superb Italian culinary experience.</p>
  				</div>
  			</div>
  			<!--- End of Restaurant -->
  			<!--- Start of Menu-->
			<div class="row" id="Menu">
				<div class="col navMenu">
	     		 	<h2 class="text-center" >~ Menu ~</h2>
				</div>
			</div>
			<div class="row bg-light">
				<div class="col-md-4" data-aos="slide-up">
					<div class="card view zoom">
  						<img class="card-img-top img-fluid " src="images/meat-menu.jpg">
					  	<div class="card-body">
					  		<h5 class="card-title">~ Meat Menu ~</h5>
					    	<ul class="list-group list-group-flush">
							    <li class="list-group-item">Bocconcini di carne in nido di sfoglia</li>
							    <li class="list-group-item">Bruschette con maiale al curry</li>
							 	<li class="list-group-item">Uova al prosciutto</li>
							 	<li class="list-group-item">Vitello tonnato</li>
							 	<li class="list-group-item">Fesa di tacchino marinata con olive</li>
							</ul>
					  	</div>
					</div>
				</div>
				<div class="col-md-4" data-aos="slide-up">
					<div class="card">
  						<img class="card-img-top img-fluid " src="images/fish-menu.jpg">
					  	<div class="card-body">
					  		<h5 class="card-title">~ Fish Menu ~</h5>
					    	<ul class="list-group list-group-flush">
							    <li class="list-group-item">Carpaccio di polpo</li>
							    <li class="list-group-item">Cozze al verde</li>
							 	<li class="list-group-item">Cocktail di gamberi</li>
							 	<li class="list-group-item">Risotto alla crema di scampi</li>
							 	<li class="list-group-item">Ravioli di pesce con crema di scampi</li>
							</ul>
					  	</div>
					</div>
				</div>
				<div class="col-md-4" data-aos="slide-up">
					<div class="card">
  						<img class="card-img-top img-fluid" src="images/menu-vegetarian.jpg">
					  	<div class="card-body">
					  		<h5 class="card-title">~ Vegetarian Menu ~</h5>
					    	<ul class="list-group list-group-flush">
							    <li class="list-group-item">Parmigiana di melanzane</li>
							    <li class="list-group-item">Strudel con ricotta e spinaci</li>
							 	<li class="list-group-item">Polpette di spinaci e ricotta</li>
							 	<li class="list-group-item">Frittata di patate al forno</li>
							 	<li class="list-group-item">Spaghetti con le polpettine vegetariane</li>
							</ul>
					  	</div>
					</div>
				</div>
			</div>
			<!--- End of Menu -->
			<!--- Start of Reservation-->
		
			<!--- End of Reserve -->
			<!--- Start of Our Location -->
	
			<!--- End of Our Location -->
		
		<script src="js/jquery-3.3.1.min.js"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
		<script defer src="https://use.fontawesome.com/releases/v5.0.6/js/all.js"></script>
		<script type="text/javascript" src="js/map.js"></script>
		<script type="text/javascript" src="js/smooth-scroll.js"></script>
		<script src="https://cdn.rawgit.com/michalsnik/aos/2.1.1/dist/aos.js"></script>
		<script type="text/javascript" src="js/image-effect.js"></script>
		<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDFZjOV0KA68G2YAh-rn7I3qKqCQEh_Ja0&callback=myMap">
	    </script>

 
</asp:Content>
