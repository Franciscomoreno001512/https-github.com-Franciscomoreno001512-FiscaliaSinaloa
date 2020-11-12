var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {

































































































































































































































































































































//BusinessRuleId:2396, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=1 )");} else {}

}
//BusinessRuleId:2396, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2398, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=91 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:2398, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2400, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=92 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:2400, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2402, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=93 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:2402, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2404, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=94 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación') or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2404, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2406, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=95 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación')  or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2406, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2408, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=96 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación') or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2408, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2410, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=97 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2410, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2412, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=98 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2412, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2414, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=99 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2414, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2416, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=100 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2416, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2418, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '12'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=101 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2418, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:2420, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '13'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=102 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:2420, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
