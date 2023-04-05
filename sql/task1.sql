-- create a table
CREATE TABLE FullList (
  id INTEGER PRIMARY KEY
  , FIO VARCHAR(128) NOT NULL
  , DateBirth VARCHAR(128)
  , States VARCHAR(128)
  , PhoneNumber INTEGER
  , PhoneType VARCHAR(200)
  , Address VARCHAR(200)
  , Groupp VARCHAR(200)
);
-- insert some values
INSERT INTO FullList VALUES (1, 'Иванов И. И.', '12.02.1990', 'женат', 126 , 'интернет', 'Можга', 'Работа'
);
INSERT INTO FullList VALUES (2, 'Кириллов К.К.', '12/3/1996', 'холост', 933, 'личный', 'Киров', 'Работа'
);
INSERT INTO FullList VALUES (3, 'Иванов И. И.', '9/18/2001', 'холост', 527, 'личный', 'Санкт-Петербург', 'Школа'
);
INSERT INTO FullList VALUES (4, 'Петров П. П.', '4/23/1983', 'женат', 234, 'личный', 'Москва', 'Родня');
INSERT INTO FullList VALUES (5, 'Михайлов М.М.', '1/8/1997', 'женат', 876, 'личный', 'Сочи', 'Университет');
INSERT INTO FullList VALUES (6, 'Васильев В. В.', '5/21/1998', 'холост', 456, 'личный', 'Белгород', 'Друзья');
INSERT INTO FullList VALUES (7, 'Сидоров С.С.', '7/13/2007', 'холост', 643, 'личный', 'Киров', 'Родня');
INSERT INTO FullList VALUES (8, 'Борисов Б.Б', '8/16/1989', 'холост', 723, 'рабочий', 'Москва', 'Работа');
INSERT INTO FullList VALUES (9, 'Александров А.А.','3/5/1987','женат',412,'рабочий','Уфа', 'Друзья');

-- fetch some values
-- SELECT ФИО, Тел, Комментарий FROM Общий список
-- SELECT ФИО, Тел, Комментарий FROM Общий список WHERE Группа = «Родня»
SELECT FIO, PhoneNumber, PhoneType, Groupp FROM FullList WHERE Groupp = 'Родня';
-- SELECT Тел FROM Общий список WHERE Группа = «Друзья»
-- AND Статус = «холост»
-- SELECT Д/р FROM Общий список WHERE Группа = «Университет» OR Статус = «холост»