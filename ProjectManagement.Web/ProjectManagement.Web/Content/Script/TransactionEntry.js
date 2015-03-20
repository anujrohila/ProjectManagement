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

function OnAmountKeyPress(evt, t) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;

    if (charCode != 46 && charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}

function OnAmountBlur(evt, t) {
    $("#Ammount").val(parseFloat(Math.round(t.value * 100) / 100).toFixed(2));
}

$("#From_Account").change(function () {
    var groupId = $('option:selected', $("#From_Account")).attr('groupId');
    var modePayRec = $("#Mode_Pay_Rec").val();
    var recPay = $("#Rec_Pay").val();
    if (modePayRec.toLowerCase() == "bank") {
        if (recPay.toLowerCase() == "payment" && groupId != "0") {
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
        }
        else {
            $("#divBankName").show();
        }
    }
    else if (modePayRec.toLowerCase() == "contra") {
        var groupIdTo = $('option:selected', $("#To_Account")).attr('groupId');
        if (parseInt(groupId) == 2 && (parseInt(groupIdTo) == 6 || parseInt(groupIdTo) == 45 || parseInt(groupId) == 6 || parseInt(groupId) == 45)) {
            $("#divChequeNo").show();
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
            $("#Disp").val("Self Withdrawn");
        }
        else if ((parseInt(groupId) == 6 || parseInt(groupId) == 45) && (parseInt(groupIdTo) == 2)) {
            $("#ChqNo").val("");
            $("#divChequeNo").hide();
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
            $("#Disp").val("Self Withdrawn");
        }
        else if ((parseInt(groupId) == 6 || parseInt(groupId) == 45) && (parseInt(groupIdTo) == 6 || parseInt(groupIdTo) == 45)) {
            $("#ChqNo").val("");
            $("#divChequeNo").hide();
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
            $("#Disp").val("Self Withdrawn");
        }
        else {
            $("#divChequeNo").show();
            $("#Disp").val("");
            $("#divBankName").show();
        }
    }
});

$("#To_Account").change(function () {
    var groupId = $('option:selected', $("#From_Account")).attr('groupId');
    var modePayRec = $("#Mode_Pay_Rec").val();
    var recPay = $("#Rec_Pay").val();
    if (modePayRec.toLowerCase() == "contra") {
        var groupIdTo = $('option:selected', $("#To_Account")).attr('groupId');
        if (parseInt(groupId) == 2 && (parseInt(groupIdTo) == 6 || parseInt(groupIdTo) == 45 || parseInt(groupId) == 6 || parseInt(groupId) == 45)) {
            $("#divChequeNo").show();
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
            $("#Disp").val("Self Withdrawn");
        }
        else if ((parseInt(groupId) == 6 || parseInt(groupId) == 45) && (parseInt(groupIdTo) == 2)) {
            $("#ChqNo").val("");
            $("#divChequeNo").hide();
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
            $("#Disp").val("Self Withdrawn");
        }
        else if ((parseInt(groupId) == 6 || parseInt(groupId) == 45) && (parseInt(groupIdTo) == 6 || parseInt(groupIdTo) == 45)) {
            $("#ChqNo").val("");
            $("#divChequeNo").hide();
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
            $("#Disp").val("Self Withdrawn");
        }
        else {
            $("#divChequeNo").show();
            $("#Disp").val("");
            $("#divBankName").show();
        }
    }
});

$("#Rec_Pay").change(function () {
    var modePayRec = $("#Mode_Pay_Rec").val();
    var recPay = $("#Rec_Pay").val();
    if (modePayRec.toLowerCase() == "bank") {
        if (recPay.toLowerCase() == "payment") {
            $("#ChqDrawn").select(0);
            $("#divBankName").hide();
        }
        else {
            $("#divBankName").show();
        }
    }

});

