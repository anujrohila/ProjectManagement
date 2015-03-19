function DeleteTransactionEntry(id) {
    var confirmResult = confirm("Are you sure you want to delete this record?");
    var callUrl = $("#webUrl").val() + "/TransactionEntry/Delete";
    var dataToSend = { entryId: id };
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
                    RefreshGrid("ListTransactionEntryGrid");
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

function OnTransactionEntrySearchClick() {
    var sDate = $("#StartDate").val();
    var eDate = $("#EndDate").val();
    var isValidate = true;
    if (sDate == "") {
        alert("Please select start date.");
        isValidate = false;
    }
    if (eDate == "") {
        alert("Please select end date.");
        isValidate = false;
    }
    var sDateObject = new Date(sDate.split("-")[2], sDate.split("-")[1], sDate.split("-")[0]);
    var eDateObject = new Date(eDate.split("-")[2], eDate.split("-")[1], eDate.split("-")[0]);
    if (sDateObject > eDateObject) {
        alert("Please select valid date start date must be less than end date.");
        isValidate = false;
    }
    if (isValidate)
        RefreshGrid("ListTransactionEntryGrid");
}

function OnTransactionEntryDataBinding(args) {
    var sDate = $("#StartDate").val();
    var eDate = $("#EndDate").val();
    var transactionType = $("#TransactionType").val();
    args.data = $.extend(args.data, { type: transactionType, startDate: sDate, endDate: eDate });
}