SELECT Supplier.NAMEis ,supplier.sup_id as sup_id, Supplier_1.Nameis AS NAMEiS2,supplier_1.sup_id as sup_id2, Mat_Accounttwo.* 
FROM (Mat_AccountTwo 
	INNER JOIN Supplier ON Mat_AccountTwo.From_Account = Supplier.Sup_id) 
	INNER JOIN Supplier AS Supplier_1 ON Mat_AccountTwo.To_Account = Supplier_1.sup_id 
	where (MAT_ACCOUNTTWO.from_ACCOUNT= 'BHES-0001' 
		OR MAT_ACCOUNTTWO.TO_ACCOUNT= 'BHES-0001') 
		and (mode_pay_rec='CASH' OR MODE_PAY_REC='CONTRA') 
		and mat_accounttwo.ddate >='" & Book_Start & "' 
		order by ddate