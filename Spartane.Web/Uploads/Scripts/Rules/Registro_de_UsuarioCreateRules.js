var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
$("#Registro_de_UsuarioGuardar").addClass("hidden");
$("#Registro_de_UsuarioGuardarYNuevo").addClass("hidden");
$("#Registro_de_UsuarioGuardarYCopia").addClass("hidden");
$("#ConfigureSave").addClass("hidden");
$("#Registro_de_UsuarioCancelar").addClass("hidden");
$("#Registro_de_UsuarioAnterior").addClass("hidden");
$("#Registro_de_UsuarioReenviar").addClass("hidden");
$("#side-menu").addClass("hidden");
$("#logoutForm").addClass("hidden");
//Registro_de_UsuarioSiguiente

//VALIDAR CORREO ELECTRÓNICO
$('#Correo').change(function(){ 
	let email = $('#Correo').val(); 
	let exp = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/); 
	if (exp.test(email) == false){ 
			$('#Correo').attr("placeholder", "Correo electrónico no válido.").val("").focus().blur(); 
	} 
});

//COD-MAN INI Funcionalidad Registro
function enviarSMS(telefono, numeroaleatorio) {
    var url = "https://apisms.c3ntro.com:8282/?username=vcontreras&password=oes8ke&number=+52" + telefono + "&message=Bienvenido a Portal Ciudadano, su clave para verificar celular es " + numeroaleatorio;
    $.get(url, function (data, status) {
      console.log("Data: " + data + "\nStatus: " + status);
    });
}

