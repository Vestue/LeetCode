SELECT 
    name, 
    SUM(amount) AS 'balance'
FROM USERS 
    LEFT JOIN TRANSACTIONS 
        USING(account)
GROUP BY account 
    HAVING balance > 10000