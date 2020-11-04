

//Begin Declarations for Foreigns fields for Spartan_RDM_Filters_Detail MultiRow
var Spartan_RDM_Filters_DetailcountRowsChecked = 0;

function GetSpartan_RDM_Filters_Detail_Spartan_Attribute_BypassName(Id) {
    for (var i = 0; i < Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems.length; i++) {
        if (Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems[i].AttributeId == Id) {
            return Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems[i].Description;
        }
    }
    return "";
}

function GetSpartan_RDM_Filters_Detail_Spartan_Attribute_BypassDropDown() {
    var Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassDropdown = $('<select class="form-control" />');      var labelSelect = $("#Spartan_RDM_Filters_Detail_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassDropdown);
    if(Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems != null)
    {
       for (var i = 0; i < Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems.length; i++) {
           $('<option />', { value: Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems[i].AttributeId, text:    Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassItems[i].Description }).appendTo(Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassDropdown);
       }
    }
    return Spartan_RDM_Filters_Detail_Spartan_Attribute_BypassDropdown;
}







function GetInsertSpartan_RDM_Filters_DetailRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetSpartan_RDM_Filters_Detail_Spartan_Attribute_BypassDropDown()).addClass('Spartan_RDM_Filters_Detail_Field_Name Field_Name').attr('id', 'Spartan_RDM_Filters_Detail_Field_Name_' + index).attr('data-field', 'Field_Name').after($.parseHTML(addNew('Spartan_RDM_Filters_Detail', 'Spartan_Attribute_Bypass', 'Field_Name', 266251)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Filters_Detail_Field_Label Field_Label').attr('id', 'Spartan_RDM_Filters_Detail_Field_Label_' + index).attr('data-field', 'Field_Label');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Spartan_RDM_Filters_Detail_Order_Shown Order_Shown').attr('id', 'Spartan_RDM_Filters_Detail_Order_Shown_' + index).attr('data-field', 'Order_Shown');
    columnData[3] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Filters_Detail_Field_Path Field_Path').attr('id', 'Spartan_RDM_Filters_Detail_Field_Path_' + index).attr('data-field', 'Field_Path');
    columnData[4] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Filters_Detail_Physical_Field_Name Physical_Field_Name').attr('id', 'Spartan_RDM_Filters_Detail_Physical_Field_Name_' + index).attr('data-field', 'Physical_Field_Name');
    columnData[5] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Filters_Detail_Logical_Field_Name Logical_Field_Name').attr('id', 'Spartan_RDM_Filters_Detail_Logical_Field_Name_' + index).attr('data-field', 'Logical_Field_Name');


    initiateUIControls();
    return columnData;
}

function Spartan_RDM_Filters_DetailInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRSpartan_RDM_Filters_Detail("Spartan_RDM_Filters_Detail_", "_" + rowIndex)) {
    var iPage = Spartan_RDM_Filters_DetailTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Spartan_RDM_Filters_Detail';
    var prevData = Spartan_RDM_Filters_DetailTable.fnGetData(rowIndex);
    var data = Spartan_RDM_Filters_DetailTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        Filters_Detail_Id: prevData.Filters_Detail_Id,
        IsInsertRow: false

        ,Field_Name:  data.childNodes[counter++].childNodes[0].value
        ,Field_Label:  data.childNodes[counter++].childNodes[0].value
        ,Order_Shown: data.childNodes[counter++].childNodes[0].value
        ,Field_Path:  data.childNodes[counter++].childNodes[0].value
        ,Physical_Field_Name:  data.childNodes[counter++].childNodes[0].value
        ,Logical_Field_Name:  data.childNodes[counter++].childNodes[0].value

    }
    Spartan_RDM_Filters_DetailTable.fnUpdate(newData, rowIndex, null, true);
    Spartan_RDM_Filters_DetailrowCreationGrid(data, newData, rowIndex);
    Spartan_RDM_Filters_DetailTable.fnPageChange(iPage);
    Spartan_RDM_Filters_DetailcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRSpartan_RDM_Filters_Detail("Spartan_RDM_Filters_Detail_", "_" + rowIndex);
  }
}

function Spartan_RDM_Filters_DetailCancelRow(rowIndex) {
    var prevData = Spartan_RDM_Filters_DetailTable.fnGetData(rowIndex);
    var data = Spartan_RDM_Filters_DetailTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Spartan_RDM_Filters_DetailTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Spartan_RDM_Filters_DetailrowCreationGrid(data, prevData, rowIndex);
    }
	showSpartan_RDM_Filters_DetailGrid(Spartan_RDM_Filters_DetailTable.fnGetData());
    Spartan_RDM_Filters_DetailcountRowsChecked--;
	initiateUIControls();
}

function GetSpartan_RDM_Filters_DetailFromDataTable() {
    var Spartan_RDM_Filters_DetailData = [];
    var gridData = Spartan_RDM_Filters_DetailTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Spartan_RDM_Filters_DetailData.push({
                Filters_Detail_Id: gridData[i].Filters_Detail_Id

                ,Field_Name: gridData[i].Field_Name
                ,Field_Label: gridData[i].Field_Label
                ,Order_Shown: gridData[i].Order_Shown
                ,Field_Path: gridData[i].Field_Path
                ,Physical_Field_Name: gridData[i].Physical_Field_Name
                ,Logical_Field_Name: gridData[i].Logical_Field_Name

                ,Removed: false
            });
    }

    for (i = 0; i < removedSpartan_RDM_Filters_DetailData.length; i++) {
        if (removedSpartan_RDM_Filters_DetailData[i] != null && removedSpartan_RDM_Filters_DetailData[i].Filters_Detail_Id > 0)
            Spartan_RDM_Filters_DetailData.push({
                Filters_Detail_Id: removedSpartan_RDM_Filters_DetailData[i].Filters_Detail_Id

                ,Field_Name: removedSpartan_RDM_Filters_DetailData[i].Field_Name
                ,Field_Label: removedSpartan_RDM_Filters_DetailData[i].Field_Label
                ,Order_Shown: removedSpartan_RDM_Filters_DetailData[i].Order_Shown
                ,Field_Path: removedSpartan_RDM_Filters_DetailData[i].Field_Path
                ,Physical_Field_Name: removedSpartan_RDM_Filters_DetailData[i].Physical_Field_Name
                ,Logical_Field_Name: removedSpartan_RDM_Filters_DetailData[i].Logical_Field_Name

                , Removed: true
            });
    }	

    return Spartan_RDM_Filters_DetailData;
}

function Spartan_RDM_Filters_DetailEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Spartan_RDM_Filters_DetailTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Spartan_RDM_Filters_DetailcountRowsChecked++;
    var Spartan_RDM_Filters_DetailRowElement = "Spartan_RDM_Filters_Detail_" + rowIndex.toString();
    var prevData = Spartan_RDM_Filters_DetailTable.fnGetData(rowIndexTable );
    var row = Spartan_RDM_Filters_DetailTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Spartan_RDM_Filters_Detail_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Spartan_RDM_Filters_DetailGetUpdateRowControls(prevData, "Spartan_RDM_Filters_Detail_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Spartan_RDM_Filters_DetailRowElement + "')){ Spartan_RDM_Filters_DetailInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Spartan_RDM_Filters_DetailCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Spartan_RDM_Filters_DetailGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Spartan_RDM_Filters_DetailGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setSpartan_RDM_Filters_DetailValidation();
    initiateUIControls();
    $('.Spartan_RDM_Filters_Detail' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRSpartan_RDM_Filters_Detail(nameOfTable, rowIndexFormed);
    }
}

