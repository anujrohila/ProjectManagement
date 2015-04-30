function DeleteMember(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/Member/Delete";
    var dataToSend = { memberId: id };
    if (confirmResult) {
        ShowProcess();
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                alert(result.Success);
                if (result.Success == true) {
                    RefreshGrid("ListMemberGrid");
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

function OnMemberFormSubmit() {
    ShowProcess();
    var projectObjects = $("#divProjects").find("input");
    var strSelectedProject = '';
    for (var i = 0; i < projectObjects.length; i++) {
        if (projectObjects[i].checked) {
            if (strSelectedProject == '') {
                strSelectedProject = projectObjects[i].value;
            }
            else {
                strSelectedProject = "," + projectObjects[i].value;
            }
        }
    }

    $("#ProjectSelectionString").val(strSelectedProject);
    if (strSelectedProject == '') {
        alert("Please select at least one project.");
        HideProcess();
        return false;
    }

    var entityObjects = $("#divEntityListPermission").find("div[id=EntityObject]");
    var selectedEntityString = '';
    for (var i = 0; i < entityObjects.length; i++) {
        var entityPermissions = $($("#divEntityListPermission").find("div[id=EntityObject]")[i]).find("input");
        var oneEntityPermisison = '';

        oneEntityPermisison = entityPermissions[0].value + "-";
        if (entityPermissions[0].checked) {
            oneEntityPermisison = oneEntityPermisison + ",L";
        }
        if (entityPermissions.length > 1) {
            if (entityPermissions[1].checked) {
                oneEntityPermisison = oneEntityPermisison + ",I";
            }
        }
        if (entityPermissions.length > 2) {
            if (entityPermissions[2].checked) {
                oneEntityPermisison = oneEntityPermisison + ",E";
            }
        }
        if (entityPermissions.length > 3) {
            if (entityPermissions[3].checked) {
                oneEntityPermisison = oneEntityPermisison + ",D";
            }
        }
        if (selectedEntityString == '') {
            selectedEntityString = oneEntityPermisison;
        }
        else {
            selectedEntityString = selectedEntityString + "#" + oneEntityPermisison;
        }
    }
    $("#EntityPermissionSelectionString").val(selectedEntityString);
    HideProcess();
    return true;
}
