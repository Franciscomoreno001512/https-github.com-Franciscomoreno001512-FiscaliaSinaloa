var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {



















































































































































//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MROrder=ReplaceQuery("Modulo_Atencion_Inicial.Clave DESC");

}
//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None

















































































































































































































































































//BusinessRuleId:4471, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus in (2,4) )");} else {}

}
//BusinessRuleId:4471, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4474, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=3 )");} else {}

}
//BusinessRuleId:4474, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4476, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=6 )");} else {}

}
//BusinessRuleId:4476, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4478, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=7 )");} else {}

}
//BusinessRuleId:4478, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4480, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Expediente_AT from Canalizacion with(nolock) where Expediente_AT = modulo_atencion_inicial.Clave and ResolucionId is null) )");} else {}

}
//BusinessRuleId:4480, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4482, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=9 )");} else {}

}
//BusinessRuleId:4482, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4484, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Expediente_AT from Canalizacion with(nolock) where Expediente_AT = modulo_atencion_inicial.Clave and ResolucionId is not null and ResolucionId in (180000,180100)) )");} else {}

}
//BusinessRuleId:4484, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4486, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=10 )");} else {}

}
//BusinessRuleId:4486, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4488, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=12 )");} else {}

}
//BusinessRuleId:4488, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4491, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '12'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Modulo_Atencion_Inicial from Resolucion_AT with(nolock) where Modulo_Atencion_Inicial = modulo_atencion_inicial.Clave and Estatus = 1) and modulo_atencion_inicial.Region in (select Region from Spartan_User with(nolock) where Id_User = GLOBAL[USERID]) )");} else {}

}
//BusinessRuleId:4491, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4493, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '13'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Modulo_Atencion_Inicial from Resolucion_AT with(nolock) where Modulo_Atencion_Inicial = modulo_atencion_inicial.Clave and Estatus = 3) )");} else {}

}
//BusinessRuleId:4493, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