function Spartan_RDM_Filters_DetailfnOpenAddRowPopUp() {
    var currentRowIndex = Spartan_RDM_Filters_DetailTable.fnGetData().length;
    Spartan_RDM_Filters_DetailfnClickAddRow();
    GetAddSpartan_RDM_Filters_DetailPopup(currentRowIndex, 0);
}

function Spartan_RDM_Filters_DetailEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Spartan_RDM_Filters_DetailTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Spartan_RDM_Filters_DetailRowElement = "Spartan_RDM_Filters_Detail_" + rowIndex.toString();
    var prevData = Spartan_RDM_Filters_DetailTable.fnGetData(rowIndexTable);
    GetAddSpartan_RDM_Filters_DetailPopup(rowIndex, 1, prevData.Filters_Detail_Id);

    $('#Spartan_RDM_Filters_DetailField_Name').val(prevData.Field_Name);
    $('#Spartan_RDM_Filters_DetailField_Label').val(prevData.Field_Label);
    $('#Spartan_RDM_Filters_DetailOrder_Shown').val(prevData.Order_Shown);
    $('#Spartan_RDM_Filters_DetailField_Path').val(prevData.Field_Path);
    $('#Spartan_RDM_Filters_DetailPhysical_Field_Name').val(prevData.Physical_Field_Name);
    $('#Spartan_RDM_Filters_DetailLogical_Field_Name').val(prevData.Logical_Field_Name);

    initiateUIControls();








}

function Spartan_RDM_Filters_DetailAddInsertRow() {
    if (Spartan_RDM_Filters_DetailinsertRowCurrentIndex < 1)
    {
        Spartan_RDM_Filters_DetailinsertRowCurrentIndex = 1;
    }
    return {
        Filters_Detail_Id: null,
        IsInsertRow: true

        ,Field_Name: ""
        ,Field_Label: ""
        ,Order_Shown: ""
        ,Field_Path: ""
        ,Physical_Field_Name: ""
        ,Logical_Field_Name: ""

    }
}

