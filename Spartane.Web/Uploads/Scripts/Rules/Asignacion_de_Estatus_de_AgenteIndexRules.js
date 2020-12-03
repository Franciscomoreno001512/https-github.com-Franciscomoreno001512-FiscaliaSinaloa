var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {





//BusinessRuleId:2718, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
 MRWhere=ReplaceQuery("Asignacion_de_Estatus_de_Agente.Unidad=(select unidad from Spartan_USer where Id_User=GLOBAL[USERID])");

}
//BusinessRuleId:2718, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
