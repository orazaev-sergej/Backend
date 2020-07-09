--создал таблицу "user"
CREATE TABLE "user" (
	"id" INTEGER PRIMARY KEY AUTOINCREMENT,
	"age" INTEGER
);

--заполнил колонку "age"
INSERT INTO "user" (age)
VALUES
	("12"),
	("25"),
	("12"),
	("65"),
	("46"),
	("65");
  
--удаляю дублирующие результаты с колонки age
SELECT DISTINCT "age"
FROM user