function Spartan_RDM_Filters_DetailfnClickAddRow() {
    Spartan_RDM_Filters_DetailcountRowsChecked++;
    Spartan_RDM_Filters_DetailTable.fnAddData(Spartan_RDM_Filters_DetailAddInsertRow(), true);
    Spartan_RDM_Filters_DetailTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Spartan_RDM_Filters_DetailGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Spartan_RDM_Filters_DetailGrid tbody tr:nth-of-type(' + (Spartan_RDM_Filters_DetailinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRSpartan_RDM_Filters_Detail("Spartan_RDM_Filters_Detail_", "_" + Spartan_RDM_Filters_DetailinsertRowCurrentIndex);
}

function Spartan_RDM_Filters_DetailClearGridData() {
    Spartan_RDM_Filters_DetailData = [];
    Spartan_RDM_Filters_DetaildeletedItem = [];
    Spartan_RDM_Filters_DetailDataMain = [];
    Spartan_RDM_Filters_DetailDataMainPages = [];
    Spartan_RDM_Filters_DetailnewItemCount = 0;
    Spartan_RDM_Filters_DetailmaxItemIndex = 0;
    $("#Spartan_RDM_Filters_DetailGrid").DataTable().clear();
    $("#Spartan_RDM_Filters_DetailGrid").DataTable().destroy();
}

//Used to Get Editor de Gestión Detallada de Registros Information
function GetSpartan_RDM_Filters_Detail() {
    var form_data = new FormData();
    for (var i = 0; i < Spartan_RDM_Filters_DetailData.length; i++) {
        form_data.append('[' + i + '].Filters_Detail_Id', Spartan_RDM_Filters_DetailData[i].Filters_Detail_Id);

        form_data.append('[' + i + '].Field_Name', Spartan_RDM_Filters_DetailData[i].Field_Name);
        form_data.append('[' + i + '].Field_Label', Spartan_RDM_Filters_DetailData[i].Field_Label);
        form_data.append('[' + i + '].Order_Shown', Spartan_RDM_Filters_DetailData[i].Order_Shown);
        form_data.append('[' + i + '].Field_Path', Spartan_RDM_Filters_DetailData[i].Field_Path);
        form_data.append('[' + i + '].Physical_Field_Name', Spartan_RDM_Filters_DetailData[i].Physical_Field_Name);
        form_data.append('[' + i + '].Logical_Field_Name', Spartan_RDM_Filters_DetailData[i].Logical_Field_Name);

        form_data.append('[' + i + '].Removed', Spartan_RDM_Filters_DetailData[i].Removed);
    }
    return form_data;
}
function Spartan_RDM_Filters_DetailInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRSpartan_RDM_Filters_Detail("Spartan_RDM_Filters_DetailTable", rowIndex)) {
    var prevData = Spartan_RDM_Filters_DetailTable.fnGetData(rowIndex);
    var data = Spartan_RDM_Filters_DetailTable.fnGetNodes(rowIndex);
    var newData = {
        Filters_Detail_Id: prevData.Filters_Detail_Id,
        IsInsertRow: false

        ,Field_Name: $('#Spartan_RDM_Filters_DetailField_Name').val()
        ,Field_Label: $('#Spartan_RDM_Filters_DetailField_Label').val()
        ,Order_Shown: $('#Spartan_RDM_Filters_DetailOrder_Shown').val()

        ,Field_Path: $('#Spartan_RDM_Filters_DetailField_Path').val()
        ,Physical_Field_Name: $('#Spartan_RDM_Filters_DetailPhysical_Field_Name').val()
        ,Logical_Field_Name: $('#Spartan_RDM_Filters_DetailLogical_Field_Name').val()

    }

    Spartan_RDM_Filters_DetailTable.fnUpdate(newData, rowIndex, null, true);
    Spartan_RDM_Filters_DetailrowCreationGrid(data, newData, rowIndex);
    $('#AddSpartan_RDM_Filters_Detail-form').modal({ show: false });
    $('#AddSpartan_RDM_Filters_Detail-form').modal('hide');
    Spartan_RDM_Filters_DetailEditRow(rowIndex);
    Spartan_RDM_Filters_DetailInsertRow(rowIndex);
    //}
}
function Spartan_RDM_Filters_DetailRemoveAddRow(rowIndex) {
    Spartan_RDM_Filters_DetailTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Spartan_RDM_Filters_Detail MultiRow
//Begin Declarations for Foreigns fields for Spartan_RDM_Operations_Detail MultiRow
var Spartan_RDM_Operations_DetailcountRowsChecked = 0;

function GetSpartan_RDM_Operations_Detail_Spartan_Object_ByPassName(Id) {
    for (var i = 0; i < Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems.length; i++) {
        if (Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems[i].ObjectId == Id) {
            return Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems[i].Description;
        }
    }
    return "";
}

function GetSpartan_RDM_Operations_Detail_Spartan_Object_ByPassDropDown() {
    var Spartan_RDM_Operations_Detail_Spartan_Object_ByPassDropdown = $('<select class="form-control" />');      var labelSelect = $("#Spartan_RDM_Operations_Detail_cmbLabelSelect").val();

    $('<option />', { value: '', text: labelSelect }).appendTo(Spartan_RDM_Operations_Detail_Spartan_Object_ByPassDropdown);
    if(Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems != null)
    {
       for (var i = 0; i < Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems.length; i++) {
           $('<option />', { value: Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems[i].ObjectId, text:    Spartan_RDM_Operations_Detail_Spartan_Object_ByPassItems[i].Description }).appendTo(Spartan_RDM_Operations_Detail_Spartan_Object_ByPassDropdown);
       }
    }
    return Spartan_RDM_Operations_Detail_Spartan_Object_ByPassDropdown;
}







function GetInsertSpartan_RDM_Operations_DetailRowControls(index) {
    var columnData = [];
    var inputData = "<input type='text' class='fullWidth form-control'/>";

    columnData[0] = $(GetSpartan_RDM_Operations_Detail_Spartan_Object_ByPassDropDown()).addClass('Spartan_RDM_Operations_Detail_Object_Name Object_Name').attr('id', 'Spartan_RDM_Operations_Detail_Object_Name_' + index).attr('data-field', 'Object_Name').after($.parseHTML(addNew('Spartan_RDM_Operations_Detail', 'Spartan_Object_ByPass', 'Object_Name', 266259)));
    columnData[1] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Operations_Detail_Object_Label Object_Label').attr('id', 'Spartan_RDM_Operations_Detail_Object_Label_' + index).attr('data-field', 'Object_Label');
    columnData[2] = $($.parseHTML("<input type='text' class='fullWidth form-control inputNumber'/>")).addClass('Spartan_RDM_Operations_Detail_Order_Shown Order_Shown').attr('id', 'Spartan_RDM_Operations_Detail_Order_Shown_' + index).attr('data-field', 'Order_Shown');
    columnData[3] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Operations_Detail_Count_Query Count_Query').attr('id', 'Spartan_RDM_Operations_Detail_Count_Query_' + index).attr('data-field', 'Count_Query');
    columnData[4] = $($.parseHTML(inputData)).addClass('Spartan_RDM_Operations_Detail_Query_Data Query_Data').attr('id', 'Spartan_RDM_Operations_Detail_Query_Data_' + index).attr('data-field', 'Query_Data');
    columnData[5] = $($.parseHTML(GetFileUploader())).addClass('Spartan_RDM_Operations_Detail_Icono_FileUpload Icono').attr('id', 'Spartan_RDM_Operations_Detail_Icono_' + index).attr('data-field', 'Icono');


    initiateUIControls();
    return columnData;
}

function Spartan_RDM_Operations_DetailInsertRow(rowIndex) {
if (EjecutarValidacionesAntesDeGuardarMRSpartan_RDM_Operations_Detail("Spartan_RDM_Operations_Detail_", "_" + rowIndex)) {
    var iPage = Spartan_RDM_Operations_DetailTable.fnPagingInfo().iPage;
    var nameOfGrid = 'Spartan_RDM_Operations_Detail';
    var prevData = Spartan_RDM_Operations_DetailTable.fnGetData(rowIndex);
    var data = Spartan_RDM_Operations_DetailTable.fnGetNodes(rowIndex);
    var counter = 1;
    var newData = {
        DetailId: prevData.DetailId,
        IsInsertRow: false

        ,Object_Name:  data.childNodes[counter++].childNodes[0].value
        ,Object_Label:  data.childNodes[counter++].childNodes[0].value
        ,Order_Shown: data.childNodes[counter++].childNodes[0].value
        ,Count_Query:  data.childNodes[counter++].childNodes[0].value
        ,Query_Data:  data.childNodes[counter++].childNodes[0].value
        ,IconoFileInfo: ($('#' + nameOfGrid + 'Grid .IconoHeader').css('display') != 'none') ? { 
             FileName: prevData.IconoFileInfo != null && prevData.IconoFileInfo.FileName != null && prevData.IconoFileInfo.FileName != ''? prevData.IconoFileInfo.FileName : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : ''),              
			 FileId:   prevData.IconoFileInfo != null && prevData.IconoFileInfo.FileName != null && prevData.IconoFileInfo.FileName != '' ? prevData.IconoFileInfo.FileId :  prevData.IconoFileInfo != null && prevData.IconoFileInfo.FileId != '' && prevData.IconoFileInfo.FileId != undefined ? prevData.IconoFileInfo.FileId : '0',
             FileSize: prevData.IconoFileInfo != null && prevData.IconoFileInfo.FileName != null ? prevData.IconoFileInfo.FileSize : (data.childNodes[counter].childNodes[0].files.length > 0 ? data.childNodes[counter].childNodes[0].files[0].name : '') 
         } : ''
        ,IconoDetail: (data.childNodes[counter] != 'undefined' && data.childNodes[counter].childNodes[0].childNodes.length == 0) ? data.childNodes[counter++].childNodes[0] : prevData.IconoDetail

    }
    Spartan_RDM_Operations_DetailTable.fnUpdate(newData, rowIndex, null, true);
    Spartan_RDM_Operations_DetailrowCreationGrid(data, newData, rowIndex);
    Spartan_RDM_Operations_DetailTable.fnPageChange(iPage);
    Spartan_RDM_Operations_DetailcountRowsChecked--;	
    EjecutarValidacionesDespuesDeGuardarMRSpartan_RDM_Operations_Detail("Spartan_RDM_Operations_Detail_", "_" + rowIndex);
  }
}

function Spartan_RDM_Operations_DetailCancelRow(rowIndex) {
    var prevData = Spartan_RDM_Operations_DetailTable.fnGetData(rowIndex);
    var data = Spartan_RDM_Operations_DetailTable.fnGetNodes(rowIndex);

    if (prevData.IsInsertRow) {
        Spartan_RDM_Operations_DetailTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
            console.log('Row deleted');
        }, true);
    } else {
        Spartan_RDM_Operations_DetailrowCreationGrid(data, prevData, rowIndex);
    }
	showSpartan_RDM_Operations_DetailGrid(Spartan_RDM_Operations_DetailTable.fnGetData());
    Spartan_RDM_Operations_DetailcountRowsChecked--;
	initiateUIControls();
}

