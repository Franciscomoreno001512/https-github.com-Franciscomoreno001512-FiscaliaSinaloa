var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {







//BusinessRuleId:2189, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Notificacion.Estatus = 1 )");} else {}

}
//BusinessRuleId:2189, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2191, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Notificacion.Estatus = 2 )");} else {}

}
//BusinessRuleId:2191, Attribute:3, Operation:Object, Event:None





//BusinessRuleId:2204, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Notificacion.Estatus = 1 )");} else {}

}
//BusinessRuleId:2204, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2206, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Notificacion.Estatus = 2 )");} else {}

}
//BusinessRuleId:2206, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
