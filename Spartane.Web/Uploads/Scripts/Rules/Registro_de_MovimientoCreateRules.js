var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
	$("#Registro_de_MovimientoGuardarYNuevo").addClass("hidden");
	$("#Registro_de_MovimientoGuardarYCopia").addClass("hidden");
});

var dinamicosrequeridos = [];
var datepickers = [];
var multi = [];
function ObtenControlesDinamicos(mov) {
    listaControlesDinamicos = ExecuteQueryTabla("exec usp_GetDetalle_Datos_Adicionales_Movimiento " + mov);
    var htmldinamico = "";
    if (listaControlesDinamicos != null) {
        for (var i = 0; i < listaControlesDinamicos.length; i++) {
            switch (listaControlesDinamicos[i].TipoControlId) {
                case 1:
                    htmldinamico += AgregaNumerico(listaControlesDinamicos[i].Label, i);
                    break;
                case 2:
                    htmldinamico += AgregaTexto(listaControlesDinamicos[i].Label, true, i);
                    break;
                case 3:
                    htmldinamico += AgregaTexto(listaControlesDinamicos[i].Label, false, i);
                    break;
                case 4:
                    htmldinamico += Agregarfecha(listaControlesDinamicos[i].Label, i);
                    datepickers.push("#idcampDinamico_" + i);
                    break;
                case 6:
                    AgregaCheck(listaControlesDinamicos[i].Label, i);
                    break;
                case 7:                    
                    var lstDatosCombo = [];
                    lstDatosCombo = ExecuteQueryTabla(listaControlesDinamicos[i].Query_para_llenado);
                    if (lstDatosCombo != null) {
                        AgregaCombo(listaControlesDinamicos[i].Label, i, lstDatosCombo);
                    }
                    break;
                case 8:                    
                    var lstDatosComboM = [];
                    lstDatosComboM = ExecuteQueryTabla(listaControlesDinamicos[i].Query_para_llenado);
                    if (lstDatosComboM != null) {
                        AgregaComboM(listaControlesDinamicos[i].Label, i, lstDatosComboM);
                    }
                    multi.push("#idcampDinamico_" + i);
                    break;
            }         
		
            if (listaControlesDinamicos[i].Obligatorio == 1) 
                dinamicosrequeridos.push("#idcampDinamico_" + i);            
        }
       
        for (var i = 0; i < datepickers.length; i++) {
            $(datepickers[i]).datepicker({
                todayBtn: "linked",
                keyboardNavigation: false,
                forceParse: false,
                calendarWeeks: true,
                autoclose: true,
                format: "dd-mm-yyyy"
            });
        }
        $(".chosen-select").chosen({ width: "100%", no_results_text: "Oops, nothing found!" });
        for (var i = 0; i < multi.length; i++) {
            $(multi[i]).children("selected").each(function () {
                $(this).prop("selected", false);
            });
            $(multi[i]).trigger('chosen:updated');
        }
        for (var i = 0; i < dinamicosrequeridos.length; i++) {
            SetRequiredToControl($(dinamicosrequeridos[i]));
        }
    }
}

var listaControlesDinamicos = [];
var entrachangevalue="0";
$("#Movimiento_Realizado").change(function () {  
	if($("#Movimiento_Realizado").val() != null && entrachangevalue != $("#Movimiento_Realizado").val()){
		debugger;  
		console.log($("#Movimiento_Realizado").val());	
		$("#compDinamicos").html("");
		ObtenControlesDinamicos($("#Movimiento_Realizado").val());	
		entrachangevalue= $("#Movimiento_Realizado").val();		
		LlenadoDatosExistentes($("#ReferenceClave").val());
	}
});

function AgregaTexto(lbl, corto, index) {
    var htmlparcial = "campDinamico_" + index;
    if (corto) {
        htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
            "<label class='col-sm-2 control-label'>" + lbl + "</label>" +
            "<div class='col-sm-8' data-field-id='id" + htmlparcial + "' >" +
            "<input class='form-control Datos_Generales' id='id" + htmlparcial + "' type='text'>" +
            "</div>" +
            "</div>";
    } else {
        htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
            "<label class='col-sm-2 control-label'>" + lbl + "</label>" +
            "<div class='col-sm-8' data-field-id='id" + htmlparcial + "' >" +
            "<textarea id='id" + htmlparcial + "'  class='form-control Datos_Generales' rows='4' cols='50'></textarea>" +
            "</div>" +
            "</div>";
    }
    var htmlparcialex = $("#compDinamicos").html();
    $("#compDinamicos").html(htmlparcialex + htmlparcial);
}

