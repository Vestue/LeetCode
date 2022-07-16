# Write your MySQL query statement below
SELECT
    name,
    SUM(amount) balance
FROM USERS
    LEFT JOIN TRANSACTIONS
        USING(account)
GROUP BY account HAVING balance > 10000