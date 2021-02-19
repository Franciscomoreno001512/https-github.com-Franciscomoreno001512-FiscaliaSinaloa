var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
    $("#JudicializacionGuardarYNuevo, #JudicializacionGuardarYCopia").remove();
//BusinessRuleId:2983, Attribute:268570, Operation:Field, Event:None
$("form#CreateJudicializacion").on('change', '#Tribunal_de_Enjuiciamiento', function () {
	nameOfTable='';
	rowIndex='';
if( GetValueByControlType($('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombre_del_Juez').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));$('#divJuez_Relator').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));$('#divJuez_Vocal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));} else { $('#divNombre_del_Juez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'block');$('#divJuez_Relator').css('display', 'block');$('#divJuez_Vocal').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));}
});

//BusinessRuleId:2983, Attribute:268570, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {






//BusinessRuleId:2984, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
if( GetValueByControlType($('#' + nameOfTable + 'Tribunal_de_Enjuiciamiento' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { $('#divNombre_del_Juez').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));$('#divJuez_Relator').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));$('#divJuez_Vocal').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));} else { $('#divNombre_del_Juez').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Nombre_del_Juez' + rowIndex)); $('#divJuez_Presidente').css('display', 'block');$('#divJuez_Relator').css('display', 'block');$('#divJuez_Vocal').css('display', 'block'); SetRequiredToControl( $('#' + nameOfTable + 'Juez_Presidente' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Relator' + rowIndex));SetRequiredToControl( $('#' + nameOfTable + 'Juez_Vocal' + rowIndex));}

}
//BusinessRuleId:2984, Attribute:0, Operation:Object, Event:SCREENOPENING







//BusinessRuleId:3345, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 CreateSessionVar('prueba', '2');

}
//BusinessRuleId:3345, Attribute:0, Operation:Object, Event:SCREENOPENING

//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:3455, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'Update'){
if(  EvaluaOperatorIn (TryParseInt(ReplaceGLOBAL('GLOBAL[global_etapa]'), ReplaceGLOBAL('GLOBAL[global_etapa]')), EvaluaQuery("select STUFF((    select ';' + Descripcion + ''   from Fase_de_Judicializacion where Clave in (1,2,3) for XML PATH('')  ), 1, 1, '')",rowIndex, nameOfTable) ) ) { AsignarValor($('#' + nameOfTable + 'Fase_Actual' + rowIndex),ReplaceGLOBAL('global_etapa'));} else {}

}
//BusinessRuleId:3455, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Vinculacion_Judicializacion//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Vinculacion_Judicializacion//
}
function EjecutarValidacionesAlEliminarMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Vinculacion_Judicializacion//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_NEWROWMR_Detalle_Vinculacion_Judicializacion//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Vinculacion_Judicializacion(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_EDITROWMR_Detalle_Vinculacion_Judicializacion//
    return result;
}

