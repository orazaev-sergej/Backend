SELECT DISTINCT users.name
FROM
	orders
	JOIN users ON orders.users_id = users.users_id
WHERE
	status = 0
