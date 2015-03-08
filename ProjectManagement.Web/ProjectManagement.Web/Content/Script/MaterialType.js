function DeleteMaterialType(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/MaterialGroup/Delete";
    var dataToSend = { typeId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListMaterialGroupGrid");
                }
                else {
                    alert(result.Message);
                }
            }
        });
    }
}