function enviarCorreo(correo,numeroaleatorio){
	if(correo.length>4){
		SendEmail(correo, "Activa tú cuenta de Portal Ciudadano.", "<!doctype html>"   +
"		<html>"  +
"	<head>"  +
"		<meta charset='utf-8'>"  +
"		<!-- utf-8 works for most cases -->"   +
"		<meta name='viewport' content='width=device-width, initial-scale=1.0'>"   +
"		<!-- Forcing initial-scale shouldn't be necessary -->"   +
 "		<meta http-equiv='X-UA-Compatible' content='IE=edge'>"+
 "		<!-- Use the latest (edge) version of IE rendering engine -->"+
 "		<title>EmailTemplate-Fluid</title>"+
 "		<style type='text/css'>"+
 "		/* What it does: Remove spaces around the email design added by some email clients. */"+
 "			  /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */"+
 "		html, body {"+
	 "			margin: 0 !important;"+
	 "		padding: 0 !important;"+
	 "		height: 100% !important;"+
	 "		width: 100% !important;"+
	 "	}"+
	 "	/* What it does: Stops email clients resizing small text. */"+
	 "	* {"+
		 "		-ms-text-size-adjust: 100%;"+
		 "	-webkit-text-size-adjust: 100%;"+
		 "}"+
		 "/* What it does: Forces Outlook.com to display emails full width. */"+
		 ".ExternalClass {"+
			 "	width: 100%;"+
			 "}"+
			 "/* What is does: Centers email on Android 4.4 */"+
			 "	div[style*='margin: 16px 0'] {"+
				 "			margin: 0 !important;"+
				 "}"+
				 "/* What it does: Stops Outlook from adding extra spacing to tables. */"+
				 "table, td {"+
					 "mso-table-lspace: 0pt !important;"+
					 "	mso-table-rspace: 0pt !important;"+
					 "}"+
					 "/* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */"+
					 "table {"+
						 "border-spacing: 0 !important;"+
						 "border-collapse: collapse !important;"+
						 "table-layout: fixed !important;"+
						 "margin: 0 auto !important;"+
						 "}"+
						 "table table table {"+
							 "table-layout: auto;"+
							 "}"+
							 "/* What it does: Uses a better rendering method when resizing images in IE. */"+
							 "img {"+
								 "-ms-interpolation-mode: bicubic;"+
								 "}"+
								 "/* What it does: Overrides styles added when Yahoo's auto-senses a link. */"+
								 ".yshortcuts a {"+
									 "border-bottom: none !important;" +
									 "}" +
									 "/* What it does: Another work-around for iOS meddling in triggered links. */"+
									 "a[x-apple-data-detectors] {"+
										 "color: inherit !important;"+
										 "}"+
										 "</style>"+
		 "<!-- Progressive Enhancements -->"+
		 "<style type='text/css'>"+
		 "/* What it does: Hover styles for buttons */"+
		 ".button-td, .button-a {"+
			 "	transition: all 100ms ease-in;"+
			 "}"+
			 ".button-td:hover, .button-a:hover {"+
				 "	color: #000;"+
				 "}"+
				 "</style>"+
				 "</head>"+
				 "<body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'>"+
				 "<table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'>"+
				 " <tr>"+
				 "	<td><center style='width: 100%;'>"+
				 "		"+
				 "		<!-- Visually Hidden Preheader Text : BEGIN -->"+
				 "		<div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div>"+
				 "		<!-- Visually Hidden Preheader Text : END -->"+
				 "	"+
				 "	<div style='max-width: 600px;'> "+
				 "	  <!--[if (gte mso 9)|(IE)]>"+
				   "		<table cellspacing='0' cellpadding='0' border='0'  align='center'>"+
				   "		<tr>"+
			 "		<td>"+
			 "		<![endif]--> "+
					 "	  "+
					 "	  <!-- Email Header : BEGIN -->"+
					 "		  <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'>"+
					 "		<tr>"+
			 "		  <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td>"+
			 "		</tr>"+
			 "	  </table>"+
				   "	  <!-- Email Header : END --> "+
				   "	  "+
				   "	  <!-- Email Body : BEGIN -->"+
				   "	  <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'>"+
				   "		"+
				   "		<!-- Hero Image, Flush : BEGIN -->"+
				   "	<tr>"+
				 "	</tr>"+
				 "	<!-- Hero Image, Flush : END --> "+
				 "	"+
				 "	<!-- 1 Column Text : BEGIN -->"+
				 "	<tr>"+
				 "	  <td><table cellspacing='0' cellpadding='0' border='0' width='100%'>"+
				 "		  <tr>"+
				 "			<td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'>"+
				 "			  "+
				 "			  <p style='font-size:16px; font-weight: bold; text-align:center'>"+
				 "				Su código es: " + numeroaleatorio +
				 "			  </p>"+
		 "			  <p>"+
							   "				Para verificar que esta dirección de correo electrónico es tuya, introduce "+
							   "					el siguiente código en la página de verificación del correo electrónico. "+
							   "			  </p>"+
							   "						"+
							   "	"+
							   "		</td>"+
							 "	  </tr>"+
							 "	</table></td>"+
							 "</tr>"+
							 "<!-- 1 Column Text : BEGIN --> "+
		 " </table>"+
		 "		  <!-- Email Body : END --> "+
		 "		  "+
		 "		  <!-- Email Footer : BEGIN -->"+
		 "		  <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'>"+
		 "			<tr>"+
		 "		  <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion>"+
		 "			<br>"+
		 "				<br>"+
		 "			<b>Portal Ciudadano</b> <br>"+
			 "			Fiscalía General del Estado de Sinaloa<br>"+
			 "			<span class='mobile-link--footer'>"+
			 "			  http://www.fiscaliasinaloa.mx/"+
						   "			</span> <br> "+
						   "			<!-- "+
						   "			<br>"+
						   "			<unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> -->"+
						   "			</td>"+
						 "		</tr>"+
						 "  </table>"+
						 "  <!-- Email Footer : END --> "+
				   "<!--[if (gte mso 9)|(IE)]>"+
				   "	</td>"+
					 "	</tr>"+
					 "			</table>"+
					 "			<![endif]--> "+
					 "	</div>"+
					 "		  </center></td>"+
					 "	  </tr>"+
		   "	</table>"+
		   "	</body>"+
		   "	</html>");
		$("#divCodigo_Verificacion_Correo").removeClass("hidden");
	}else{		
		$("#divCodigo_Verificacion_Correo").addClass("hidden");
	}		
}


