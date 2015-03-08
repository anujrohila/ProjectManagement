function DeleteMaterialSubType(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/MaterialSubGroup/Delete";
    var dataToSend = { subTypeId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListMaterialSubGroupGrid");
                }
                else {
                    alert(result.Message);
                }
            }
        });
    }
}