function GetSpartan_RDM_Operations_DetailFromDataTable() {
    var Spartan_RDM_Operations_DetailData = [];
    var gridData = Spartan_RDM_Operations_DetailTable.fnGetData();
    //debugger;
    for (var i = 0; i < gridData.length; i++) {
        if (gridData[i].IsInsertRow == null || !gridData[i].IsInsertRow)
            Spartan_RDM_Operations_DetailData.push({
                DetailId: gridData[i].DetailId

                ,Object_Name: gridData[i].Object_Name
                ,Object_Label: gridData[i].Object_Label
                ,Order_Shown: gridData[i].Order_Shown
                ,Count_Query: gridData[i].Count_Query
                ,Query_Data: gridData[i].Query_Data
                ,IconoInfo: {
                    FileName: gridData[i].IconoFileInfo.FileName, FileId: gridData[i].IconoFileInfo.FileId, FileSize: gridData[i].IconoFileInfo.FileSize,
                    Control: gridData[i].IconoDetail != null && gridData[i].IconoDetail.files != null && gridData[i].IconoDetail.files.length > 0 ? gridData[i].IconoDetail.files[0] : null,
                    IconoRemoveFile: gridData[i].IconoDetail != null
                }

                ,Removed: false
            });
    }

    for (i = 0; i < removedSpartan_RDM_Operations_DetailData.length; i++) {
        if (removedSpartan_RDM_Operations_DetailData[i] != null && removedSpartan_RDM_Operations_DetailData[i].DetailId > 0)
            Spartan_RDM_Operations_DetailData.push({
                DetailId: removedSpartan_RDM_Operations_DetailData[i].DetailId

                ,Object_Name: removedSpartan_RDM_Operations_DetailData[i].Object_Name
                ,Object_Label: removedSpartan_RDM_Operations_DetailData[i].Object_Label
                ,Order_Shown: removedSpartan_RDM_Operations_DetailData[i].Order_Shown
                ,Count_Query: removedSpartan_RDM_Operations_DetailData[i].Count_Query
                ,Query_Data: removedSpartan_RDM_Operations_DetailData[i].Query_Data
                ,IconoInfo: {
                    FileName: removedSpartan_RDM_Operations_DetailData[i].IconoFileInfo.FileName, 
                    FileId: removedSpartan_RDM_Operations_DetailData[i].IconoFileInfo.FileId, 
                    FileSize: removedSpartan_RDM_Operations_DetailData[i].IconoFileInfo.FileSize,
                    Control: removedSpartan_RDM_Operations_DetailData[i].IconoDetail != null && removedSpartan_RDM_Operations_DetailData[i].IconoDetail.files.length > 0 ? removedSpartan_RDM_Operations_DetailData[i].IconoDetail.files[0] : null,
                    IconoRemoveFile: removedSpartan_RDM_Operations_DetailData[i].IconoDetail != null
                }

                , Removed: true
            });
    }	

    return Spartan_RDM_Operations_DetailData;
}

function Spartan_RDM_Operations_DetailEditRow(rowIndex, currentRow, executeRules) {
    var rowIndexTable = (currentRow) ? Spartan_RDM_Operations_DetailTable.fnGetPosition($(currentRow).parent().parent()[0]) : rowIndex;
    Spartan_RDM_Operations_DetailcountRowsChecked++;
    var Spartan_RDM_Operations_DetailRowElement = "Spartan_RDM_Operations_Detail_" + rowIndex.toString();
    var prevData = Spartan_RDM_Operations_DetailTable.fnGetData(rowIndexTable );
    var row = Spartan_RDM_Operations_DetailTable.fnGetNodes(rowIndexTable);
    row.innerHTML = "";
    var nameOfTable = "Spartan_RDM_Operations_Detail_";
    var rowIndexFormed = "_" + rowIndex;
    var controls = Spartan_RDM_Operations_DetailGetUpdateRowControls(prevData, "Spartan_RDM_Operations_Detail_", "_" + rowIndex);

    var abc = "if(dynamicFieldValidation('" + Spartan_RDM_Operations_DetailRowElement + "')){ Spartan_RDM_Operations_DetailInsertRow(" + rowIndex + "); }";
    var updateRowClick = '<a  onclick="' + abc + '">';

    var actionColInsert = $('<td>');
    $('<i class="fa fa-check">').appendTo($(updateRowClick).appendTo(actionColInsert));
    $('<i class="fa fa-times">').appendTo($("<a data-toggle='tooltip' title='Cancelar Registro' onclick='Spartan_RDM_Operations_DetailCancelRow(" + rowIndex + ")'>").appendTo(actionColInsert));
    actionColInsert.appendTo(row);

    for (i = 0; i < controls.length; i++) {
        var idHeader = $(controls[i]).data('field') + 'Header';
        if ($(controls[i]).length > 1) {
            idHeader = $($(controls[i])[1]).data('field') + 'Header';
        }
		var classe = ($('#Spartan_RDM_Operations_DetailGrid .' + idHeader).hasClass('dt-right') ? "dt-right" : "") + ($('#Spartan_RDM_Operations_DetailGrid .' + idHeader).css('display') == 'none' ? ' hide' : '' );
		  if ($(controls[i]).next().length > 0) {
		        var div = $(controls[i]).next();
		        $('<td class="' + classe + '">').append($(controls[i])).append(div).appendTo(row);
		    }
		    else
                $(controls[i]).appendTo($('<td class="' + classe +  '" id="td'+nameOfTable+idHeader.replace('Header', '')+rowIndexFormed+'">').appendTo(row));                   
    }
    
    setSpartan_RDM_Operations_DetailValidation();
    initiateUIControls();
    $('.Spartan_RDM_Operations_Detail' + rowIndexFormed + ' .inputMoney').inputmask("currency", { prefix: "", rightAlign: false });
    $('.gridDatePicker').inputmask("99-99-9999", { "placeholder": "dd-mm-yyyy" });
    if(executeRules == null || (executeRules != null && executeRules == true))
    {
         EjecutarValidacionesEditRowMRSpartan_RDM_Operations_Detail(nameOfTable, rowIndexFormed);
    }
}

function Spartan_RDM_Operations_DetailfnOpenAddRowPopUp() {
    var currentRowIndex = Spartan_RDM_Operations_DetailTable.fnGetData().length;
    Spartan_RDM_Operations_DetailfnClickAddRow();
    GetAddSpartan_RDM_Operations_DetailPopup(currentRowIndex, 0);
}

function Spartan_RDM_Operations_DetailEditRowPopup(rowIndex, currentRow) {
    var rowIndexTable = Spartan_RDM_Operations_DetailTable.fnGetPosition($(currentRow).parent().parent()[0]);
    var Spartan_RDM_Operations_DetailRowElement = "Spartan_RDM_Operations_Detail_" + rowIndex.toString();
    var prevData = Spartan_RDM_Operations_DetailTable.fnGetData(rowIndexTable);
    GetAddSpartan_RDM_Operations_DetailPopup(rowIndex, 1, prevData.DetailId);

    $('#Spartan_RDM_Operations_DetailObject_Name').val(prevData.Object_Name);
    $('#Spartan_RDM_Operations_DetailObject_Label').val(prevData.Object_Label);
    $('#Spartan_RDM_Operations_DetailOrder_Shown').val(prevData.Order_Shown);
    $('#Spartan_RDM_Operations_DetailCount_Query').val(prevData.Count_Query);
    $('#Spartan_RDM_Operations_DetailQuery_Data').val(prevData.Query_Data);


    initiateUIControls();






    $('#existingIcono').html(prevData.IconoFileDetail == null && (prevData.IconoFileInfo.FileId == null || prevData.IconoFileInfo.FileId <= 0) ? $.parseHTML(GetFileUploader()) : GetFileInfo(prevData.IconoFileInfo, prevData.IconoFileDetail));

}