//ENVIA CORREO REGISTRO
function enviarCorreoRegistro(correo,username2){
		SendEmail(correo, "Registro en Portal Ciudadano.", "<!doctype html>"
		+" <html>"
		+" <head>"
		+" <meta charset='utf-8'>"
		+" <meta name='viewport' content='width=device-width, initial-scale=1.0'>"
		+" <meta http-equiv='X-UA-Compatible' content='IE=edge'>"
		+" <title>EmailTemplate-Fluid</title>"
		+" ​"
		+" "
		+" <style type='text/css'>"
		+" /* What it does: Remove spaces around the email design added by some email clients. */"
		+"       /* Beware: It can remove the padding / margin and add a background color to the compose a reply window. */"
		+" html, body {"
		+" 	margin: 0 !important;"
		+" 	padding: 0 !important;"
		+" 	height: 100% !important;"
		+" 	width: 100% !important;"
		+" }"
		+" /* What it does: Stops email clients resizing small text. */"
		+" * {"
		+" 	-ms-text-size-adjust: 100%;"
		+" 	-webkit-text-size-adjust: 100%;"
		+" }"
		+" /* What it does: Forces Outlook.com to display emails full width. */"
		+" .ExternalClass {"
		+" 	width: 100%;"
		+" }"
		+" /* What is does: Centers email on Android 4.4 */"
		+" div[style*='margin: 16px 0'] {"
		+" 	margin: 0 !important;"
		+" }"
		+" /* What it does: Stops Outlook from adding extra spacing to tables. */"
		+" table, td {"
		+" 	mso-table-lspace: 0pt !important;"
		+" 	mso-table-rspace: 0pt !important;"
		+" }"
		+" /* What it does: Fixes webkit padding issue. Fix for Yahoo mail table alignment bug. Applies table-layout to the first 2 tables then removes for anything nested deeper. */"
		+" table {"
		+" 	border-spacing: 0 !important;"
		+" 	border-collapse: collapse !important;"
		+" 	table-layout: fixed !important;"
		+" 	margin: 0 auto !important;"
		+" }"
		+" table table table {"
		+" 	table-layout: auto;"
		+" }"
		+" /* What it does: Uses a better rendering method when resizing images in IE. */"
		+" img {"
		+" 	-ms-interpolation-mode: bicubic;"
		+" }"
		+" /* What it does: Overrides styles added when Yahoo's auto-senses a link. */"
		+" .yshortcuts a {"
		+" 	border-bottom: none !important;"
		+" }"
		+" /* What it does: Another work-around for iOS meddling in triggered links. */"
		+" a[x-apple-data-detectors] {"
		+" 	color: inherit !important;"
		+" }"
		+" </style>"
		+" ​"
		+" <style type='text/css'>"
		+" /* What it does: Hover styles for buttons */"
		+" .button-td, .button-a {"
		+" 	transition: all 100ms ease-in;"
		+" }"
		+" .button-td:hover, .button-a:hover {"
		+" 	color: #000;"
		+" }"
		+" </style>"
		+" </head>"
		+" <body width='100%' height='100%' bgcolor='#e0e0e0' style='margin: 0;' yahoo='yahoo'>"
		+" <table cellpadding='0' cellspacing='0' border='0' height='100%' width='100%' bgcolor='#e0e0e0' style='border-collapse:collapse;'>"
		+"   <tr>"
		+"     <td><center style='width: 100%;'>"
		+"         "
		+" "
		+"         <div style='display:none;font-size:1px;line-height:1px;max-height:0px;max-width:0px;opacity:0;overflow:hidden;mso-hide:all;font-family: sans-serif;'> (Optional) This text will appear in the inbox preview, but not the email body. </div>"
		+" "
		+"         "
		+"         <div style='max-width: 600px;'> "
		+" "
		+"             <table cellspacing='0' cellpadding='0' border='0'  align='center'>"
		+"             <tr>"
		+"             <td>"
		+"      "
		+"           "
		+"    "
		+"           <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 600px;'>"
		+"             <tr>"
		+"               <td style='padding: 20px 0; text-align: center'><img src='http://192.168.1.101/MVCfiscaliasinaloa/Images/logo-fiscalia-sinaloa.png' width='108' height='126' alt='alt_text' border='0'></td>"
		+"             </tr>"
		+"           </table>"
		+"       "
		+"           "
		+"         "
		+"           <table cellspacing='0' cellpadding='0' border='0' align='center' bgcolor='#ffffff' width='100%' style='max-width: 600px;'>"
		+"             "
		+"           "
		+"             <tr>"
		+"             </tr>"
		+"            "
		+"             "
		+"             <tr>"
		+"               <td><table cellspacing='0' cellpadding='0' border='0' width='100%'>"
		+"                   <tr>"
		+"                     <td style='padding: 40px; font-family: sans-serif; font-size: 15px; mso-height-rule: exactly; line-height: 20px; color: #555555;'>"
		+"                       "
		+" ​"
		+"                       <p>"
		+"                         Usted se ha registrado en el <b>Portal Ciudadano</b>. "
		+"                         <br><br>"
		+"                         "
		+"                         Tu usuario: <br>" + username2
		+"                         "
		+"                         Puedes iniciar sesión dando clic aquí. "
		+"                         "
		+"                         <br><br>"
		+" ​"
		+"                        "
		+"                         "
		+"                       </p>"
		+"                       <table cellspacing='0' cellpadding='0' border='0' align='center' style='margin: auto;'>"
		+"                         <tr>"
		+"                           <td style='text-align: center;' class='button-td'><a href='http://192.168.1.101/MVCfiscaliasinaloa/Account/Login' style='color: #F64200; font-family: sans-serif; font-size: 22px; line-height: 1.1; text-align: center; text-decoration: underline; display: block; font-weight: bold;' class='button-a'> "
		+"                             <!--[if mso]>&nbsp;&nbsp;&nbsp;&nbsp;<![endif]-->Iniciar sesión<!--[if mso]>&nbsp;&nbsp;&nbsp;&nbsp;<![endif]--> "
		+"                             </a></td>"
		+"                         </tr>"
		+"                       </table>"
		+"                       "
		+"                       <br>"
		+" ​"
		+"                       <p>A través de este Correo estaremos en contacto en caso de que olvides tu contraseña.</p>                  "
		+"                     "
		+"                     </td>"
		+"                   </tr>"
		+"                 </table></td>"
		+"             </tr>"
		+" ​"
		+"             "
		+"           </table>"
		+"           "
		+"           <table cellspacing='0' cellpadding='0' border='0' align='center' width='100%' style='max-width: 680px;'>"
		+"             <tr>"
		+"               <td style='padding: 40px 10px;width: 100%;font-size: 12px; font-family: sans-serif; mso-height-rule: exactly; line-height:18px; text-align: center; color: #888888;'><webversion style='color:#aaa; text-decoration:underline; font-weight: bold;'></webversion>"
		+"                 <br>"
		+"                 <br>"
		+"                 <b>Portal Ciudadano</b> <br>"
		+"                 Fiscalía General del Estado de Sinaloa<br>"
		+" 				"
		+"                 <span class='mobile-link--footer'>"
		+"                   http://www.fiscaliasinaloa.mx/"
		+"                 </span> <br> "
		+"                  "
		+"                 <br>"
		+"                 <unsubscribe style='color:#888888; text-decoration:underline;'>unsubscribe</unsubscribe> -->"
		+" 				</td>"
		+"             </tr>"
		+"           </table>"
		+"         "
		+"           "
		+"           "
		+"             </td>"
		+"             </tr>"
		+"             </table>"
		+"             <![endif]--> "
		+"         </div>"
		+"       </center></td>"
		+"   </tr>"
		+" </table>"
		+" </body>"
		+" </html>");
}
var telefono = "";
var correo1 = ""; 
var username2 = "";
$("#Registro_de_UsuarioReenviar").on("click", function() {  

});

