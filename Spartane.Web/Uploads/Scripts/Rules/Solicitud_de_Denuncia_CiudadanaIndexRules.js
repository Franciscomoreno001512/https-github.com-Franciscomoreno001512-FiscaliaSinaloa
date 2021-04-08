var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {



























//BusinessRuleId:3341, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( TryParseInt(ReplaceGLOBAL('GLOBAL[USERROLEID]'), ReplaceGLOBAL('GLOBAL[USERROLEID]'))==TryParseInt('108', '108') ) { MRWhere=ReplaceQuery("Solicitud_de_Denuncia_Ciudadana.Usuario_que_Registra = GLOBAL[USERID]");} else {}

}
//BusinessRuleId:3341, Attribute:3, Operation:Object, Event:None































































































//BusinessRuleId:4781, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 1 )");} else {}

}
//BusinessRuleId:4781, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4783, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.Clave IN (SELECT Clave FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE ESTATUS_DE_SOLICITUD = 2  AND (Unidad_canaliza = (SELECT UNIDAD FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID])  OR (SELECT ROLE FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]) = 109)) )");} else {}

}
//BusinessRuleId:4783, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4785, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.Clave IN (SELECT Clave FROM SOLICITUD_DE_DENUNCIA_CIUDADANA WHERE ESTATUS_DE_SOLICITUD = 3      AND (Responsable_Asignado = (SELECT ID_User FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID])      OR (SELECT ROLE FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID]) = 109)) )");} else {}

}
//BusinessRuleId:4785, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4787, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 4 )");} else {}

}
//BusinessRuleId:4787, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4789, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( SOLICITUD_DE_DENUNCIA_CIUDADANA.ESTATUS_DE_SOLICITUD = 5 )");} else {}

}
//BusinessRuleId:4789, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
