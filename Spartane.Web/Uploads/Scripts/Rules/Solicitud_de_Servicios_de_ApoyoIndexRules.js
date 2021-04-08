var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function() {



























    

    

    

    

    

    

    //BusinessRuleId:4865, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MROrder=ReplaceQuery("Solicitud_de_Servicios_de_Apoyo.Folio desc");

}
//BusinessRuleId:4865, Attribute:3, Operation:Object, Event:None

























//BusinessRuleId:4893, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '1'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],1)) )");} else {}

}
//BusinessRuleId:4893, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4895, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '2'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],2)) )");} else {}

}
//BusinessRuleId:4895, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4897, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '3'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],3)) )");} else {}

}
//BusinessRuleId:4897, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4899, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '4'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],4)) )");} else {}

}
//BusinessRuleId:4899, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4901, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '5'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],5)) )");} else {}

}
//BusinessRuleId:4901, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4903, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '6'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],6)) )");} else {}

}
//BusinessRuleId:4903, Attribute:3, Operation:Object, Event:None

//BusinessRuleId:4905, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( EvaluaQuery("Select 'GLOBAL[Phase]'",rowIndex, nameOfTable)==EvaluaQuery("Select '7'",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery(" ( solicitud_de_servicios_de_apoyo.folio in (select folio from dbo.ufncFiltroServiciosApoyo(GLOBAL[USERROLEID],GLOBAL[USERID],7)) )");} else {}

}
//BusinessRuleId:4905, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista() {
    //NEWBUSINESSRULE_AFTERCREATIONLIST//
}