$("#idReenviarCodigoCorreo").on("click", function() {  
	alertas("Se realizo el reenvío del código al correo correctamente.");
	var numeroaleatorio2 = GenereNumero8();
	GuardaNuevoCodigo(numeroaleatorio2,"2");
	enviarCorreo(correo1,numeroaleatorio2);
	
});

$("#idReenviarCodigoCelular").on("click", function() {  
	alertas("Se realizo el reenvío del código al celular correctamente.");
	var numeroaleatorio2 = GenereNumero8();
	GuardaNuevoCodigo(numeroaleatorio2,"1");
	enviarSMS(telefono,numeroaleatorio2);
});



var seEnvioCelular=false;
var seEnvioCorreo=false;
$("#Registro_de_UsuarioSiguiente").on("click", function() {  
	var destino=0;
	var guardar=false;
	var fase = $('.tabs-container').find('.active').data('fase');
	if(fase == 0){
		$("#Registro_de_UsuarioAnterior").removeClass("hidden");
		$("#Registro_de_UsuarioSiguiente").val("Siguiente");			
	}
	if(fase == 1){
		$("#Registro_de_UsuarioSiguiente").val("Guardar");		
	}
	if (fase == 2){
		guardar=true;
		$("#Registro_de_UsuarioAnterior").addClass("hidden");	
		$("#Registro_de_UsuarioSiguiente").val("Verificar");			
	}else
		$("#Registro_de_UsuarioReenviar").addClass("hidden");
	destino= 1 + fase;
	if(guardar){
		seEnvioCelular=false;
		seEnvioCorreo=false;
		debugger;
		if(!checkPassword($("#Contrasena").val())){
			
			alertas("Es necesario introducir una contraseña segura, mínimo con una letra minúscula, una letra mayúscula, un número y un carácter especial.");
			$("#Registro_de_UsuarioAnterior").removeClass("hidden");	
			$("#Registro_de_UsuarioSiguiente").val("Guardar");
			$("#Contrasena").val("");
			$("#Confirmar_Contrasena").val("");			
			return;			
		}
		
		if(!($("#idterminos").prop("checked"))){
			alertas("Es necesario indicar estar de acuerdo con los términos y condiciones.");
			$("#Registro_de_UsuarioAnterior").removeClass("hidden");	
			$("#Registro_de_UsuarioSiguiente").val("Guardar");
			return;
		}			
		debugger;
		if($("#Celular").val().length < 9 && $("#Correo").val().length < 6){
			alertas("Es necesario que para efectos de auteticación proporciones tu correo electrónico o tu teléfono celular, o ambos.");
			$("#Registro_de_UsuarioAnterior").removeClass("hidden");	
			$("#Registro_de_UsuarioSiguiente").val("Guardar");
			return;
		}
		if($("#Celular").val().length > 9){ seEnvioCelular = true; 
			if(!($("#idusopersonal").prop("checked"))){
				alertas("Es necesario indicar la confirmación del uso del teléfono.");
				$("#Registro_de_UsuarioAnterior").removeClass("hidden");	
				$("#Registro_de_UsuarioSiguiente").val("Guardar");
				return;				
			}		
		}
		if($("#Correo").val().length > 5){ seEnvioCorreo = true; }
		SetNotRequiredToControl( $('#Codigo_Verificacion_Correo'));
		SetNotRequiredToControl( $('#Codigo_Verificacion_Celular'));
		SetNotRequiredToControl( $('#Codigo_Reestablecer_Contrasena'));	
		SetNotRequiredToControl( $('#Celular'));		
		var valform = checkClientValidate('Registro_de_UsuarioCreateForm');
		if(!valform){
			ActivaTabCorrespondiente(fase,0);
			$("#Registro_de_UsuarioAnterior").removeClass("hidden");
			$("#Registro_de_UsuarioSiguiente").val("Siguiente");	
			return;			
		}else{			 		
			debugger;
			if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				telefono = $("#Celular").val();
				correo1 = $('#Correo').val(); 
				username2 = $('#Usuario').val(); 
				var numeroaleatorio1 = GenereNumero8();
				var numeroaleatorio2 = GenereNumero8();
				if (!SendRegistro_de_UsuarioData(function () {
					EjecutarValidacionesDespuesDeGuardar();	
					if(seEnvioCelular){
						GuardaNuevoCodigo(numeroaleatorio1,"1");					
						enviarSMS(telefono,numeroaleatorio1);
						$("#divCodigo_Verificacion_Celular").removeClass("hidden");						
					}else
						$("#divCodigo_Verificacion_Celular").addClass("hidden");
					if(seEnvioCorreo){
						GuardaNuevoCodigo(numeroaleatorio2,"2");
						enviarCorreo(correo1,numeroaleatorio2);		
						$("#divCodigo_Verificacion_Correo").removeClass("hidden");						
					}else
						$("#divCodigo_Verificacion_Correo").addClass("hidden");
				})) {
					
				}
			}			
			console.log("aqui guarda");				
		}
	}
	if(fase == 3){
		console.log("aqui valida");	
		var res = ValidaCodigoUser();
		if(res == 1){
			alertas("¡Bienvenido, su cuenta ha sido correctamente verificada!");
			if(seEnvioCorreo){
				enviarCorreoRegistro(correo1,username2);
			}
			window.location="../../Account/Login?returnUrl='LoginPC'";
		}
		else{
			alertas("¡Código incorrecto!");
		}
		return;
	}


	 var tabs = $(".tabs-container li").each(function(i) {		 
        if(i == fase) {
			$(this).removeClass("active");
		}
		if(i == destino) {
			$(this).addClass("active");
		}
    });			
	$("#tabDatos_Generales").removeClass("active");
	$("#tabDatos_para_Iniciar_Sesion").removeClass("active");
	$("#tabDatos_para_validar_tu_cuenta").removeClass("active");
	$("#tabValidacion").removeClass("active");
	
	switch(destino){
		case 0:
			$("#tabDatos_Generales").addClass("active");
			break;
		case 1:
			$("#tabDatos_para_Iniciar_Sesion").addClass("active");
			break;
		case 2:
			$("#tabDatos_para_validar_tu_cuenta").addClass("active");
			break;
		case 3:
			$("#tabValidacion").addClass("active");
			break;			
	}	
});

