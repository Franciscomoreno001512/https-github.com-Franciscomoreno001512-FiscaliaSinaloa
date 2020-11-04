



$(function () {

});

var AutoCompleteUsuario_que_RegistraData = [];
function GetAutoCompleteOrientador_Usuario_que_Registra_Spartan_UserData(data) {
	AutoCompleteUsuario_que_RegistraData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteUsuario_que_RegistraData.push({
            id: data[i].Id_User,
            text: data[i].Name
        });
    }
    return AutoCompleteUsuario_que_RegistraData;
}
var AutoCompleteColoniaData = [];
function GetAutoCompleteOrientador_Colonia_ColoniaData(data) {
	AutoCompleteColoniaData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaData;
}
var AutoCompleteMunicipioData = [];
function GetAutoCompleteOrientador_Municipio_MunicipioData(data) {
	AutoCompleteMunicipioData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioData;
}
var AutoCompleteEstadoData = [];
function GetAutoCompleteOrientador_Estado_EstadoData(data) {
	AutoCompleteEstadoData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoData;
}
var AutoCompleteColonia2Data = [];
function GetAutoCompleteOrientador_Colonia2_ColoniaData(data) {
	AutoCompleteColonia2Data = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia2Data.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia2Data;
}
var AutoCompleteMunicipio2Data = [];
function GetAutoCompleteOrientador_Municipio2_MunicipioData(data) {
	AutoCompleteMunicipio2Data = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio2Data.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio2Data;
}
var AutoCompleteEstado2Data = [];
function GetAutoCompleteOrientador_Estado2_EstadoData(data) {
	AutoCompleteEstado2Data = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado2Data.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado2Data;
}
var AutoCompleteEstado_PlacasData = [];
function GetAutoCompleteOrientador_Estado_Placas_EstadoData(data) {
	AutoCompleteEstado_PlacasData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado_PlacasData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado_PlacasData;
}
var AutoCompleteColonia3Data = [];
function GetAutoCompleteOrientador_Colonia3_ColoniaData(data) {
	AutoCompleteColonia3Data = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColonia3Data.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColonia3Data;
}
var AutoCompleteMunicipio3Data = [];
function GetAutoCompleteOrientador_Municipio3_MunicipioData(data) {
	AutoCompleteMunicipio3Data = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipio3Data.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipio3Data;
}
var AutoCompleteEstado3Data = [];
function GetAutoCompleteOrientador_Estado3_EstadoData(data) {
	AutoCompleteEstado3Data = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstado3Data.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstado3Data;
}
var AutoCompleteColoniaCData = [];
function GetAutoCompleteOrientador_ColoniaC_ColoniaData(data) {
	AutoCompleteColoniaCData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteColoniaCData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteColoniaCData;
}
var AutoCompleteMunicipioCData = [];
function GetAutoCompleteOrientador_MunicipioC_MunicipioData(data) {
	AutoCompleteMunicipioCData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteMunicipioCData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteMunicipioCData;
}
var AutoCompleteEstadoCData = [];
function GetAutoCompleteOrientador_EstadoC_EstadoData(data) {
	AutoCompleteEstadoCData = [];
    for (var i = 0; i < data.length; i++) {
        AutoCompleteEstadoCData.push({
            id: data[i].Clave,
            text: data[i].Nombre
        });
    }
    return AutoCompleteEstadoCData;
}


function getDropdown(elementKey) {
    var labelSelect = $("#Orientador_cmbLabelSelect").val();
    var dropDown = '<select id="' + elementKey + '" class="form-control"><option value="">' + labelSelect + '</option></select>';
    return dropDown;
}

function GetGridDatePicker() {
    return "<input type='text' class='fullWidth gridDatePicker xyz form-control' >";
}
function GetGridTimePicker() {
    return "<input type='text' class='fullWidth gridTimePicker form-control'  data-autoclose='true'>";
}
function GetGridTextArea() {
    return "<textarea rows='2'></textarea>";
}
function GetGridCheckBox() {
    return " <input type='checkbox' class='fullWidth'> ";
}
function GetFileUploader() {
    return "<input type='file' class='fullWidth'>";
}

