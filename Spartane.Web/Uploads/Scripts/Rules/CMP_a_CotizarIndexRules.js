var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {

































//BusinessRuleId:175, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( CMP_a_Cotizar.Estatus = 1 )");} else {}


}
//BusinessRuleId:175, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:177, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( CMP_a_Cotizar.Estatus = 2 )");} else {}


}
//BusinessRuleId:177, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:179, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( CMP_a_Cotizar.Estatus = 3 )");} else {}


}
//BusinessRuleId:179, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}


//Comienza Funcionar para Agregar a cotización
function Agregar_a_Cotizacion() {
   
    var CMP_Seleccionados = GetCmpSeleccionadas('chk_'); 

    if (CMP_Seleccionados.length < 1) {
        alert('No se han seleccioando registros.');
        return; 
    }

    var CMPs = CMP_Seleccionados.split(',');
    var _continue = ValidarCliente(CMPs);


    if (_continue == false) {
        alert('Solo se puede incluir CMP de un solo cliente, favor de revisar.');
        return; 
    }

    var IdCotizacion = GeneraCotizacion(CMPs); 

    if (Number.isInteger(IdCotizacion) != true) {
        alert('Ocurrió un error al generar la cotización, favor de intentar de nuevo.');
        return; 
    }

    $.each(CMPs, function (index, value) {
           
        EvaluaQuery("EXEC uspIngresarCMPenCotizacion @Cotizacion = " + IdCotizacion + ", @CMPId = " + value);
        });

    //alert('La cotización fue generado exitosamente, Núm. de Cotización ' + IdCotizacion); 
    window.location.href =  "Cotizacion/Create?Id=" + IdCotizacion;
}

function GetCmpSeleccionadas(control) {
    var CmpSeleccionadas = '';
    $('input[id^="' + control + '"]').each(function (index) {
        if ($(this).is(':checked')) {
            CmpSeleccionadas = CmpSeleccionadas + $(this).val() + ',';
        }
    });
    if (CmpSeleccionadas != '') {
        CmpSeleccionadas = CmpSeleccionadas.substring(0, CmpSeleccionadas.length - 1);
    }
    return CmpSeleccionadas;
}

function ValidarCliente(folios) {

    var cliente = ''; 
    var result = true; 

    $.each(folios, function (index, value) {
        var clientefila = EvaluaQuery('SELECT Cliente FROM dbo.CMP_a_Cotizar WHERE Folio = ' + value );

        if (result) {

            if (cliente == '') { cliente = clientefila }

            if (cliente != clientefila) {
                result = false;
                return false;
            }
        }

        });
    return result; 
}

function GeneraCotizacion(folios) {

    var folio;
    $.each(folios, function (index, value) {
        folio = value;
        return false;
    });

    var usuario = 1;
    var cliente = EvaluaQuery('SELECT cliente FROM dbo.CMP_a_Cotizar WHERE Folio = ' + folio);
    var matricula = EvaluaQuery('SELECT matricula FROM dbo.CMP_a_Cotizar WHERE Folio = ' + folio);
    var modelo = EvaluaQuery('SELECT modelo FROM dbo.CMP_a_Cotizar WHERE Folio = ' + folio);
    var contacto = EvaluaQuery('SELECT contacto FROM dbo.CMP_a_Cotizar WHERE Folio = ' + folio);

    var _Query = "Exec uspGeneraCotizacion " +
        "@Usuario= " + usuario +
        ",	@Cliente= " + cliente + 
        ",	@Matricula= '" + matricula + "'" +
        ",	@Modelo= " + modelo +
        ",	@Contacto= '" + contacto + "'"

    var id = EvaluaQuery(_Query);
    
    return id
}

//Termina Funcionar para Agregar a cotización 