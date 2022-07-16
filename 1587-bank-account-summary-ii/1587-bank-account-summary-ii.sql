# Write your MySQL query statement below
SELECT
    USERS.name,
    SUM(TRANSACTIONS.amount) AS 'balance'
FROM USERS
    LEFT JOIN TRANSACTIONS
        ON Users.account = Transactions.account
GROUP BY
    TRANSACTIONS.account HAVING balance > 10000