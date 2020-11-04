var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {

































































































































//BusinessRuleId:1838, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus in (2,4) )");} else {}

}
//BusinessRuleId:1838, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1841, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=3 )");} else {}

}
//BusinessRuleId:1841, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1843, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=6 )");} else {}

}
//BusinessRuleId:1843, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1845, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=7 )");} else {}

}
//BusinessRuleId:1845, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1847, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=8 )");} else {}

}
//BusinessRuleId:1847, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1849, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=9 )");} else {}

}
//BusinessRuleId:1849, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1851, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=11 )");} else {}

}
//BusinessRuleId:1851, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1853, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=10 )");} else {}

}
//BusinessRuleId:1853, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1855, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( modulo_atencion_inicial.estatus=12 )");} else {}

}
//BusinessRuleId:1855, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MROrder=ReplaceQuery("Modulo_Atencion_Inicial.Clave DESC");

}
//BusinessRuleId:2036, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
