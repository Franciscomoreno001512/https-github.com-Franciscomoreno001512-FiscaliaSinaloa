var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {





//BusinessRuleId:2627, Attribute:3, Operation:Object, Event:None
if(operation == 'List'){
if( TryParseInt('17', '17')==EvaluaQuery("SELECT GLOBAL[USERROLEID]",rowIndex, nameOfTable) ) { MRWhere=ReplaceQuery("unidad.clave = (select unidad from spartan_user where id_user = GLOBAL[USERID])");} else {}

}
//BusinessRuleId:2627, Attribute:3, Operation:Object, Event:None

//NEWBUSINESSRULE_BEFORECREATIONLIST//
});

function EjecutarValidacionesDespuesDeCrearLista()
{
//NEWBUSINESSRULE_AFTERCREATIONLIST//
}
