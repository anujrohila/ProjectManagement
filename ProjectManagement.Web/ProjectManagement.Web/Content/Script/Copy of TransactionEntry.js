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
