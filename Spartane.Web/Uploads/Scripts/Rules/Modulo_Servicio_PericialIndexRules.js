var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {





























//BusinessRuleId:3458, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Modulo_Servicio_Pericial.Estatus=1 )");} else {}

}
//BusinessRuleId:3458, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3460, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Modulo_Servicio_Pericial.Estatus=2 )");} else {}

}
//BusinessRuleId:3460, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3462, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Modulo_Servicio_Pericial.Estatus = 3 AND Modulo_Servicio_Pericial.Usuario_Asignado = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:3462, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
