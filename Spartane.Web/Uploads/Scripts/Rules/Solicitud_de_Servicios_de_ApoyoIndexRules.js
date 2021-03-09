var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {



























//BusinessRuleId:4433, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],1)) )");} else {}

}
//BusinessRuleId:4433, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4435, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],2)) )");} else {}

}
//BusinessRuleId:4435, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4437, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],3)) )");} else {}

}
//BusinessRuleId:4437, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4439, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],4)) )");} else {}

}
//BusinessRuleId:4439, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4441, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],5)) )");} else {}

}
//BusinessRuleId:4441, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4443, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Servicios_de_Apoyo.Estatus = solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],6)) )");} else {}

}
//BusinessRuleId:4443, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
