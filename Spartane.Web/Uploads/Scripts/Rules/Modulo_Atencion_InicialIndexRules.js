var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {



















































































































































//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MROrder=ReplaceQuery("Modulo_Atencion_Inicial.Clave DESC");

}
//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None





































//BusinessRuleId:3862, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus in (2,4) )");} else {}

}
//BusinessRuleId:3862, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3865, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=3 )");} else {}

}
//BusinessRuleId:3865, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3867, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=6 )");} else {}

}
//BusinessRuleId:3867, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3869, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=7 )");} else {}

}
//BusinessRuleId:3869, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3871, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=8 )");} else {}

}
//BusinessRuleId:3871, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3873, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=9 )");} else {}

}
//BusinessRuleId:3873, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3875, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=11 )");} else {}

}
//BusinessRuleId:3875, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3877, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=10 )");} else {}

}
//BusinessRuleId:3877, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3879, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=12 )");} else {}

}
//BusinessRuleId:3879, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
