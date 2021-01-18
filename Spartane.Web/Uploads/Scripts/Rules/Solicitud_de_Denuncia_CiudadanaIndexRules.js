var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {



















//BusinessRuleId:3145, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 1 )");} else {}

}
//BusinessRuleId:3145, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3147, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 2 )");} else {}

}
//BusinessRuleId:3147, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3149, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 3 )");} else {}

}
//BusinessRuleId:3149, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3151, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 4 )");} else {}

}
//BusinessRuleId:3151, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:3341, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('108', '108') ) { MRWhere=ReplaceQuery("Solicitud_de_Denuncia_Ciudadana.Usuario_que_Registra = GLOBAL[USERID]");} else {}

}
//BusinessRuleId:3341, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
