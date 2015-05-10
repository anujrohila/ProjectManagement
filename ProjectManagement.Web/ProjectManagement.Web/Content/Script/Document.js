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

function OnGroupWiseDocumentViewButtonClick() {
    RefreshGrid("ListDocumentGrid");
}

function OnListDocumentDataBinding(args) {
    args.data = $.extend(args.data, { documentGroupId: $("#DocumentGroupId option:selected").val() });
}

function AddDocumentGroup() {
    ShowProcess();
    var callUrl = $("#webUrl").val() + "/Documents/_PartialSaveDocumentGroup";
    var dataToSend = {};
    $.ajax({
        url: callUrl,
        type: "GET",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divAddDocumentGroupModelPopupbody").html(html);
            OpenTelerikWindow('AddDocumentGroupModelPopupWindow');
            HideProcess();
        },
        error: function () {
            HideProcess();
        }
    });
}

function OnSaveDocumentGroupClick() {
    var form = $('#frmSaveDocumentGroup');
    $.validator.unobtrusive.parse(form);
    var isFormValid = form.valid();
    if (isFormValid) {
        ShowProcess();
        var formData = form.serialize();
        var callUrl = $("#webUrl").val() + "/Documents/_PartialSaveDocumentGroup";
        $.ajax({
            url: callUrl,
            type: "POST",
            data: formData,
            cache: false,
            success: function (result) {
                if (result.Success) {
                    $("#DocumentGroupId").append("<option value=" + result.DocumentGroupId + ">" + result.GroupName + "</option>");
                    CloseTelerikWindow('AddDocumentGroupModelPopupWindow');
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
