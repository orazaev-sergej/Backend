SELECT count(number_of_people) as courses_with_more_than_5_people
FROM (SELECT
		    count(course_id) as number_of_people
	    FROM
		    students_on_courses
	    GROUP BY
		    course_id)
WHERE
	number_of_people >= 5