function AgregaNumerico(lbl, index) {
    var htmlparcial = "campDinamico_" + index;
    htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
        "<label class='col-sm-2 control-label'>" + lbl + "</label>" +
        "<div class='col-sm-8' data-field-id='id" + htmlparcial + "' >" +
        "<input class='form-control Datos_Generales' id='id" + htmlparcial + "' type='number'>" +
        "</div>" +
        "</div>";
    var htmlparcialex = $("#compDinamicos").html();
    $("#compDinamicos").html(htmlparcialex + htmlparcial);
}

function AgregaCheck(lbl, index) {
    var htmlparcial = "campDinamico_" + index;
    htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
        "<label class='col-sm-2 control-label'>" + lbl + "</label>" +
        "<div class='col-sm-8' data-field-id='id" + htmlparcial + "' >" +
        "<input class='i-checks Datos_Generales' id='id" + htmlparcial + "' type='checkbox'>" +
        "</div>" +
        "</div>";
    var htmlparcialex = $("#compDinamicos").html();
    $("#compDinamicos").html(htmlparcialex + htmlparcial);
}

function AgregaCombo(lbl, index, lst) {
    var htmlparcial = "campDinamico_" + index;
    htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
        "<label class='col-sm-2 control-label'>" + lbl + "</label>" +
        "<div class='col-sm-8' data-field-id='id" + htmlparcial + "' >" +
        "<select class='form-control Datos_Generales' data-val='true' data-val-number='The field Fase must be a number.' data-val-required='The Fase field is required.' id='id" + htmlparcial + "' ><option value='0'></option>";
    for (var i = 0; i < lst.length; i++) {
        htmlparcial += "<option value='" + lst[i].clave + "'>" + lst[i].descripcion + "</option>";
    }
    htmlparcial += "</select>" +
        "</div>" +
        "</div>";
    var htmlparcialex = $("#compDinamicos").html();
    $("#compDinamicos").html(htmlparcialex + htmlparcial);
}

function AgregaComboM(lbl, index, lst) {
    var htmlparcial = "campDinamico_" + index;
    var idmultiple = "#id" + htmlparcial;
    htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
        "<label class='col-sm-2 control-label'>" + lbl + "</label>" +
        "<div class='col-sm-8' data-field-id='id1" + htmlparcial + "' >" +
        "<select class='form-control chosen-select Datos_Generales' id='id" + htmlparcial + "' name='id" + htmlparcial + "' multiple='multiple' >" +
        "</select>" +
        "</div>" +
        "</div>";
    var htmlparcialex = $("#compDinamicos").html();
    $("#compDinamicos").html(htmlparcialex + htmlparcial);

    for (var i = 0; i < lst.length; i++) {
        $(idmultiple).append(new Option(
            lst[i].descripcion, lst[i].clave
        ));
    }
}

function Agregarfecha(lbl, index) {
    var htmlparcial = "campDinamico_" + index;
    htmlparcial = "<div class='form-group' id='div" + htmlparcial + "'>" +
        "<label class='col-sm-2 control-label' for='id" + htmlparcial + "'>" + lbl + "</label>" +
        "<div class='col-sm-8' >" +
        "<div class='input-group date' id='datetimepicker1comDinamico" + index + "'>" +
        "<input class='form-control col-md-12 Datos_Generales' id='id" + htmlparcial + "'  type='text' >" +
        "<span class='input-group-addon'>" +
        "<span class='glyphicon glyphicon-calendar'></span>" +
        "</span>" +
        "</div>" +
        "</div>" +
        "</div>";
    var htmlparcialex = $("#compDinamicos").html();
    $("#compDinamicos").html(htmlparcialex + htmlparcial);
}

