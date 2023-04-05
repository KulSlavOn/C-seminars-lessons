CREATE TABLE people (
person_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE phones (
phone_id INT PRIMARY KEY,
person_id INT,
number VARCHAR(20),
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

INSERT INTO phones (phone_id, person_id, number)
VALUES (1, 1, '123-456-7890'), (2, 2, '987-654-3210'), (3, 3, '555-555-5555'),(4,1,'895-8654-545');

INSERT INTO addresses (address_id, person_id, street, city)
VALUES (1, 1, '123 Lenina', 'Moscow'), (2, 2, '456 Pyshkina', 'Rostov'), (3, 3, '789 Turgenevskaya', 'Sankt Peterburg');

-- INNER JOIN Люди, Телефоны ON id = Чей телефон
-- select * from people INNER JOIN phones ON people.person_id = phones.person_id;
-- LEFT JOIN Люди, Телефоны ON id = Чей телефон
-- select * from people LEFT JOIN phones ON people.person_id = phones.person_id;
-- RIGHT JOIN Люди, Телефоны ON id = Чей телефон
-- select * from people RIGHT JOIN phones ON people.person_id = phones.person_id;
-- FULL JOIN Люди, Телефоны ON id = Чей телефон
SELECT p.*, PH.* FROM people as p, phones as PH;