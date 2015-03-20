function DeleteDocument(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/Documents/Delete";
    var dataToSend = { Docuementid: id };
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
                HideProcess();
            }
        });
    }
}


function ViewDocument(id) {
    ShowProcess();
    var callUrl = $("#webUrl").val() + "/Documents/_PartialShowImage";
    var dataToSend = {DocID : id};
    $.ajax({
        url: callUrl,
        type: "GET",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divDocumentModelPopupbody").html(html);
            OpenTelerikWindow('AddDocumentModelPopupWindow');
            HideProcess();
        }
    });
}