function Spartan_RDM_Operations_DetailAddInsertRow() {
    if (Spartan_RDM_Operations_DetailinsertRowCurrentIndex < 1)
    {
        Spartan_RDM_Operations_DetailinsertRowCurrentIndex = 1;
    }
    return {
        DetailId: null,
        IsInsertRow: true

        ,Object_Name: ""
        ,Object_Label: ""
        ,Order_Shown: ""
        ,Count_Query: ""
        ,Query_Data: ""
        ,IconoFileInfo: ""

    }
}

function Spartan_RDM_Operations_DetailfnClickAddRow() {
    Spartan_RDM_Operations_DetailcountRowsChecked++;
    Spartan_RDM_Operations_DetailTable.fnAddData(Spartan_RDM_Operations_DetailAddInsertRow(), true);
    Spartan_RDM_Operations_DetailTable.fnPageChange('last');
    initiateUIControls();
	 //var tag = $('#Spartan_RDM_Operations_DetailGrid tbody tr td .form-control').first().get(0).tagName.toLowerCase();
    //$('#Spartan_RDM_Operations_DetailGrid tbody tr:nth-of-type(' + (Spartan_RDM_Operations_DetailinsertRowCurrentIndex + 1) + ') ' + tag ).focus();
    EjecutarValidacionesNewRowMRSpartan_RDM_Operations_Detail("Spartan_RDM_Operations_Detail_", "_" + Spartan_RDM_Operations_DetailinsertRowCurrentIndex);
}

function Spartan_RDM_Operations_DetailClearGridData() {
    Spartan_RDM_Operations_DetailData = [];
    Spartan_RDM_Operations_DetaildeletedItem = [];
    Spartan_RDM_Operations_DetailDataMain = [];
    Spartan_RDM_Operations_DetailDataMainPages = [];
    Spartan_RDM_Operations_DetailnewItemCount = 0;
    Spartan_RDM_Operations_DetailmaxItemIndex = 0;
    $("#Spartan_RDM_Operations_DetailGrid").DataTable().clear();
    $("#Spartan_RDM_Operations_DetailGrid").DataTable().destroy();
}

//Used to Get Editor de Gestión Detallada de Registros Information
function GetSpartan_RDM_Operations_Detail() {
    var form_data = new FormData();
    for (var i = 0; i < Spartan_RDM_Operations_DetailData.length; i++) {
        form_data.append('[' + i + '].DetailId', Spartan_RDM_Operations_DetailData[i].DetailId);

        form_data.append('[' + i + '].Object_Name', Spartan_RDM_Operations_DetailData[i].Object_Name);
        form_data.append('[' + i + '].Object_Label', Spartan_RDM_Operations_DetailData[i].Object_Label);
        form_data.append('[' + i + '].Order_Shown', Spartan_RDM_Operations_DetailData[i].Order_Shown);
        form_data.append('[' + i + '].Count_Query', Spartan_RDM_Operations_DetailData[i].Count_Query);
        form_data.append('[' + i + '].Query_Data', Spartan_RDM_Operations_DetailData[i].Query_Data);
        form_data.append('[' + i + '].IconoInfo.FileId', Spartan_RDM_Operations_DetailData[i].IconoInfo.FileId);
        form_data.append('[' + i + '].IconoInfo.FileName', Spartan_RDM_Operations_DetailData[i].IconoInfo.FileName);
        form_data.append('[' + i + '].IconoInfo.FileSize', Spartan_RDM_Operations_DetailData[i].IconoInfo.FileSize);
        form_data.append('[' + i + '].IconoInfo.Control', Spartan_RDM_Operations_DetailData[i].IconoInfo.Control);
        form_data.append('[' + i + '].IconoInfo.RemoveFile', Spartan_RDM_Operations_DetailData[i].IconoInfo.ArchivoRemoveFile);

        form_data.append('[' + i + '].Removed', Spartan_RDM_Operations_DetailData[i].Removed);
    }
    return form_data;
}
function Spartan_RDM_Operations_DetailInsertRowFromPopup(rowIndex) {
    //if (EjecutarValidacionesAntesDeGuardarMRSpartan_RDM_Operations_Detail("Spartan_RDM_Operations_DetailTable", rowIndex)) {
    var prevData = Spartan_RDM_Operations_DetailTable.fnGetData(rowIndex);
    var data = Spartan_RDM_Operations_DetailTable.fnGetNodes(rowIndex);
    var newData = {
        DetailId: prevData.DetailId,
        IsInsertRow: false

        ,Object_Name: $('#Spartan_RDM_Operations_DetailObject_Name').val()
        ,Object_Label: $('#Spartan_RDM_Operations_DetailObject_Label').val()
        ,Order_Shown: $('#Spartan_RDM_Operations_DetailOrder_Shown').val()

        ,Count_Query: $('#Spartan_RDM_Operations_DetailCount_Query').val()
        ,Query_Data: $('#Spartan_RDM_Operations_DetailQuery_Data').val()
        ,IconoFileInfo: { IconoFileName: prevData.IconoFileInfo.FileName, IconoFileId: prevData.IconoFileInfo.FileId, IconoFileSize: prevData.IconoFileInfo.FileSize }
        ,IconoFileDetail: $('#Icono').find('label').length == 0 ? $('#IconoFileInfoPop')[0] : prevData.IconoFileDetail

    }

    Spartan_RDM_Operations_DetailTable.fnUpdate(newData, rowIndex, null, true);
    Spartan_RDM_Operations_DetailrowCreationGrid(data, newData, rowIndex);
    $('#AddSpartan_RDM_Operations_Detail-form').modal({ show: false });
    $('#AddSpartan_RDM_Operations_Detail-form').modal('hide');
    Spartan_RDM_Operations_DetailEditRow(rowIndex);
    Spartan_RDM_Operations_DetailInsertRow(rowIndex);
    //}
}
function Spartan_RDM_Operations_DetailRemoveAddRow(rowIndex) {
    Spartan_RDM_Operations_DetailTable.fnDeleteRow(rowIndex, function (dtSettings, row) {
    }, true);
}

//End Declarations for Foreigns fields for Spartan_RDM_Operations_Detail MultiRow


