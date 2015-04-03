function OnCashBookReportButtonClick() {
    var accountId = $("#AccountId").val();
    var objDate = $("#TransactionDate").val();
    if (accountId == "0") {
        alert("Please select account.");
        return false;
    }
    if (objDate == "") {
        alert("Please select transaction date.");
        return false;
    }
    var callUrl = $("#webUrl").val() + "/CashBook/_PartialReportData";
    var dataToSend = { accountId: accountId, selectedDate: objDate };
    ShowProcess();
    $.ajax({
        url: callUrl,
        type: "POST",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divReportData").html(html);
        }
    });
    HideProcess();
}

function OnBankBookReportButtonClick() {
    var accountId = $("#AccountId").val();
    var objDate = $("#TransactionDate").val();
    if (accountId == "0") {
        alert("Please select account.");
        return false;
    }
    if (objDate == "") {
        alert("Please select transaction date.");
        return false;
    }
    var callUrl = $("#webUrl").val() + "/BankBook/_PartialReportData";
    var dataToSend = { accountId: accountId, selectedDate: objDate };
    ShowProcess();
    $.ajax({
        url: callUrl,
        type: "POST",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divReportData").html(html);
        }
    });
    HideProcess();
}

function OnLedgerBookReportButtonClick() {
    var accountId = $("#AccountId").val();
    var objDate = $("#TransactionDate").val();
    if (accountId == "0") {
        alert("Please select account.");
        return false;
    }
    if (objDate == "") {
        alert("Please select transaction date.");
        return false;
    }
    var callUrl = $("#webUrl").val() + "/LedgerBook/_PartialReportData";
    var dataToSend = { accountId: accountId, selectedDate: objDate };
    ShowProcess();
    $.ajax({
        url: callUrl,
        type: "POST",
        data: dataToSend,
        cache: false,
        success: function (html) {
            $("#divReportData").html(html);
        }
    });
    HideProcess();
}



