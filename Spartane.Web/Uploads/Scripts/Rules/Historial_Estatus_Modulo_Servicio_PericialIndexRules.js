var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {





















//BusinessRuleId:3527, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Historial_Estatus_Modulo_Servicio_Pericial.Estatus_Servicio_Pericial=1 )");} else {}

}
//BusinessRuleId:3527, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3529, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Historial_Estatus_Modulo_Servicio_Pericial.Estatus_Servicio_Pericial=2 )");} else {}

}
//BusinessRuleId:3529, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3531, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Historial_Estatus_Modulo_Servicio_Pericial.Estatus_Servicio_Pericial = 3 AND Historial_Estatus_Modulo_Servicio_Pericial.Modulo_Servicio_Pericial IN (SELECT Clave FROM dbo.Modulo_Servicio_Pericial WHERE Usuario_Asignado = GLOBAL[USERID]) )");} else {}

}
//BusinessRuleId:3531, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