$(function () {
    function Spartan_RDM_Filters_DetailinitializeMainArray(totalCount) {
        if (Spartan_RDM_Filters_DetailDataMain.length != totalCount && !Spartan_RDM_Filters_DetailDataMainInitialized) {
            Spartan_RDM_Filters_DetailDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Spartan_RDM_Filters_DetailDataMain[i] = null;
            }
        }
    }
    function Spartan_RDM_Filters_DetailremoveFromMainArray() {
        for (var j = 0; j < Spartan_RDM_Filters_DetaildeletedItem.length; j++) {
            for (var i = 0; i < Spartan_RDM_Filters_DetailDataMain.length; i++) {
                if (Spartan_RDM_Filters_DetailDataMain[i] != null && Spartan_RDM_Filters_DetailDataMain[i].Id == Spartan_RDM_Filters_DetaildeletedItem[j]) {
                    hSpartan_RDM_Filters_DetailDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Spartan_RDM_Filters_DetailcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Spartan_RDM_Filters_DetailDataMain.length; i++) {
            data[i] = Spartan_RDM_Filters_DetailDataMain[i];

        }
        return data;
    }
    function Spartan_RDM_Filters_DetailgetNewResult() {
        var newData = copyMainSpartan_RDM_Filters_DetailArray();

        for (var i = 0; i < Spartan_RDM_Filters_DetailData.length; i++) {
            if (Spartan_RDM_Filters_DetailData[i].Removed == null || Spartan_RDM_Filters_DetailData[i].Removed == false) {
                newData.splice(0, 0, Spartan_RDM_Filters_DetailData[i]);
            }
        }
        return newData;
    }
    function Spartan_RDM_Filters_DetailpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Spartan_RDM_Filters_DetailDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Spartan_RDM_Filters_DetailDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }
    function Spartan_RDM_Operations_DetailinitializeMainArray(totalCount) {
        if (Spartan_RDM_Operations_DetailDataMain.length != totalCount && !Spartan_RDM_Operations_DetailDataMainInitialized) {
            Spartan_RDM_Operations_DetailDataMainInitialized = true;
            for (var i = 0; i < totalCount; i++) {
                Spartan_RDM_Operations_DetailDataMain[i] = null;
            }
        }
    }
    function Spartan_RDM_Operations_DetailremoveFromMainArray() {
        for (var j = 0; j < Spartan_RDM_Operations_DetaildeletedItem.length; j++) {
            for (var i = 0; i < Spartan_RDM_Operations_DetailDataMain.length; i++) {
                if (Spartan_RDM_Operations_DetailDataMain[i] != null && Spartan_RDM_Operations_DetailDataMain[i].Id == Spartan_RDM_Operations_DetaildeletedItem[j]) {
                    hSpartan_RDM_Operations_DetailDataMain.splice(i, 1);
                    break;
                }
            }
        }
    }
    function Spartan_RDM_Operations_DetailcopyMainHistoryArray() {
        var data = [];
        for (var i = 0; i < Spartan_RDM_Operations_DetailDataMain.length; i++) {
            data[i] = Spartan_RDM_Operations_DetailDataMain[i];

        }
        return data;
    }
    function Spartan_RDM_Operations_DetailgetNewResult() {
        var newData = copyMainSpartan_RDM_Operations_DetailArray();

        for (var i = 0; i < Spartan_RDM_Operations_DetailData.length; i++) {
            if (Spartan_RDM_Operations_DetailData[i].Removed == null || Spartan_RDM_Operations_DetailData[i].Removed == false) {
                newData.splice(0, 0, Spartan_RDM_Operations_DetailData[i]);
            }
        }
        return newData;
    }
    function Spartan_RDM_Operations_DetailpushToMainArray(data, pageIndex, pageSize) {
        for (var i = 0; i < data.length; i++) {
            if (Spartan_RDM_Operations_DetailDataMain[(pageIndex * pageSize) - pageSize + i] == null)
                Spartan_RDM_Operations_DetailDataMain[(pageIndex * pageSize) - pageSize + i] = data[i];
        }
    }

});

//Grid GetAutocomplete

//Grid GetAutocomplete



function getDropdown(elementKey) {
    var labelSelect = $("#Spartan_Record_Detail_Management_cmbLabelSelect").val();
    var dropDown = '<select id="' + elementKey + '" class="form-control"><option value="">' + labelSelect + '</option></select>';
    return dropDown;
}

function GetGridDatePicker() {
    return "<input type='text' class='fullWidth gridDatePicker xyz form-control' >";
}
function GetGridTimePicker() {
    return "<input type='text' class='fullWidth gridTimePicker form-control'  data-autoclose='true'>";
}
function GetGridTextArea() {
    return "<textarea rows='2'></textarea>";
}
function GetGridCheckBox() {
    return " <input type='checkbox' class='fullWidth'> ";
}
function GetFileUploader() {
    return "<input type='file' class='fullWidth'>";
}

function GetGridAutoComplete(data,field, id) {
    
    var dataMain = data == null ? "Select" : data;
    id ==  (id==null   || id==undefined)? "":id;
    
     return "<select class='AutoComplete fullWidth select2-dropDown " + field + " form-control' data-val='true'  ><option value='" + id +"'>" + dataMain + "</option></select>";
}

function ClearControls() {
    $("#ReferenceProcess_Id").val("0");
    $('#CreateSpartan_Record_Detail_Management')[0].reset();
    ClearFormControls();
    $("#Process_IdId").val("0");
                Spartan_RDM_Filters_DetailClearGridData();
                Spartan_RDM_Operations_DetailClearGridData();

}
function ClearAttachmentsDiv() {
    if ($("#divAttachment") != null) {
        $("#divAttachment").empty();
    }
}
function ClearFormControls() {
    $('#CreateSpartan_Record_Detail_Management').trigger('reset');
    $('#CreateSpartan_Record_Detail_Management').find(':input').each(function () {
        switch (this.type) {
            case 'password':
            case 'number':
            case 'select-multiple':
            case 'select-one':
            case 'select':
            case 'text':
            case 'textarea':
                $(this).val('');
				for (instance in CKEDITOR.instances) {
                    CKEDITOR.instances[instance].updateElement();
                    CKEDITOR.instances[instance].setData('');
                }
                break;
            case 'checkbox':
            case 'radio':
                this.checked = false;
        }
    });
}
function CheckValidation() {
    var $myForm = $('#CreateSpartan_Record_Detail_Management');
    if (!$myForm[0].checkValidity()) {
        $myForm.submit();
        return false;
    }
    if (Spartan_RDM_Filters_DetailcountRowsChecked > 0)
    {
        ShowMessagePendingRowSpartan_RDM_Filters_Detail();
        return false;
    }
    if (Spartan_RDM_Operations_DetailcountRowsChecked > 0)
    {
        ShowMessagePendingRowSpartan_RDM_Operations_Detail();
        return false;
    }
	
    return true;
}


