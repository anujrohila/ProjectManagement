function DeleteDocument(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/Documents/Delete";
    var dataToSend = { Docuementid: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListDocumentGrid");
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