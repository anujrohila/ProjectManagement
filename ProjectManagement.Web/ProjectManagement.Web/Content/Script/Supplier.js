function DeleteSupplier(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/Supplier/Delete";
    var dataToSend = { supplierId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListSupplierGrid");
                }
                else {
                    alert(result.Message);
                }
            }
        });
    }
}