function GetGridAutoComplete(data,field, id) {
    
    var dataMain = data == null ? "Select" : data;
    id ==  (id==null   || id==undefined)? "":id;
    
     return "<select class='AutoComplete fullWidth select2-dropDown " + field + " form-control' data-val='true'  ><option value='" + id +"'>" + dataMain + "</option></select>";
}

function ClearControls() {
    $("#ReferenceClave").val("0");
    $('#CreateOrientador')[0].reset();
    ClearFormControls();
    $("#ClaveId").val("0");
    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Colonia2').empty();
    $("#Colonia2").append('<option value=""></option>');
    $('#Colonia2').val('0').trigger('change');
    $('#Municipio2').empty();
    $("#Municipio2").append('<option value=""></option>');
    $('#Municipio2').val('0').trigger('change');
    $('#Estado2').empty();
    $("#Estado2").append('<option value=""></option>');
    $('#Estado2').val('0').trigger('change');
    $('#Estado_Placas').empty();
    $("#Estado_Placas").append('<option value=""></option>');
    $('#Estado_Placas').val('0').trigger('change');
    $('#Colonia3').empty();
    $("#Colonia3").append('<option value=""></option>');
    $('#Colonia3').val('0').trigger('change');
    $('#Municipio3').empty();
    $("#Municipio3").append('<option value=""></option>');
    $('#Municipio3').val('0').trigger('change');
    $('#Estado3').empty();
    $("#Estado3").append('<option value=""></option>');
    $('#Estado3').val('0').trigger('change');
    $('#ColoniaC').empty();
    $("#ColoniaC").append('<option value=""></option>');
    $('#ColoniaC').val('0').trigger('change');
    $('#MunicipioC').empty();
    $("#MunicipioC").append('<option value=""></option>');
    $('#MunicipioC').val('0').trigger('change');
    $('#EstadoC').empty();
    $("#EstadoC").append('<option value=""></option>');
    $('#EstadoC').val('0').trigger('change');

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateOrientador').trigger('reset');
    $('#CreateOrientador').find(':input').each(function () {
        switch (this.type) {
            case 'password':
            case 'number':
            case 'select-multiple':
            case 'select-one':
            case 'select':
            case 'text':
            case 'textarea':
                $(this).val('');
				for (instance in CKEDITOR.instances) {
                    CKEDITOR.instances[instance].updateElement();
                    CKEDITOR.instances[instance].setData('');
                }
                break;
            case 'checkbox':
            case 'radio':
                this.checked = false;
        }
    });
}
function CheckValidation() {
    var $myForm = $('#CreateOrientador');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblClave").text("0");
}
$(document).ready(function () {
    $("form#CreateOrientador").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateOrientador").on('click', '#OrientadorCancelar', function () {
	  if (!isPartial) {
        OrientadorBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateOrientador").on('click', '#OrientadorGuardar', function () {
		$('#OrientadorGuardar').attr('disabled', true);
		$('#OrientadorGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendOrientadorData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						OrientadorBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#OrientadorGuardar').removeAttr('disabled');
                        $('#OrientadorGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Orientador', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_OrientadorItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_OrientadorDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#OrientadorGuardar').removeAttr('disabled');
					$('#OrientadorGuardar').bind()
				}
		}
		else {
			$('#OrientadorGuardar').removeAttr('disabled');
			$('#OrientadorGuardar').bind()
		}
    });
	$("form#CreateOrientador").on('click', '#OrientadorGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendOrientadorData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Orientador', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_OrientadorItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_OrientadorDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateOrientador").on('click', '#OrientadorGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendOrientadorData(function (currentId) {
					$("#ClaveId").val("0");
	    $('#Usuario_que_Registra').empty();
    $("#Usuario_que_Registra").append('<option value=""></option>');
    $('#Usuario_que_Registra').val('0').trigger('change');
    $('#Colonia').empty();
    $("#Colonia").append('<option value=""></option>');
    $('#Colonia').val('0').trigger('change');
    $('#Municipio').empty();
    $("#Municipio").append('<option value=""></option>');
    $('#Municipio').val('0').trigger('change');
    $('#Estado').empty();
    $("#Estado").append('<option value=""></option>');
    $('#Estado').val('0').trigger('change');
    $('#Colonia2').empty();
    $("#Colonia2").append('<option value=""></option>');
    $('#Colonia2').val('0').trigger('change');
    $('#Municipio2').empty();
    $("#Municipio2").append('<option value=""></option>');
    $('#Municipio2').val('0').trigger('change');
    $('#Estado2').empty();
    $("#Estado2").append('<option value=""></option>');
    $('#Estado2').val('0').trigger('change');
    $('#Estado_Placas').empty();
    $("#Estado_Placas").append('<option value=""></option>');
    $('#Estado_Placas').val('0').trigger('change');
    $('#Colonia3').empty();
    $("#Colonia3").append('<option value=""></option>');
    $('#Colonia3').val('0').trigger('change');
    $('#Municipio3').empty();
    $("#Municipio3").append('<option value=""></option>');
    $('#Municipio3').val('0').trigger('change');
    $('#Estado3').empty();
    $("#Estado3").append('<option value=""></option>');
    $('#Estado3').val('0').trigger('change');
    $('#ColoniaC').empty();
    $("#ColoniaC").append('<option value=""></option>');
    $('#ColoniaC').val('0').trigger('change');
    $('#MunicipioC').empty();
    $("#MunicipioC").append('<option value=""></option>');
    $('#MunicipioC').val('0').trigger('change');
    $('#EstadoC').empty();
    $("#EstadoC").append('<option value=""></option>');
    $('#EstadoC').val('0').trigger('change');

					ResetClaveLabel();
					$("#ReferenceClave").val(currentId);
	
					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Orientador',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_OrientadorItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_OrientadorDropDown().get(0)').innerHTML);                          
					    }	
					}						
			setIsNew();
				});
		}
    });
});

