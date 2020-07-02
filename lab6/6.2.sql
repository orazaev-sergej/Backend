SELECT download_count, count(download_count) AS user_count
FROM 	(SELECT count(user_id) as download_count
		FROM track_downloads
		WHERE download_time = "2010-11-19"
		GROUP BY user_id)
GROUP BY 
download_count
