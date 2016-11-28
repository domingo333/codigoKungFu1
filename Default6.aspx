<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article id="content">
				<div class="wrap">
					<div class="box">
						<div>
							<h2 class="letter_spacing">Contact <span>Form</span></h2>
							<form id="ContactForm">
								<div>
									<div class="wrapper">
										<span>Your Name:</span>
										<input type="text" class="input" >
									</div>
									<div class="wrapper">
										<span>Your E-mail:</span>
										<input type="text" class="input" >								
									</div>
									<div class="textarea_box">
										<span>Your Message:</span>
										<textarea name="textarea" cols="1" rows="1"></textarea>								
									</div>
									<a href="#" class="button1" onClick="document.getElementById('ContactForm').submit()">Send</a>
									<a href="#" class="button1" onClick="document.getElementById('ContactForm').reset()">Clear</a>
								</div>
							</form>
						</div>
					</div>
				</div>
			</article>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="body2">
	<div class="main">
		<article id="content2">
			<div class="wrapper">
				<section class="pad_left1">
					<div class="wrapper">
						<div class="cols">
							<h2>Our Contacts</h2>
						</div>
						<div class="col3 pad_left1">
							<h2>Miscellaneous Info</h2>
						</div>
					</div>
					<div class="line1">
						<div class="wrapper line2">
							<div class="cols">
								<div class="wrapper pad_bot1">
									<p>Sed ut perspiciatis unde omnis iunatus doloremque laudantium.</p>
									<p class="address">
										Marmora Road, Glasgow, D04 89GR.<br>
										<span>Freephone:</span>    +1 800 559 6580<br>
										<span>Telephone:</span>    +1 959 603 6035<br>
										<span>E-mail:</span>             <a href="mailto:">mail@demolink.org</a>
									</p>
								</div>
							</div>
							<div class="col3 pad_left1">
								<p>
									Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
								</p>
								Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Sed ut perspiciatis unde omnis iste natus error.
							</div>
						</div>
					</div>
				</section>
			</div>
		</article>
</asp:Content>

