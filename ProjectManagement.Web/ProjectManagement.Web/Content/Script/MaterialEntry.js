function DeleteMaterialEntry(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/MaterialEntry/Delete";
    var dataToSend = { entryId: id };
    if (confirmResult) {
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

