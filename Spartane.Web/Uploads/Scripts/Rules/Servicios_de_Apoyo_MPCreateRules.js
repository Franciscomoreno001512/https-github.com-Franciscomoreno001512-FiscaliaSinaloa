var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
var saltarValidacion = false;
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar(){
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar(){
//NEWBUSINESSRULE_AFTERSAVING//

    debugger;
    //fjmore
    if (operation == 'New') {
        debugger;
        var diligencia = $('#Diligencia_a_Enviar').val();
        var query = 'select top 1 cd.Archivo from Diligencias_MP doc with (nolock) inner join Control_de_Documentos cd with (nolock) on doc.Archivo = cd.Folio where doc.Clave = ' + diligencia + '';
        var SpartanFileId = EvaluaQuery(query);

        var resultado = GetSpartanFileAndPost(SpartanFileId);
        if (resultado > 0) {
            var key = EvaluaQuery(" select GLOBAL[keyvalueinserted]");
            var queryUpd = 'update Servicios_de_Apoyo_MP set Archivo_adjunto = ' + resultado + ' where Clave = ' + key + '';
            var dataResult = EvaluaQuery(queryUpd);

        }
        else {

            alert("No se pudo actualizar el archivo en detalle_de_documentos");
        }


    }
}


