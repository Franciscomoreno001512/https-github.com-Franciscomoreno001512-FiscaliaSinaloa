var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$('#AseguramientosGuardarYNuevo').hide();
$('#AseguramientosGuardarYCopia').hide();

$(document).ready(function () {


//BusinessRuleId:2715, Attribute:267566, Operation:Field, Event:None
$("#Detalle_Aseguramiento_Medios_de_TransporteGrid").on('change', '.Tipo', function () {
	nameOfTable = $(this).parent().parent().parent().parent()[0].id.replace('Grid', '') + '_';
	rowIndex = '_' + $(this).parent().parent()[0].className.replace(' odd', '').replace(' even', '').replace(nameOfTable, '');
if( GetValueByControlType($('#' + nameOfTable + 'Tipo' + rowIndex),nameOfTable,rowIndex)==TryParseInt('1', '1') ) { DisabledControl($("#" + nameOfTable + "Especifique" + rowIndex), ("false" == "true"));if ('false'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));}} else { DisabledControl($("#" + nameOfTable + "Especifique" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));}}
	nameOfTable='';
	rowIndex='';
});

//BusinessRuleId:2715, Attribute:267566, Operation:Field, Event:None

//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//BusinessRuleId:2647, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));

}
//BusinessRuleId:2647, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2647, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Update'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));

}
//BusinessRuleId:2647, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2647, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'Consult'){
 DisabledControl($("#" + nameOfTable + "Fecha_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Hora_de_Registro" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));}DisabledControl($("#" + nameOfTable + "Usuario_que_Registra" + rowIndex), ("true" == "true"));if ('true'=='true'){SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));} $('#divExpediente').css('display', 'none'); SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));

}
//BusinessRuleId:2647, Attribute:0, Operation:Object, Event:SCREENOPENING

//BusinessRuleId:2648, Attribute:0, Operation:Object, Event:SCREENOPENING
if(operation == 'New'){
 AsignarValor($('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 105)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Hora_de_Registro' + rowIndex),EvaluaQuery("select convert(nvarchar(11), getdate(), 108)", rowIndex, nameOfTable)); AsignarValor($('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex),EvaluaQuery(" select name from Spartan_User where Id_User = GLOBAL[USERID]", rowIndex, nameOfTable));

}
//BusinessRuleId:2648, Attribute:0, Operation:Object, Event:SCREENOPENING





//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//BusinessRuleId:2650, Attribute:2, Operation:Object, Event:AFTERSAVING
if(operation == 'New'){
 EvaluaQuery(" update Aseguramientos set expediente = GLOBAL[SpartanOperationId] where clave=GLOBAL[keyvalueinserted]"
+" ", rowIndex, nameOfTable);

}
//BusinessRuleId:2650, Attribute:2, Operation:Object, Event:AFTERSAVING

//NEWBUSINESSRULE_AFTERSAVING//
}

function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Medios_de_Transporte(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Medios_de_Transporte//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Medios_de_Transporte(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Medios_de_Transporte//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Medios_de_Transporte(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Medios_de_Transporte//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Medios_de_Transporte(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:NEWROWMR





























//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Medios_de_Transporte//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Medios_de_Transporte(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2651, Attribute:267649, Operation:Object, Event:EDITROWMR





























//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Medios_de_Transporte//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Drogas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_de_Drogas_Involucradas//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Drogas_Involucradas(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_de_Drogas_Involucradas//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_de_Drogas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_de_Drogas_Involucradas//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Drogas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));

}
//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));

}
//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_de_Drogas_Involucradas//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Drogas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));

}
//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));

}
//BusinessRuleId:2653, Attribute:267650, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_de_Drogas_Involucradas//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Armas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Armas_Involucradas//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Armas_Involucradas(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Armas_Involucradas//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Armas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Armas_Involucradas//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Armas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Armas_Involucradas//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Armas_Involucradas(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Expediente' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Fecha_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Hora_de_Registro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Usuario_que_Registra' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion_del_Arma' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calibre' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Matricula' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clave' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Aseguramiento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Placas' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Color' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero_de_Motor' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Uso' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cap__De_Pasajeros' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Procedencia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Empresa' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Capacidad_de_Carga' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Origen' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Destino' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Detencion' + rowIndex));

}
//BusinessRuleId:2654, Attribute:267651, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Armas_Involucradas//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Artefactos_y_Explosivos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Artefactos_y_Explosivos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Artefactos_y_Explosivos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Artefactos_y_Explosivos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Artefactos_y_Explosivos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Artefactos_y_Explosivos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Artefactos_y_Explosivos(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Artefactos_y_Explosivos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Artefactos_y_Explosivos(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Clasificacion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Lugar_de_Hallazgo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2655, Attribute:267656, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Artefactos_y_Explosivos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Cargador_Cartuchos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_de_Cargador_Cartuchos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Cargador_Cartuchos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_de_Cargador_Cartuchos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_de_Cargador_Cartuchos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_de_Cargador_Cartuchos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Cargador_Cartuchos(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));

}
//BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));

}
//BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_de_Cargador_Cartuchos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Cargador_Cartuchos(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));

}
//BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'cartuchos_municiones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Habiles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cartuchos_Percutidos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'cargadores' + rowIndex));

}
//BusinessRuleId:2656, Attribute:267652, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_de_Cargador_Cartuchos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Objetos_Asegurados(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Objetos_Asegurados//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Objetos_Asegurados(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Objetos_Asegurados//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Objetos_Asegurados(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Objetos_Asegurados//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Objetos_Asegurados(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));

}
//BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));

}
//BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Objetos_Asegurados//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Objetos_Asegurados(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));

}
//BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Numero' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'IMEI' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Submarca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));

}
//BusinessRuleId:2657, Attribute:267653, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Objetos_Asegurados//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Documentos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Documentos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Documentos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Documentos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Documentos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Documentos(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));

}
//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));

}
//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Documentos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Documentos(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));

}
//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descipcion_de_Documento' + rowIndex));

}
//BusinessRuleId:2658, Attribute:267654, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Documentos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Moneda(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Moneda//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Moneda(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Moneda//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Moneda(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Moneda//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Moneda(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Moneda//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Moneda(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2659, Attribute:267655, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Moneda//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Otros_Aseguramientos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Otros_Aseguramientos//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Otros_Aseguramientos(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Otros_Aseguramientos//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Otros_Aseguramientos(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Otros_Aseguramientos//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Otros_Aseguramientos(nameOfTable, rowIndex){
    var result = true;
    