function ExecuteQueryTabla(query) {
    var resultados = [];
    var data = {
        query: query
    }

    $.ajax({
        url: url_content + "Frontal/General/ExecuteQueryTable",
        type: 'POST',
        dataType: "json",
        cache: false,
        async: false,
        data: data,
        success: function (result) {			
			if(result != null && result != ""){
				var jsonObj = $.parseJSON(result);
				resultados = jsonObj;
			}else{
				resultados=[];				
			}
        },
        error: function (result) {
            showNotification("Error ejecutando query", "error");
            res = "0";
        }
    });
    return resultados;
}
var htmldinamicoComp="";
function GuardarInformacion() {  
    var htmldinamico = "";
    if (listaControlesDinamicos != null) {
        for (var i = 0; i < listaControlesDinamicos.length; i++) {
            htmldinamico += "<strong>" + listaControlesDinamicos[i].Label + ": </strong>";
            switch (listaControlesDinamicos[i].TipoControlId) {
                case 1:
                    htmldinamico += $("#idcampDinamico_" + i).val();                    
                    break;
                case 2:
                    htmldinamico += $("#idcampDinamico_" + i).val();   
                    break;
                case 3:
                    htmldinamico += $("#idcampDinamico_" + i).val();   
                    break;
                case 4:
                    htmldinamico += $("#idcampDinamico_" + i).val();   
                    break;
                case 6:                    
                    if ($("#idcampDinamico_" + i).prop("checked"))
                        htmldinamico += "Si";
                    else
                        htmldinamico += "No";
                    break;
                case 7:                    
                    var lstDatosCombo = [];
                    lstDatosCombo = ExecuteQueryTabla(listaControlesDinamicos[i].Query_para_llenado);
                    htmldinamico += ObtieneValor($("#idcampDinamico_" + i).val(),lstDatosCombo);
                    break;
                case 8:                    
                    var lstDatosComboM = [];
                    lstDatosComboM = ExecuteQueryTabla(listaControlesDinamicos[i].Query_para_llenado);
                    var valores = $("#idcampDinamico_" + i).val();
                    for (var l = 0; l < valores.length; l++) {
                        htmldinamico += ObtieneValor(valores[l], lstDatosComboM);
                        if ((l + 1) < valores.length)
                            htmldinamico += ", ";
                        
                    }
                    break;
            }
            htmldinamico += "<br> ";       
        }
    }    
	htmldinamicoComp = htmldinamico;
    $('#Informacion').val(htmldinamico);
    CKEDITOR.instances['Informacion'].setData(htmlDecode(htmldinamico));    
}

function ObtieneValor(valor, lst) {    
    for (var i = 0; i < lst.length;i++) {
        if (lst[i].clave==valor) {
            return lst[i].descripcion;
        }
    }    
}

function GuardaInformacionXCampo(idnew, campo, etiqueta, valor) {    
    var GuardadoCorrecto = ExecuteQueryTabla("exec usp_GuardaDetalle_de_Guardado_de_Movimiento " + idnew + "," + campo + ",'" + etiqueta + "','" + valor + "'");
    if (GuardadoCorrecto != null) {
        if (GuardadoCorrecto.length > 0) {
            if (GuardadoCorrecto[0].clave > 0)
                return true;
        }
    }
    return false;
}

function GuardarInformacionCampos(idnew) {    
	ExecuteQueryTabla("exec usp_GDelDetalle_de_Guardado_de_Movimiento " + idnew);	
    if (listaControlesDinamicos != null) {
        for (var i = 0; i < listaControlesDinamicos.length; i++) {            
            switch (listaControlesDinamicos[i].TipoControlId) {
                case 1:
                case 2:                    
                case 3:                    
                case 4:
                case 7:
                    GuardaInformacionXCampo(idnew, listaControlesDinamicos[i].Campo, listaControlesDinamicos[i].Label, $("#idcampDinamico_" + i).val());                    
                    break;
                case 6:
                    GuardaInformacionXCampo(idnew, listaControlesDinamicos[i].Campo, listaControlesDinamicos[i].Label, $("#idcampDinamico_" + i).prop("checked"));                                 
					break;
                case 8:                   
                    var valores = $("#idcampDinamico_" + i).val();
                    for (var l = 0; l < valores.length; l++) {
                        GuardaInformacionXCampo(idnew, listaControlesDinamicos[i].Campo, listaControlesDinamicos[i].Label, valores[l]);  
                    }
                    break;
            }            
        }
    }
}

function LlenadoDatosExistentes(idrm) {
	debugger;
    var campomultianterior = "";
    var lstDatosComboM = [];
    var multi2 = [];
    var listaDatosExistentes = ExecuteQueryTabla("exec usp_GetDetalle_de_Guardado_de_Movimiento " + idrm);
    var htmldinamico = "";
    if (listaDatosExistentes != null) {
        for (var e = 0; e < listaDatosExistentes.length; e++) {
            for (var i = 0; i < listaControlesDinamicos.length; i++) {
                if (listaDatosExistentes[e].Campo == listaControlesDinamicos[i].Campo) {
                    switch (listaControlesDinamicos[i].TipoControlId) {
                        case 1:
                        case 2:
                        case 3:
                        case 4:                       
                        case 7:
                            $("#idcampDinamico_" + i).val(listaDatosExistentes[e].Valor);
                            break;
						case 6:
						   if (listaDatosExistentes[e].Valor == 'true') {
                                $("#idcampDinamico_" + i).prop("checked", true);
                            }
                            break;							
                        case 8:
                            if (campomultianterior != listaDatosExistentes[e].Campo) {
                                lstDatosComboM = [];
                                campomultianterior = listaDatosExistentes[e].Campo;
								multi2.push("#idcampDinamico_" + i);
                            }
                            lstDatosComboM.push(listaDatosExistentes[e].Valor);
                            $("#idcampDinamico_" + i).val(lstDatosComboM);                            
                            break;
                    }
                }
            }
        }
		for (var i = 0; i < multi2.length; i++) {
            $(multi2[i]).trigger('chosen:updated');            
        }       
    }
}

