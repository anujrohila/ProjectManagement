function DeleteMember(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/Member/Delete";
    var dataToSend = { memberId: id };
    if (confirmResult) {
        $.ajax({
            url: callUrl,
            type: "POST",
            data: dataToSend,
            cache: false,
            success: function (result) {
                if (result.Success == true) {
                    alert(result.Message);
                    RefreshGrid("ListMemberGrid");
                }
                else {
                    alert(result.Message);
                }
            }
        });
    }
}

function OnMemberFormSubmit() {
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
        if (entityPermissions[1].checked) {
            oneEntityPermisison = oneEntityPermisison + ",I";
        }
        if (entityPermissions[2].checked) {
            oneEntityPermisison = oneEntityPermisison + ",E";
        }
        if (entityPermissions[3].checked) {
            oneEntityPermisison = oneEntityPermisison + ",D";
        }

        if (selectedEntityString == '') {
            selectedEntityString = oneEntityPermisison;
        }
        else {
            selectedEntityString = selectedEntityString + "#" + oneEntityPermisison;
        }
    }
    $("#EntityPermissionSelectionString").val(selectedEntityString);
    return true;
}
