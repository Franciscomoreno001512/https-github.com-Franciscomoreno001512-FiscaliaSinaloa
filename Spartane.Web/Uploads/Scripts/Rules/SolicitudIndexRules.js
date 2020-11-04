var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {





















































































//BusinessRuleId:1869, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=1 )");} else {}

}
//BusinessRuleId:1869, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1871, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=91 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:1871, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1873, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=92 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:1873, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1875, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=93 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:1875, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1877, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=94 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación')  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1877, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1879, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=95 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación')  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1879, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1881, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=96 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación')  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1881, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1883, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=97 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.Personal_de_Seguimiento_Asignado = GLOBAL[USERID])  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1883, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1885, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=98 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.Personal_de_Seguimiento_Asignado = GLOBAL[USERID])  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1885, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1887, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=99 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.Personal_de_Seguimiento_Asignado = GLOBAL[USERID])  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1887, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:1889, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=100 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.Personal_de_Seguimiento_Asignado = GLOBAL[USERID])  or (GLOBAL[USERROLEID]<>3)) )");} else {}

}
//BusinessRuleId:1889, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