function alertas(textomostrar){
	$("#modalauxtxt").html(textomostrar);
	$("#divmodalaux").removeClass('hidden');	
}

$("#saveaux").on("click", function() {  
	debugger;
	$("#divmodalaux").addClass('hidden');	
});

function checkPassword(str)
{
       var re = /^(?=.*\d)(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
       return re.test(str);
}

function ActivaTabCorrespondiente(fase,destino){
	 var tabs = $(".tabs-container li").each(function(i) {		 
        if(i == fase) {
			$(this).removeClass("active");
		}
		if(i == destino) {
			$(this).addClass("active");
		}
    });			
	$("#tabDatos_Generales").removeClass("active");
	$("#tabDatos_para_Iniciar_Sesion").removeClass("active");
	$("#tabDatos_para_validar_tu_cuenta").removeClass("active");
	$("#tabValidacion").removeClass("active");
	
	switch(destino){
		case 0:
			$("#tabDatos_Generales").addClass("active");
			break;
		case 1:
			$("#tabDatos_para_Iniciar_Sesion").addClass("active");
			break;
		case 2:
			$("#tabDatos_para_validar_tu_cuenta").addClass("active");
			break;
		case 3:
			$("#tabValidacion").addClass("active");
			break;			
	}		
}

$("#Registro_de_UsuarioAnterior").on("click", function() {	
	var destino=0;
	var fase = $('.tabs-container').find('.active').data('fase');
	if(fase == 1){
		$("#Registro_de_UsuarioAnterior").addClass("hidden");	
		$("#Registro_de_UsuarioSiguiente").removeClass("hidden");		
	}
	
	if (fase == 2){	
		$("#Registro_de_UsuarioSiguiente").val("Siguiente");			
	}
	
	if (fase == 3){	
		$("#Registro_de_UsuarioSiguiente").val("Guardar");			
	}	
	destino=  fase - 1;

	 var tabs = $(".tabs-container li").each(function(i) {		 
        if(i == fase) {
			$(this).removeClass("active");
		}
		if(i == destino) {
			$(this).addClass("active");
		}
    });	
	
	debugger;	
	$("#tabDatos_Generales").removeClass("active");
	$("#tabDatos_para_Iniciar_Sesion").removeClass("active");
	$("#tabDatos_para_validar_tu_cuenta").removeClass("active");
	$("#tabValidacion").removeClass("active");
	
	switch(destino){
		case 0:
			$("#tabDatos_Generales").addClass("active");
			break;
		case 1:
			$("#tabDatos_para_Iniciar_Sesion").addClass("active");
			break;
		case 2:
			$("#tabDatos_para_validar_tu_cuenta").addClass("active");
			break;
		case 3:
			$("#tabValidacion").addClass("active");
			break;			
	}	
});

function GuardaNuevoCodigo(numeroaleatorio, tipo){
	debugger;
	console.log(NuevoIDV);
	var query="EXEC spu_InsertaCodigoValidacion " + NuevoIDV + "," + numeroaleatorio + "," + tipo;
	EvaluaQuery55(query);	
}

function ValidaCodigoUser(){
	debugger;
	var result = "0";
	if(seEnvioCelular){
		var numeroaleatoriov = $("#Codigo_Verificacion_Celular").val();
		if(numeroaleatoriov.length==0)
			return "0";
		
		var query="EXEC spu_ValidaCodigoValidacion " + NuevoIDV + "," + numeroaleatoriov  + "," + "1";
		result = EvaluaQuery55(query);	
		if(result != 1){
			$("#Codigo_Verificacion_Celular").val("");	
			return result;		
		}
	}
			
	if(seEnvioCorreo){
		var numeroaleatoriov2 = $("#Codigo_Verificacion_Correo").val();
		if(numeroaleatoriov2.length==0)
			return "0";
		query="EXEC spu_ValidaCodigoValidacion " + NuevoIDV + "," + numeroaleatoriov2  + "," + "2";
		result = EvaluaQuery55(query);	
		if(result != 1){
			$("#Codigo_Verificacion_Correo").val("");	
			return result;		
		}		
	}	
	return result;
}

function GenereNumero8(){
	var numaleatorio="";
	for(var ni=0;ni<9;ni++){
		numaleatorio += aleatorio(0,9);
	}
	return numaleatorio;
}

function aleatorio(minimo,maximo){
  return Math.floor(Math.random() * ((maximo+1)-minimo)+minimo);
}

function EvaluaQuery55(query) {
    var res = '';
    var data = {
        query: query
    }
    $.ajax({
        url: url_content + "Frontal/General/ExecuteQuery",
        type: 'POST',
        cache: false,
        dataType: "json",
        async: false,
        data: data,
        success: function (result) {
            res = result;
        },
        error: function (result) {
            showNotification("Error ejecutando query", "error");
        }
    });
    //return res;
    return TryParseInt(res, res);
}



//COD-MAN END Funcionalidad Registro
//LIMITAR LONGITUD
$("form#CreateRegistro_de_Usuario").on('keyup', '#Usuario', function () {
	if ($(this).val().length > 10) {
		$(this).val($(this).val().substr(0, 10));
	}
});
//LIMITAR LONGITUD
$("form#CreateRegistro_de_Usuario").on('keyup', '#Contrasena', function () {
	if ($(this).val().length > 10) {
		$(this).val($(this).val().substr(0, 10));
	}
});
//LIMITAR LONGITUD
$("form#CreateRegistro_de_Usuario").on('keyup', '#Confirmar_Contrasena', function () {
	if ($(this).val().length > 10) {
		$(this).val($(this).val().substr(0, 10));
	}
});

//COD-MANI INI OCULTAR CONTRASEÑA
//$("#Contrasena").attr("type","password");
//$("#Confirmar_Contrasena").attr("type","password");
//COD-MANI END OCULTAR CONTRASEÑA

//BusinessRuleId:3058, Attribute:269002, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Nombres', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:3058, Attribute:269002, Operation:Field, Event:None

//BusinessRuleId:3059, Attribute:269003, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Apellido_Paterno', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:3059, Attribute:269003, Operation:Field, Event:None

//BusinessRuleId:3060, Attribute:269004, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Apellido_Materno', function () {
	nameOfTable='';
	rowIndex='';
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));
});


