var operation = $('#Operation').val();
var nameOfTable = '';
var rowIndex = '';
$(document).ready(function () {
//NEWBUSINESSRULE_NONE//
});
function EjecutarValidacionesAlComienzo() {
    if (operation == 'New') {
        $('#' + nameOfTable + 'Password' + rowIndex).val(EvaluaQuery("select cast((Abs(Checksum(NewId()))%10) as varchar(1)) + "
       + " "
       + "        char(ascii('a')+(Abs(Checksum(NewId()))%25)) +"
       + " "
       + "        char(ascii('A')+(Abs(Checksum(NewId()))%25)) +"
       + " "
       + "        left(newid(),5)", rowIndex, nameOfTable));
    }
//NEWBUSINESSRULE_SCREENOPENING//
}
function EjecutarValidacionesAntesDeGuardar()
{
	var result = true;
//NEWBUSINESSRULE_BEFORESAVING//
    return result;
}
function EjecutarValidacionesDespuesDeGuardar()
{
//NEWBUSINESSRULE_AFTERSAVING//

//INSERTAR RELACIÓN USUARIO - UNIDAD CUANDO EL ROL ES ORIENTADOR O RECEPCIONISTA
if(operation == 'New'){
    if( GetValueByControlType($('#' + nameOfTable + 'Role' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') || 
    GetValueByControlType($('#' + nameOfTable + 'Role' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) 
    {
EvaluaQuery("EXEC sp_RelacionUnidadUsuario GLOBAL[KeyValueInserted]", rowIndex, nameOfTable);} 
else {}
    }
    if(operation == 'Update'){
        if( GetValueByControlType($('#' + nameOfTable + 'Role' + rowIndex),nameOfTable,rowIndex)==TryParseInt('4', '4') || 
        GetValueByControlType($('#' + nameOfTable + 'Role' + rowIndex),nameOfTable,rowIndex)==TryParseInt('5', '5') ) 
        {
    EvaluaQuery("EXEC sp_UpdRelacionUnidadUsuario FLDD[lblId_User]", rowIndex, nameOfTable);} 
    else {}
        }

}



