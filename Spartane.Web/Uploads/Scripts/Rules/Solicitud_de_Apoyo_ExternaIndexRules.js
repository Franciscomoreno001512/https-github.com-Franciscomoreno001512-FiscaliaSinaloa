var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {





//BusinessRuleId:4683, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Apoyo_Externa.Folio in (SELECT FOLIO FROM Solicitud_de_Apoyo_Externa WHERE ESTATUS = 1 AND REGION = (SELECT REGION FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:4683, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4685, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( Solicitud_de_Apoyo_Externa.Folio in (SELECT FOLIO FROM Solicitud_de_Apoyo_Externa WHERE ESTATUS = 2 AND REGION = (SELECT REGION FROM SPARTAN_USER WHERE ID_USER = GLOBAL[USERID])) )");} else {}

}
//BusinessRuleId:4685, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4861, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MROrder=ReplaceQuery("Solicitud_de_Apoyo_Externa.Folio Desc");

}
//BusinessRuleId:4861, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
