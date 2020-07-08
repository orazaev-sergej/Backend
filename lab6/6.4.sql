SELECT
	count(number_of_people) as num_of_people
FROM 
	(SELECT
		count(course_id) as number_of_people
	FROM
		students_in_courses
	GROUP BY
		course_id)
WHERE
	number_of_people > 5