//BusinessRuleId:3060, Attribute:269004, Operation:Field, Event:None



//BusinessRuleId:3199, Attribute:269006, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").change(function() {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT COUNT(ID_USER) FROM SPARTAN_USER WHERE USERNAME = 'FLD[Usuario]'",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { 
	$('#Usuario').attr("placeholder", "El usuario ingresado ya está registrado. Favor de intentar con otro.").val("").focus().blur(); } else {}
});


//BusinessRuleId:3199, Attribute:269006, Operation:Field, Event:None

//BusinessRuleId:3200, Attribute:269010, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Celular', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT COUNT(CLAVE) FROM REGISTRO_DE_USUARIO WHERE CELULAR = 'FLD[Celular]'",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { 
	$('#Celular').attr("placeholder", "El celular ingresado ya está registrado, favor de revisar.").val("").focus().blur();} else {}
});


//BusinessRuleId:3200, Attribute:269010, Operation:Field, Event:None



//BusinessRuleId:3201, Attribute:269009, Operation:Field, Event:None
$("form#CreateRegistro_de_Usuario").on('keyup', '#Correo', function () {
	nameOfTable='';
	rowIndex='';
if( EvaluaQuery("SELECT COUNT(ID_USER) FROM SPARTAN_USER WHERE Email = 'FLD[Correo]'",rowIndex, nameOfTable)>TryParseInt('0', '0') ) { 
	$('#Correo').attr("placeholder", "El correo ingresado ya está registrado, favor de revisar.").val("").focus().blur();} else {}
});


