function OnCashBookReportButtonClick() {
    var accountId = $("#AccountId").val();
    var objDate = $("#TransactionDate").val();
    objDate = "01-04-" + objDate;
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
            $("#spanAccountName").html($("#AccountId option:selected").text());
            $("#spanReportPeriodText").html($("#TransactionDate option:selected").text());
        }
    });
    HideProcess();
}

function OnBankBookReportButtonClick() {
    var accountId = $("#AccountId").val();
    var objDate = $("#TransactionDate").val();
    objDate = "01-04-" + objDate;
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
            $("#spanAccountName").html($("#AccountId option:selected").text());
            $("#spanReportPeriodText").html($("#TransactionDate option:selected").text());
        }
    });
    HideProcess();
}

function OnLedgerBookReportButtonClick() {
    var accountId = $("#AccountId").val();
    var objDate = $("#TransactionDate").val();
    objDate = "01-04-" + objDate;
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
            $("#spanAccountName").html($("#AccountId option:selected").text());
            $("#spanReportPeriodText").html($("#TransactionDate option:selected").text());
            
        }
    });
    HideProcess();
}

function PrintObject() {
    $(".printable").print();
}