//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:NEWROWMR
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Otros_Aseguramientos//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Otros_Aseguramientos(nameOfTable, rowIndex){
    var result = true;
    















//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:EDITROWMR
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Inventario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Marca' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Modelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Serie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2750, Attribute:267657, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Otros_Aseguramientos//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Electronicos_y_Multimedia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Electronicos_y_Multimedia//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Electronicos_y_Multimedia(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Electronicos_y_Multimedia//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Electronicos_y_Multimedia(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Electronicos_y_Multimedia//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Electronicos_y_Multimedia(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Electronicos_y_Multimedia//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Electronicos_y_Multimedia(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Aparatos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Documentos_Multimedia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'A_resguardo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2759, Attribute:267658, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Electronicos_y_Multimedia//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Pirateria(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Pirateria//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Pirateria(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Pirateria//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Pirateria(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Pirateria//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Pirateria(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Pirateria//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Pirateria(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medicion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2760, Attribute:267659, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Pirateria//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Inmuebles(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Inmuebles//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Inmuebles(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Inmuebles//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Inmuebles(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Inmuebles//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Inmuebles(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Inmuebles//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Inmuebles(nameOfTable, rowIndex){
    var result = true;
    //BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Zona' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Terreno' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Especifique_Otro' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Calle' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Exterior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Interior' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'C_P' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Estado' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Municipio' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Colonia' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Registro_Publico_Propiedad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Entrecalles' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Propietario' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Observaciones' + rowIndex));

}
//BusinessRuleId:2762, Attribute:267660, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Inmuebles//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Plantios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_de_Plantios//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Plantios(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_de_Plantios//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_de_Plantios(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_de_Plantios//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Plantios(nameOfTable, rowIndex){
    var result = true;
    



























//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:NEWROWMR
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_de_Plantios//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Plantios(nameOfTable, rowIndex){
    var result = true;
    



























//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:EDITROWMR
if(operation == 'Consult'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'No__de_Plantios' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Kilogramos' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Metodo_de_Destruccion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Superficie' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Altura' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Densidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Peso_por_planta' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2764, Attribute:267661, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_de_Plantios//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(nameOfTable, rowIndex){
    var result = true;
    



















//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(nameOfTable, rowIndex){
    var result = true;
    



















//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Suelo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_1' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Localizacion_2' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Orientacion_de' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Largo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Ancho' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Latitud' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Longitud' + rowIndex)); SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));

}
//BusinessRuleId:2765, Attribute:267662, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje//
    return result;
}
function EjecutarValidacionesAntesDeGuardarMRDetalle_Aseguramiento_Otros(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_BEFORESAVINGMR_Detalle_Aseguramiento_Otros//
    return result;
}
function EjecutarValidacionesDespuesDeGuardarMRDetalle_Aseguramiento_Otros(nameOfTable, rowIndex){
    //NEWBUSINESSRULE_AFTERSAVINGMR_Detalle_Aseguramiento_Otros//
}
function EjecutarValidacionesAlEliminarMRDetalle_Aseguramiento_Otros(nameOfTable, rowIndex){
    var result = true;
    //NEWBUSINESSRULE_DELETEMR_Detalle_Aseguramiento_Otros//
    return result;
}
function EjecutarValidacionesNewRowMRDetalle_Aseguramiento_Otros(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:NEWROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:NEWROWMR

//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:NEWROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:NEWROWMR

//NEWBUSINESSRULE_NEWROWMR_Detalle_Aseguramiento_Otros//
    return result;
}
function EjecutarValidacionesEditRowMRDetalle_Aseguramiento_Otros(nameOfTable, rowIndex){
    var result = true;
    



//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:EDITROWMR
if(operation == 'New'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:EDITROWMR

//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:EDITROWMR
if(operation == 'Update'){
 SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Cantidad' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Unidad_de_Medida' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Descripcion' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));SetNotRequiredToControl( $('#' + nameOfTable + 'Tipo' + rowIndex));

}
//BusinessRuleId:2766, Attribute:267663, Operation:Object, Event:EDITROWMR

//NEWBUSINESSRULE_EDITROWMR_Detalle_Aseguramiento_Otros//
    return result;
}

