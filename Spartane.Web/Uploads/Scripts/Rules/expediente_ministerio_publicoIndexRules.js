var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {







//BusinessRuleId:2851, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 2 and ((GLOBAL[USERROLEID) = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID) = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:2851, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2853, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 3 and ((GLOBAL[USERROLEID) = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID) = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:2853, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2855, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 4 and ((GLOBAL[USERROLEID) = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID) = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:2855, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2857, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 5 and ((GLOBAL[USERROLEID) = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID) = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:2857, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2859, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 6 and ((GLOBAL[USERROLEID) = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID) = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:2859, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2861, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 7 and ((GLOBAL[USERROLEID) = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID) = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:2861, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