function ResetClaveLabel() {
    $("#lblProcess_Id").text("0");
}
$(document).ready(function () {
    $("form#CreateSpartan_Record_Detail_Management").submit(function (e) {
        e.preventDefault();
        return false;
    });
	$("form#CreateSpartan_Record_Detail_Management").on('click', '#Spartan_Record_Detail_ManagementCancelar', function () {
	  if (!isPartial) {
        Spartan_Record_Detail_ManagementBackToGrid();
	  } else {
            window.close();
      }
    });
	$("form#CreateSpartan_Record_Detail_Management").on('click', '#Spartan_Record_Detail_ManagementGuardar', function () {
		$('#Spartan_Record_Detail_ManagementGuardar').attr('disabled', true);
		$('#Spartan_Record_Detail_ManagementGuardar').unbind()
        if (EjecutarValidacionesAntesDeGuardar() && CheckValidation()) {
				if (!SendSpartan_Record_Detail_ManagementData(function () {
					EjecutarValidacionesDespuesDeGuardar();
					if (!isPartial  && !viewInEframe)
						Spartan_Record_Detail_ManagementBackToGrid();
					else if (viewInEframe) 
                    {
                        $('#Spartan_Record_Detail_ManagementGuardar').removeAttr('disabled');
                        $('#Spartan_Record_Detail_ManagementGuardar').bind()
                    }
					else {						
						if (!isMR)
							window.opener.RefreshCatalog('Spartan_Record_Detail_Management', nameAttribute);
						else {
							var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
							if(!control.hasClass('AutoComplete'))
							{
							if (control.attr("data-isfilter") == "true") {
									eval(GetReglaFilter(control,  $(window.opener.document.getElementById('ObjectId')).val()));								    
								}
								else 
								{
									eval('window.opener.Get' + nameMR + '_Spartan_Record_Detail_ManagementItem()');
									var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
									control.html(eval('window.opener.Get' + nameMR + '_Spartan_Record_Detail_ManagementDropDown().get(0)').innerHTML);  
								}								
							}
						}
						window.close();						
						}
				})) {
					$('#Spartan_Record_Detail_ManagementGuardar').removeAttr('disabled');
					$('#Spartan_Record_Detail_ManagementGuardar').bind()
				}
		}
		else {
			$('#Spartan_Record_Detail_ManagementGuardar').removeAttr('disabled');
			$('#Spartan_Record_Detail_ManagementGuardar').bind()
		}
    });
	$("form#CreateSpartan_Record_Detail_Management").on('click', '#Spartan_Record_Detail_ManagementGuardarYNuevo', function () {	
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation()) {
				SendSpartan_Record_Detail_ManagementData(function () {
					ClearControls();
					ClearAttachmentsDiv();
					ResetClaveLabel();
	                getSpartan_RDM_Filters_DetailData();
                getSpartan_RDM_Operations_DetailData();

					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Spartan_Record_Detail_Management', nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Spartan_Record_Detail_ManagementItem()');                           
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);
                            control.html(eval('window.opener.Get' + nameMR + '_Spartan_Record_Detail_ManagementDropDown().get(0)').innerHTML);   
					    }	
					}						
					EjecutarValidacionesDespuesDeGuardar();				
			setIsNew();
			EjecutarValidacionesAlComienzo();
				});
			}
		}		
    });
    $("form#CreateSpartan_Record_Detail_Management").on('click', '#Spartan_Record_Detail_ManagementGuardarYCopia', function () {
		if (EjecutarValidacionesAntesDeGuardar()) {
			if (CheckValidation())
				SendSpartan_Record_Detail_ManagementData(function (currentId) {
					$("#Process_IdId").val("0");
	                Spartan_RDM_Filters_DetailClearGridData();
                Spartan_RDM_Operations_DetailClearGridData();

					ResetClaveLabel();
					$("#ReferenceProcess_Id").val(currentId);
	                getSpartan_RDM_Filters_DetailData();
                getSpartan_RDM_Operations_DetailData();

					EjecutarValidacionesDespuesDeGuardar();		
					if (isPartial)
					{
						 if (!isMR)
					        window.opener.RefreshCatalog('Spartan_Record_Detail_Management',nameAttribute);
					    else {
                            eval('window.opener.Get' + nameMR + '_Spartan_Record_Detail_ManagementItem()');                          
                            var control = $(window.opener.document.getElementsByClassName(nameMR +"_" + nameAttribute)[0]);						
							control.html(eval('window.opener.Get' + nameMR + '_Spartan_Record_Detail_ManagementDropDown().get(0)').innerHTML);                          
					    }	
					}						
			setIsNew();
				});
		}
    });
});

function setIsNew() {
    $('#hdnIsNew').val("True");
	$('#Operation').val("New");
	operation = "New";
}



var mainElementObject;
var childElementObject;
function DisplayElementAttributes(data) {
}

function getElementTable(elementNumber, table) {

    for (var j = 0; j < childElementObject.length; j++) {
        if (childElementObject[j].table == table) {
            return childElementObject[j].elements[elementNumber];
            break;
        }
    }
}

