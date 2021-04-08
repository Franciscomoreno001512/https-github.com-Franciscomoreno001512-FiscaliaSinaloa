var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {



















































































































































//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MROrder=ReplaceQuery("Modulo_Atencion_Inicial.Clave DESC");

}
//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None







































































































































































































































































































































//BusinessRuleId:4824, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus in (2,4) )");} else {}

}
//BusinessRuleId:4824, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4827, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=3 )");} else {}

}
//BusinessRuleId:4827, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4829, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Expediente_AT from Canalizacion with(nolock) where Expediente_AT = modulo_atencion_inicial.Clave and ResolucionId is null) )");} else {}

}
//BusinessRuleId:4829, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4831, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=9 )");} else {}

}
//BusinessRuleId:4831, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4833, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Expediente_AT from Canalizacion with(nolock) where Expediente_AT = modulo_atencion_inicial.Clave and ResolucionId is not null and ResolucionId in (180000,180100)) )");} else {}

}
//BusinessRuleId:4833, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4835, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=10 )");} else {}

}
//BusinessRuleId:4835, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4838, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '12'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Modulo_Atencion_Inicial from Resolucion_AT with(nolock) where Modulo_Atencion_Inicial = modulo_atencion_inicial.Clave and Estatus = 1) and modulo_atencion_inicial.Region in (select Region from Spartan_User with(nolock) where Id_User = GLOBAL[USERID]) )");} else {}

}
//BusinessRuleId:4838, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4840, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '13'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.Clave in (select Modulo_Atencion_Inicial from Resolucion_AT with(nolock) where Modulo_Atencion_Inicial = modulo_atencion_inicial.Clave and Estatus = 3) )");} else {}

}
//BusinessRuleId:4840, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
