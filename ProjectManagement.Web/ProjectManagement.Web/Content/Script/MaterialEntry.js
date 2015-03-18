function DeleteMaterialEntry(id) {
   
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/MaterialEntry/Delete";
    var dataToSend = { entryId: id };
    if (confirmResult) {
        ShowProcess();
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListMaterialEntryGrid");
                }
                else {
                    if (result.Message == undefined) {
                        window.location = $("#webUrl").val() + "/Profile/Unauthorized"
                    }
                    else {
                        alert(result.Message);
                    }
                }
                HideProcess();
            }
        });
    }
}

function CalculateAmount() {
    var quantity = $("#Qty").val();
    var rate = $("#Rate").val();
    if (quantity == '') {
        quantity = "0";
    }
    if (rate == '') {
        rate = "0";
    }
    if (quantity != "0" && rate != "0") {
        $("#Ammount").val(parseFloat(quantity) * parseFloat(rate));
    }
    else {
        $("#Ammount").val("0");
    }
}

function OnKeyPress(evt, t) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;

    if (charCode != 46 && charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return CalculateAmount();
}


function AddSupplier() {
    ShowProcess();
    var callUrl = $("#webUrl").val() + "/Supplier/_PartialSave";
    var dataToSend = {};
    $.ajax({
        url: callUrl,
        type: "GET",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divAddSupplierModelPopupbody").html(html);
            OpenTelerikWindow('AddSupplierModelPopupWindow');
            HideProcess();
        }
    });
}

function SubmitSuplierDetails() {
    var form = $('#frmSupplier');
    $.validator.unobtrusive.parse(form);
    var isFormValid = form.valid();
    if (isFormValid) {
        ShowProcess();
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/Supplier/_PartialSave";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success) {
                    $("#Sup_id").append("<option value=" + result.Sup_id + ">" + result.NameiS + "</option>");
                    CloseTelerikWindow('AddSupplierModelPopupWindow');
                }
                else {
                    alert(result.Message);
                }
                HideProcess();
            }
        });
    }
    else {
        return false;
    }
}

function AddMaterialSubGroup() {
    ShowProcess();
    var callUrl = $("#webUrl").val() + "/MaterialSubGroup/_PartialSave";
    var dataToSend = {};
    $.ajax({
        url: callUrl,
        type: "GET",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divMaterialSubGroupModelPopupbody").html(html);
            OpenTelerikWindow('AddMaterialSubGroupModelPopupWindow');
            HideProcess();
        }
    });
}

function SubmitMaterialSubGroupDetails() {
    var form = $('#frmMaterialSubGroup');
    $.validator.unobtrusive.parse(form);
    var isFormValid = form.valid();
    if (isFormValid) {
        ShowProcess();
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/MaterialSubGroup/_PartialSave";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success) {
                    $("#Mat_id").append("<option value=" + result.Mat_id + ">" + result.Mat_Name + "</option>");
                    CloseTelerikWindow('AddMaterialSubGroupModelPopupWindow');
                }
                else {
                    alert(result.Message);
                }
                HideProcess();
            }
        });
    }
    else {
        return false;
    }
}
