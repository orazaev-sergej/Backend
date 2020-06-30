--Тактовые частоты CPU тех компьютеров, у которых объем памяти 3000 Мб. Вывод: id, cpu, memory
SELECT id, cpu(MHz), memory(Mb)
FROM PC
WHERE memory(Mb) = 3000;