function setIsNew() {
    $('#hdnIsNew').val("True");
	$('#Operation').val("New");
	operation = "New";
}



var mainElementObject;
var childElementObject;
function DisplayElementAttributes(data) {
}

function getElementTable(elementNumber, table) {

    for (var j = 0; j < childElementObject.length; j++) {
        if (childElementObject[j].table == table) {
            return childElementObject[j].elements[elementNumber];
            break;
        }
    }
}

function setRequired(elementNumber, element, elementType, table) {
    //debugger;
    if (elementType == "1") {
        mainElementObject[elementNumber].IsRequired = (mainElementObject[elementNumber].IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!mainElementObject[elementNumber].IsVisible && mainElementObject[elementNumber].IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (mainElementObject[elementNumber].IsReadOnly && mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    } else {
        getElementTable(elementNumber, table).IsRequired = (getElementTable(elementNumber, table).IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!getElementTable(elementNumber, table).IsVisible && getElementTable(elementNumber, table).IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (getElementTable(elementNumber, table).IsReadOnly && getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    }
}
function setVisible(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && mainElementObject[elementNumber].IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        mainElementObject[elementNumber].IsVisible = (mainElementObject[elementNumber].IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && getElementTable(elementNumber, table).IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsVisible = (getElementTable(elementNumber, table).IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    }
}
function setReadOnly(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && !mainElementObject[elementNumber].IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        mainElementObject[elementNumber].IsReadOnly = (mainElementObject[elementNumber].IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsReadOnly == true ?GetTraduction('Disabled') : GetTraduction('Enabled')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && !getElementTable(elementNumber, table).IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsReadOnly = (getElementTable(elementNumber, table).IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsReadOnly == true ? GetTraduction('Disabled') : GetTraduction('Enabled')));
    }
}
function setDefaultValue(elementNumber, element, elementType, table) {
    //debugger;
    $('#hdnAttributType').val('1');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('DefaultValue'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].DefaultValue);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).DefaultValue);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
}
function setHelpText(elementNumber, element, elementType, table) {
    $('#hdnAttributType').val('2');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('HelpText'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].HelpText);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).HelpText);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
    //$(element).children().attr("src", "" + (mainElementObject[elementNumber].HelpText == '' ? "Images/red-help.png" : "Images/green-help.png") + "");
}
function SaveValue(table) {
    debugger;
    if ($('#hdnElementType').val() == "1") {
        if ($('#hdnAttributType').val() == "1") {
            mainElementObject[$('#hdnAttributNumber').val()].DefaultValue = $('#txtAttributeValue').val();
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue));
        } else if ($('#hdnAttributType').val() == "2") {
            mainElementObject[$('#hdnAttributNumber').val()].HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].HelpText));
        }
    } else {
        if ($('#hdnAttributType').val() == "1") {
            getElementTable($('#hdnAttributNumber').val(), table).DefaultValue = $('#txtAttributeValue').val();
            console.log(childElementObject[$('#hdnAttributNumber').val()].DefaultValue);
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue));
            console.log($('#hdnAttributNumber').val());
        } else if ($('#hdnAttributType').val() == "2") {
            getElementTable($('#hdnAttributNumber').val(), table).HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).HelpText));
        }
    }
    $('#txtAttributeValue').val('');
    $('#dvAttributeValue').hide();
}
function returnAttributeHTML(element, table, number) {
    var mainElementAttributes = '<div class="col-ld-12" style="display:inline-flex;">';
    mainElementAttributes += '<div class="displayAttributes requiredAttribute"><a class="requiredClick" title="' + (element.IsRequired == true ? GetTraduction("Required") : GetTraduction("NotRequired")) + '" onclick="setRequired(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes visibleAttribute"><a class="visibleClick" title="' + (element.IsVisible == true ? GetTraduction("Visible") : GetTraduction("InVisible")) + '" onclick="setVisible(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsVisible == true ? "Images/Visible.png" : "Images/InVisible.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes readOnlyAttribute"><a class="readOnlyClick" title="' + (element.IsReadOnly == true ?GetTraduction("Disabled") :GetTraduction("Enabled")) + '" onclick="setReadOnly(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes defaultValueAttribute"><a id="hlDefaultValueHeader_' + number.toString() + '" class="defaultValueClick" title="' + (element.DefaultValue) + '" onclick="setDefaultValue(' + number.toString() + ', this, 2,  "' + table + '")"><img src="' + $('#hdnApplicationDirectory').val() + (element.DefaultValue != '' && element.DefaultValue != null ? "Images/default-value.png" : "Images/Not-Default-Value.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes helpTextAttribute"><a id="hlHelpTextHeader_' + number.toString() + '" class="helpTextClick" title="' + (element.HelpText) + '" onclick="setHelpText(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.HelpText != '' && element.HelpText != null ? "Images/green-help.png" : "Images/red-help.jpg") + '" alt="" /></a></div>';
    mainElementAttributes += '</div>';
    return mainElementAttributes;
}



var OrientadorisdisplayBusinessPropery = false;
OrientadorDisplayBusinessRuleButtons(OrientadorisdisplayBusinessPropery);
function OrientadorDisplayBusinessRule() {
    if (!OrientadorisdisplayBusinessPropery) {
        $('#CreateOrientador').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="OrientadordisplayBusinessPropery"><button onclick="OrientadorGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#OrientadorBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.OrientadordisplayBusinessPropery').remove();
    }
    OrientadorDisplayBusinessRuleButtons(!OrientadorisdisplayBusinessPropery);
    OrientadorisdisplayBusinessPropery = (OrientadorisdisplayBusinessPropery ? false : true);
}
function OrientadorDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

