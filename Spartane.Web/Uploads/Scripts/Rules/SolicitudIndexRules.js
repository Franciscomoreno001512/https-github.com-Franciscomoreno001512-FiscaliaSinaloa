var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {































































































































































































































































































































































































































































































































































































































//BusinessRuleId:3796, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=1 and Unidad_MASC = (select unidad from Spartan_User with(nolock) where Id_User=GLOBAL[USERID]) )");} else {}

}
//BusinessRuleId:3796, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3798, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=91 and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:3798, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3800, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=92) and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:3800, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3802, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=93) and solicitud.Especialista_AsignadoA = GLOBAL[USERID] )");} else {}

}
//BusinessRuleId:3802, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3804, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=94)  and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación') or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3804, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3806, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=95) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación') or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3806, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3808, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=96) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Atención Temprana') or (GLOBAL[USERROLEID]<> 3 and solicitud.remitente='Unidad de Investigación') or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3808, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3810, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '8'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=97) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3810, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3812, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '9'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=98) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3812, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3814, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '10'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.estatus=99 and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3814, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3816, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '11'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=100) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3816, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3818, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '12'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=101) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3818, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3820, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '13'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud.clave in (select Numero_de_Expediente from relaciones_masc with(nolock) where Numero_de_Expediente=solicitud.Clave and estatus=102) and ((GLOBAL[USERROLEID]= 3 and solicitud.Especialista_AsignadoA = GLOBAL[USERID]) or (GLOBAL[USERROLEID]= 103 and solicitud.clave in (select numero_de_expediente from acuerdos_masc with(nolock) where Personal_de_Seguimiento_Asignado = GLOBAL[USERID] and numero_de_expediente is not null)) or (GLOBAL[USERROLEID] not in (3,103,105))) )");} else {}

}
//BusinessRuleId:3820, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