function setRequired(elementNumber, element, elementType, table) {
    //debugger;
    if (elementType == "1") {
        mainElementObject[elementNumber].IsRequired = (mainElementObject[elementNumber].IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!mainElementObject[elementNumber].IsVisible && mainElementObject[elementNumber].IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (mainElementObject[elementNumber].IsReadOnly && mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    } else {
        getElementTable(elementNumber, table).IsRequired = (getElementTable(elementNumber, table).IsRequired == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsRequired == true ? GetTraduction('Required') : GetTraduction('NotRequired')));
        if (!getElementTable(elementNumber, table).IsVisible && getElementTable(elementNumber, table).IsRequired) {
            setVisible(elementNumber, $(element).parent().parent().find('div.visibleAttribute').find('a'), elementType);
        }
        if (getElementTable(elementNumber, table).IsReadOnly && getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '') {
            setReadOnly(elementNumber, $(element).parent().parent().find('div.readOnlyAttribute').find('a'), elementType);
        }
    }
}
function setVisible(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && mainElementObject[elementNumber].IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        mainElementObject[elementNumber].IsVisible = (mainElementObject[elementNumber].IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && getElementTable(elementNumber, table).IsVisible) {
            showNotification(GetTraduction("messagedNoInVisible"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsVisible = (getElementTable(elementNumber, table).IsVisible == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsVisible == true ? "Images/Visible.png" : "Images/inVisible.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsVisible == true ? GetTraduction('Visible') : GetTraduction('InVisible')));
    }
}
function setReadOnly(elementNumber, element, elementType, table) {
    if (elementType == "1") {
        if (mainElementObject[elementNumber].IsRequired && mainElementObject[elementNumber].DefaultValue == '' && !mainElementObject[elementNumber].IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        mainElementObject[elementNumber].IsReadOnly = (mainElementObject[elementNumber].IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[elementNumber].IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (mainElementObject[elementNumber].IsReadOnly == true ?GetTraduction('Disabled') : GetTraduction('Enabled')));
    } else {
        if (getElementTable(elementNumber, table).IsRequired && getElementTable(elementNumber, table).DefaultValue == '' && !getElementTable(elementNumber, table).IsReadOnly) {
            showNotification(GetTraduction("messagedNoReadOnly"), "error");
            return;
        }
        getElementTable(elementNumber, table).IsReadOnly = (getElementTable(elementNumber, table).IsReadOnly == true ? false : true);
        $(element).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable(elementNumber, table).IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + "");
        $(element).attr('title', (getElementTable(elementNumber, table).IsReadOnly == true ? GetTraduction('Disabled') : GetTraduction('Enabled')));
    }
}
function setDefaultValue(elementNumber, element, elementType, table) {
    //debugger;
    $('#hdnAttributType').val('1');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('DefaultValue'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].DefaultValue);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).DefaultValue);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
}
function setHelpText(elementNumber, element, elementType, table) {
    $('#hdnAttributType').val('2');
    $('#hdnAttributNumber').val(elementNumber);
    $('#lblAttributeType').text(GetTraduction('HelpText'));
    if (elementType == "1") {
        $('#txtAttributeValue').val(mainElementObject[elementNumber].HelpText);
        $('#hdnElementType').val("1");
    } else {
        $('#txtAttributeValue').val(getElementTable(elementNumber, table).HelpText);
        $('#hdnElementType').val("2");
    }
    $('#dvAttributeValue').show();
    //$(element).children().attr("src", "" + (mainElementObject[elementNumber].HelpText == '' ? "Images/red-help.png" : "Images/green-help.png") + "");
}
function SaveValue(table) {
    debugger;
    if ($('#hdnElementType').val() == "1") {
        if ($('#hdnAttributType').val() == "1") {
            mainElementObject[$('#hdnAttributNumber').val()].DefaultValue = $('#txtAttributeValue').val();
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].DefaultValue));
        } else if ($('#hdnAttributType').val() == "2") {
            mainElementObject[$('#hdnAttributNumber').val()].HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (mainElementObject[$('#hdnAttributNumber').val()].HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (mainElementObject[$('#hdnAttributNumber').val()].HelpText));
        }
    } else {
        if ($('#hdnAttributType').val() == "1") {
            getElementTable($('#hdnAttributNumber').val(), table).DefaultValue = $('#txtAttributeValue').val();
            console.log(childElementObject[$('#hdnAttributNumber').val()].DefaultValue);
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue == '' ? "Images/Not-Default-Value.png" : "Images/default-value.png") + "");
            $('#hlDefaultValueHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).DefaultValue));
            console.log($('#hdnAttributNumber').val());
        } else if ($('#hdnAttributType').val() == "2") {
            getElementTable($('#hdnAttributNumber').val(), table).HelpText = $('#txtAttributeValue').val();
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).children().attr("src", "" + $('#hdnApplicationDirectory').val() + (getElementTable($('#hdnAttributNumber').val(), table).HelpText == '' ? "Images/red-help.jpg" : "Images/green-help.png") + "");
            $('#hlHelpTextHeader_' + $('#hdnAttributNumber').val()).attr('title', (getElementTable($('#hdnAttributNumber').val(), table).HelpText));
        }
    }
    $('#txtAttributeValue').val('');
    $('#dvAttributeValue').hide();
}
function returnAttributeHTML(element, table, number) {
    var mainElementAttributes = '<div class="col-ld-12" style="display:inline-flex;">';
    mainElementAttributes += '<div class="displayAttributes requiredAttribute"><a class="requiredClick" title="' + (element.IsRequired == true ? GetTraduction("Required") : GetTraduction("NotRequired")) + '" onclick="setRequired(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsRequired == true ? "Images/Required.png" : "Images/Not-Required.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes visibleAttribute"><a class="visibleClick" title="' + (element.IsVisible == true ? GetTraduction("Visible") : GetTraduction("InVisible")) + '" onclick="setVisible(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsVisible == true ? "Images/Visible.png" : "Images/InVisible.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes readOnlyAttribute"><a class="readOnlyClick" title="' + (element.IsReadOnly == true ?GetTraduction("Disabled") :GetTraduction("Enabled")) + '" onclick="setReadOnly(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.IsReadOnly == true ? "Images/Disabled.png" : "Images/Enabled.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes defaultValueAttribute"><a id="hlDefaultValueHeader_' + number.toString() + '" class="defaultValueClick" title="' + (element.DefaultValue) + '" onclick="setDefaultValue(' + number.toString() + ', this, 2,  "' + table + '")"><img src="' + $('#hdnApplicationDirectory').val() + (element.DefaultValue != '' && element.DefaultValue != null ? "Images/default-value.png" : "Images/Not-Default-Value.png") + '" alt="" /></a></div>';
    mainElementAttributes += '<div class="displayAttributes helpTextAttribute"><a id="hlHelpTextHeader_' + number.toString() + '" class="helpTextClick" title="' + (element.HelpText) + '" onclick="setHelpText(' + number.toString() + ', this, 2,  \'' + table + '\')"><img src="' + $('#hdnApplicationDirectory').val() + (element.HelpText != '' && element.HelpText != null ? "Images/green-help.png" : "Images/red-help.jpg") + '" alt="" /></a></div>';
    mainElementAttributes += '</div>';
    return mainElementAttributes;
}



var Spartan_Record_Detail_ManagementisdisplayBusinessPropery = false;
Spartan_Record_Detail_ManagementDisplayBusinessRuleButtons(Spartan_Record_Detail_ManagementisdisplayBusinessPropery);
function Spartan_Record_Detail_ManagementDisplayBusinessRule() {
    if (!Spartan_Record_Detail_ManagementisdisplayBusinessPropery) {
        $('#CreateSpartan_Record_Detail_Management').find('.col-sm-8').each(function () {
			var div =$(this); 
			if ($(this).find('.input-group').length >0)
				div  =  $(this).find('.input-group').first().hasClass('date')? $(this): $(this).find('.input-group').first();	
            var mainElementAttributes = '<div class="col-sm-2">';
            var fieldId = div.data('field-id');
            var fieldName = div.data('field-name');
            var attribute = div.data('attribute');
            mainElementAttributes += '<div class="Spartan_Record_Detail_ManagementdisplayBusinessPropery"><button onclick="Spartan_Record_Detail_ManagementGetBusinessRule()" type="button" data-field-id="' + fieldId + '" data-field-name="' + fieldName + '" data-attribute="' + attribute + '" class="btn btn-info btn-lg btnPopupBusinessRules" data-toggle="modal" data-target="#Spartan_Record_Detail_ManagementBusinessRule-form"><i class="fa fa-cogs fa-spin"></i></button></div>';
            mainElementAttributes += '</div>';
            $(this).after(mainElementAttributes);
        });
    } else {
        $('.Spartan_Record_Detail_ManagementdisplayBusinessPropery').remove();
    }
    Spartan_Record_Detail_ManagementDisplayBusinessRuleButtons(!Spartan_Record_Detail_ManagementisdisplayBusinessPropery);
    Spartan_Record_Detail_ManagementisdisplayBusinessPropery = (Spartan_Record_Detail_ManagementisdisplayBusinessPropery ? false : true);
}
function Spartan_Record_Detail_ManagementDisplayBusinessRuleButtons(flag) {
    var element = $('.displayRuleButton');
    if (flag) {
        element.show();
        element.prop('disabled', false);
    } else {
        element.hide();
        element.prop('disabled', true);
    }
}

