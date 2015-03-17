function DeleteProject(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/Project/Delete";
    var dataToSend = { projectId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListProjectGrid");
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