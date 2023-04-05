CREATE TABLE people (
person_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE phones (
phone_id INT PRIMARY KEY,
person_id INT,
number VARCHAR(20),
comments VARCHAR(128),
FOREIGN KEY (person_id) REFERENCES people(person_id)
);

CREATE TABLE addresses (
address_id INT PRIMARY KEY,
person_id INT,
street VARCHAR(50),
city VARCHAR(50),
FOREIGN KEY (person_id) REFERENCES people(person_id)
);

INSERT INTO people (person_id, name)
VALUES (1, 'John'), (2, 'Jane'), (3, 'Bob'), (4, 'Sara');

INSERT INTO phones (phone_id, person_id, number, comments)
VALUES (1, 1, '123-456-7890','work'), (2, 2, '987-654-3210','home'), (3, 3, '555-555-5555','mobile'),(4,1,'895-8654-545','home');

INSERT INTO addresses (address_id, person_id, street, city)
VALUES (1, 1, '123 Lenina', 'Moscow'), (2, 2, '456 Pyshkina', 'Rostov'), (3, 3, '789 Turgenevskaya', 'Sankt Peterburg');

-- SELECT ФИО, Тел, Коммент FROM Люди LEFT JOIN Телефоны ON id = Чей телефон
-- SELECT people.name as 'ФИО'
-- , phones.number as 'Тел'
-- , phones.comments as 'Коммент'
-- FROM people LEFT JOIN phones ON people.person_id = phones.person_id;

-- SELECT * FROM Люди INNER JOIN Телефоны ON id = Чей телефон INNER JOIN Адреса ON id = Чей адрес
-- SELECT *
-- FROM people INNER JOIN phones ON people.person_id = phones.person_id
-- INNER JOIN addresses ON people.person_id = addresses.person_id;

-- SELECT ФИО, Тел, Адрес FROM Люди INNER JOIN Телефоны ON id = Чей телефон INNER JOIN Адреса
-- ON id = Чей адрес WHERE ФИО = 'Петров П.П.'
SELECT people.name, phones.number, concat(addresses.street,' ',addresses.city) FROM people
INNER JOIN phones ON people.person_id = phones.person_id -- and people.name = 'John'
INNER JOIN addresses ON people.person_id = addresses.person_id
WHERE people.name = 'John';