//BusinessRuleId:3201, Attribute:269009, Operation:Field, Event:None





//BusinessRuleId:3202, Attribute:269008, Operation:Field, Event:None
$('#Confirmar_Contrasena').change(function(){
if( EvaluaQuery("SELECT FLD[Contrasena]",rowIndex, nameOfTable)!=EvaluaQuery("SELECT FLD[Confirmar_Contrasena]",rowIndex, nameOfTable) ) { 
	$('#Confirmar_Contrasena').attr("placeholder", "Las contraseñas no coinciden, favor de revisar.").val("").focus().blur();} else {}
});


//BusinessRuleId:3202, Attribute:269008, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {












//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo' + rowIndex));


}
//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo' + rowIndex));


}
//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divNombre_Completo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_Completo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Correo' + rowIndex));


}
//BusinessRuleId:3062, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3223, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divCodigo_Reestablecer_Contrasena').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Reestablecer_Contrasena' + rowIndex));


}
//BusinessRuleId:3223, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3223, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divCodigo_Reestablecer_Contrasena').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Reestablecer_Contrasena' + rowIndex));


}
//BusinessRuleId:3223, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3223, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divCodigo_Reestablecer_Contrasena').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Codigo_Reestablecer_Contrasena' + rowIndex));


}
//BusinessRuleId:3223, Attribute:0, Operation:Object, Event:SCREENOPENING





//BusinessRuleId:3272, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));


}
//BusinessRuleId:3272, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3272, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));


}
//BusinessRuleId:3272, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3273, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));


}
//BusinessRuleId:3273, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3273, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));


}
//BusinessRuleId:3273, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:3273, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Celular' + rowIndex));


}
//BusinessRuleId:3273, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;












//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
 AsignarValor($('#' + nameOfTable + 'Nombre_Completo' + rowIndex),EvaluaQuery(" SELECT 'FLD[Nombres]' + ' ' + 'FLD[Apellido_Paterno]' + ' ' + 'FLD[Apellido_Materno]'", rowIndex, nameOfTable));


}
//BusinessRuleId:3061, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3063, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery("EXEC InsertSpartanRegistroUsuarios GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);


}
//BusinessRuleId:3063, Attribute:2, Operation:Object, Event:AFTERSAVING















//BusinessRuleId:3208, Attribute:2, Operation:Object, Event:AFTERSAVING

//BusinessRuleId:3208, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


