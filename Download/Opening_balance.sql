SELECT (isnull((SELECT sum(opbalance)  
FROM supplier 
WHERE sup_id in (select Sup_id 
				from Supplier 
				where (ChildOf ='BHES-0003' or sup_id='BHES-0003'))),0) + isnull((SELECT SUM(AMMOUNT)  
																				 FROM [Mat_AccountTwo] 
																				 WHERE from_ACCOUNT in (select Sup_id 
																										from Supplier 
																										where (ChildOf ='BHES-0003'  or sup_id='BHES-0003')) ),0) 
             + isnull((SELECT SUM(AMMOUNT)  
					  FROM [Mat_AccountTwo] 
					  WHERE to_ACCOUNT in (select Sup_id 
										   from Supplier 
										   where (ChildOf ='BHES-0003'  or sup_id='BHES-0003')) ),0)) AS BALANCE
             FROM [Mat_AccountTwo] where hand_group='R'