var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$("#UnidadGuardarYNuevo").hide();
$("#UnidadGuardarYCopia").hide();
$(document).ready(function () {
	//CONVERTIR A MAYUSCULAS AL BLUR
    $('input[type="text"],textarea').blur(function () {
        this.value = this.value.toUpperCase();
    });
    //END CONVERTIR A MAYUSCULAS AL BLUR
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {




//BusinessRuleId:2862, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('17', '17')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { $('#divcod_pais').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cod_pais' + rowIndex));$('#divcod_edo').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cod_edo' + rowIndex));$('#divcod_agencia').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'cod_agencia' + rowIndex));$('#divFTIPO').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'FTIPO' + rowIndex));$('#divfcreada').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'fcreada' + rowIndex));$('#divfbaja').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'fbaja' + rowIndex));$('#divULTAVREGIS').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'ULTAVREGIS' + rowIndex));$('#divFUBICACION').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'FUBICACION' + rowIndex));$('#divvr_agen').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'vr_agen' + rowIndex));$('#divEspecial').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Especial' + rowIndex));$('#divAgenAV').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'AgenAV' + rowIndex));$('#divAgenUni_NSJP').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'AgenUni_NSJP' + rowIndex));$('#divNomenclatura').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nomenclatura' + rowIndex));$('#divAlcance').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Alcance' + rowIndex));$('#divReceptorDeclinaciones').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'ReceptorDeclinaciones' + rowIndex));} else {}

}
//BusinessRuleId:2862, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2628, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( TryParseInt('17', '17')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { DisabledControl($("#" + nameOfTable + "Clave" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave_Unica_Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave_Unica_Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave_de_Municipio" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave_de_Municipio' + rowIndex));}DisabledControl($("#" + nameOfTable + "Clave_de_Region" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Clave_de_Region' + rowIndex));}DisabledControl($("#" + nameOfTable + "Abreviacion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Abreviacion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Descripcion_Corta" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_Corta' + rowIndex));}DisabledControl($("#" + nameOfTable + "Direccion" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Direccion' + rowIndex));}DisabledControl($("#" + nameOfTable + "Vigencia" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Vigencia' + rowIndex));}DisabledControl($("#" + nameOfTable + "Observaciones" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));}DisabledControl($("#" + nameOfTable + "Supervisor" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Supervisor' + rowIndex));}DisabledControl($("#" + nameOfTable + "Consecutivo_CDI" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Consecutivo_CDI' + rowIndex));} DisabledControl($("#" + nameOfTable + "Especialidad" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especialidad' + rowIndex));}} else {}

}
//BusinessRuleId:2628, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//
}


