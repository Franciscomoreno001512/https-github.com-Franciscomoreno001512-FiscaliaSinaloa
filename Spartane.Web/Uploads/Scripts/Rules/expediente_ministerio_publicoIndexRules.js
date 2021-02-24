var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {































































































































































//BusinessRuleId:4060, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 2 and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4060, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4062, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 3 and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4062, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4064, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 4 and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4064, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4066, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 5 and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4066, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4068, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 6 and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4068, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4070, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.estatus = 7 and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4070, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4072, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.Clave in (select Expediente_MP from Resolucion_MP where Expediente_MP = expediente_ministerio_publico.Clave and Estatus = 1 ) and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) or (GLOBAL[USERROLEID] = 107 and expediente_ministerio_publico.Region = (select Region from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4072, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4074, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( expediente_ministerio_publico.Clave in (select Expediente_MP from Resolucion_MP where Expediente_MP = expediente_ministerio_publico.Clave and Estatus = 3 ) and ((GLOBAL[USERROLEID] = 9 and expediente_ministerio_publico.mp_asignado = GLOBAL[USERID]) or (GLOBAL[USERROLEID] = 17 and expediente_ministerio_publico.unidad = (select unidad from spartan_user with(nolock) where id_user = GLOBAL[USERID])) or (GLOBAL[USERROLEID] = 107 and expediente_ministerio_publico.Region = (select Region from spartan_user with(nolock) where id_user = GLOBAL[USERID]))) )");} else {}

}
//BusinessRuleId:4074, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
