--Тактовые частоты CPU тех компьютеров, у которых объем памяти 3000 Мб. Вывод: id, cpu, memory

SELECT id, cpu(MHz), memory(Mb)
FROM PC
WHERE memory(Mb) = 3000;

--Минимальный объём жесткого диска, установленного в компьютере на складе. Вывод: hdd

SELECT hdd
FROM PC
WHERE MIN(hdd(Gb))
             
--Количество компьютеров с минимальным объемом жесткого диска, доступного на складе. Вывод: count, hdd
SELECT COUNT(hdd(Gb))
FROM PC
WHERE MIN(hdd(Gb))
