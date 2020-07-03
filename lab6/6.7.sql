-- 7.1
SELECT DISTINCT users.name
FROM
	orders
	JOIN users ON orders.users_id = users.users_id
WHERE
	status = 0
	
--7.2
SELECT
	orders_count, users_name
FROM
	(SELECT
		count(users.name) as orders_count, users.name as users_name
	FROM
		orders
		JOIN users ON orders.users_id = users.users_id
	WHERE
		status = 1
	GROUP BY
		users.name)
WHERE
	orders_count > 5
