function DeleteMasterAccountEntry(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/MasterAccount/Delete";
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
                    RefreshGrid("ListMasterAccountGrid");
                }
                else {
                    alert(result.Message);
                }
            }
        });
    }
}