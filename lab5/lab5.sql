--2. Добавьте таблицы:

CREATE TABLE "dvd" (
	"dvd_id"	INTEGER,
	"title"	TEXT NOT NULL,
	"production_year"	INTEGER NOT NULL,
	PRIMARY KEY("dvd_id" AUTOINCREMENT)
);

CREATE TABLE "customer" (
	"customer_id"	INTEGER,
	"first_name"	TEXT NOT NULL,
	"last_name"	TEXT NOT NULL,
	"passport_code"	INTEGER NOT NULL,
	"registration_date"	TEXT NOT NULL,
	PRIMARY KEY("customer_id" AUTOINCREMENT)
);

CREATE TABLE "offer" (
	"offer_id"	INTEGER,
	"dvd_id"	INTEGER NOT NULL,
	"customer_id"	INTEGER NOT NULL,
	"offer_date"	TEXT NOT NULL,
	"return_date"	TEXT  ,
	PRIMARY KEY("offer_id" AUTOINCREMENT)
);

--3. Подготовьте SQL запросы для заполнения таблиц данными:
INSERT INTO dvd (title, production_year) 
VALUES 
	('Шрек', 2001),
	('Начало', 2010),	
	('Парфюмер', 2006), 
	('127 часов', 2010), 
	('Паразиты', 2019),
	('Остров проклятых', 2010);

INSERT INTO customer (first_name, last_name, passport_code, registration_date) 
VALUES 
	('Jane', 'Doe', 12345, '12-04-2008'),
	('John', 'Doe', 54321, '20-12-2019'),
  ('Ben', 'Franklin', 666, '17-01-1706'),
	('Albert', 'Einstein', 300, '20-02-1999'),
	('Marie', 'Curie', 88, '11-11-2011');

INSERT INTO offer (dvd_id, customer_id, offer_date, return_date)
VALUES
	(6, 2, '20-06-2010', '27-06-2020'),
	(1, 1, '12-05-2012', '05-02-2013'),
	(2, 3, '21-10-2015', ''),
	(3, 4, '06-04-2020', ''),
	(5, 5, '12-06-2020', '12-06-2020');
	
-- 4.  Подготовьте SQL запрос получения списка всех DVD, год выпуска которых 2010, отсортированных в алфавитном порядке по названию DVD.
SELECT *
FROM dvd
WHERE production_year = 2010
ORDER BY title ASC;

-- 5.  Подготовьте SQL запрос для получения списка DVD дисков, которые в настоящее время находятся у клиентов.
SELECT title
FROM
	dvd
WHERE dvd_id IN
(
	SELECT dvd_id
	FROM 
		offer
	WHERE offer_date <= date('now') AND date('now') <= return_date
);

-- 6.  Напишите SQL запрос для получения списка клиентов, которые брали какие-либо DVD диски в текущем году. В результатах запроса необходимо также отразить какие диски брали клиенты.
SELECT 
	customer.customer_id, 
	customer.first_name, 
	customer.last_name, 
	dvd.dvd_id, 
	dvd.title,
	dvd.production_year
FROM customer
LEFT JOIN offer ON customer.customer_id = offer.customer_id
LEFT JOIN dvd ON dvd.dvd_id = offer.dvd_id
WHERE 
	strftime('%Y', offer.offer_date) = '2020';