function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2990, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divJudicializacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Judicializacion' + rowIndex));$('#divFase').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fase' + rowIndex));$('#divUsuario_que_Registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));$('#divInformacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Informacion' + rowIndex));
}
//BusinessRuleId:2990, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2990, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divJudicializacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Judicializacion' + rowIndex));$('#divFase').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fase' + rowIndex));$('#divUsuario_que_Registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));$('#divInformacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Informacion' + rowIndex));

}
//BusinessRuleId:2990, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2990, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 $('#divClave').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));$('#divJudicializacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Judicializacion' + rowIndex));$('#divFase').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Fase' + rowIndex));$('#divUsuario_que_Registra').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));$('#divInformacion').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Informacion' + rowIndex));

}
//BusinessRuleId:2990, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2991, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select Name from Spartan_User where Id_USer=GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2991, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2996, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
if( EvaluaQuery("select GLOBAL[idFase]",rowIndex, nameOfTable)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val();   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion From Configurador_de_Movimientos with(nolock) where Fase=GLOBAL[idFase]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion From Configurador_de_Movimientos with(nolock) where Fase=GLOBAL[idFase]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val();   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("	 select Clave, Descripcion From Configurador_de_Movimientos with(nolock) ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("	 select Clave, Descripcion From Configurador_de_Movimientos with(nolock) ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val(valor).trigger('change');}

}
//BusinessRuleId:2996, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2996, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( EvaluaQuery("select GLOBAL[idFase]",rowIndex, nameOfTable)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val();   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion From Configurador_de_Movimientos with(nolock) where Fase=GLOBAL[idFase]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion From Configurador_de_Movimientos with(nolock) where Fase=GLOBAL[idFase]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val();   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("	 select Clave, Descripcion From Configurador_de_Movimientos with(nolock) ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("	 select Clave, Descripcion From Configurador_de_Movimientos with(nolock) ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val(valor).trigger('change');}

}
//BusinessRuleId:2996, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2996, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
if( EvaluaQuery("select GLOBAL[idFase]",rowIndex, nameOfTable)!=TryParseInt('', '') ) { var valor = $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val();   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("select Clave, Descripcion From Configurador_de_Movimientos with(nolock) where Fase=GLOBAL[idFase]", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("select Clave, Descripcion From Configurador_de_Movimientos with(nolock) where Fase=GLOBAL[idFase]", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val(valor).trigger('change');} else { var valor = $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val();   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).empty();         if(!$('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).hasClass('AutoComplete'))  {         $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option selected />").val("").text(""));         $.each(EvaluaQueryDictionary("	 select Clave, Descripcion From Configurador_de_Movimientos with(nolock) ", rowIndex, nameOfTable), function (index, value) {           $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).append($("<option />").val(index).text(value));      });  }       else    {    var selectData = [];   selectData.push({id: "",text: "" });      $.each(EvaluaQueryDictionary("	 select Clave, Descripcion From Configurador_de_Movimientos with(nolock) ", rowIndex, nameOfTable), function (index, value) {            selectData.push({              id: index,              text: value          });    });      $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).select2({data: selectData})    }   $('#' + nameOfTable + 'Movimiento_Realizado' + rowIndex).val(valor).trigger('change');}

}
//BusinessRuleId:2996, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
	GuardarInformacion();
	debugger;
	if(operation == 'New'){
		
		
	}
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){


//BusinessRuleId:2992, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" UPDATE registro_De_movimiento set judicializacion=GLOBAL[GLOBAL_JUDICIALIZACION], Fase=GLOBAL[GLOBAL_FASE] where clave=GLOBAL[keyvalueinserted]", rowIndex, nameOfTable);

}
//BusinessRuleId:2992, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}


