/*В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.*/

/*Создание БД*/

CREATE DATABASE Market;
use Market;
CREATE TABLE Product (product_id INT, product_name VARCHAR(45));
CREATE TABLE Category (category_id INT, category_name VARCHAR(45));
CREATE TABLE Products_categories (product INT, category INT);

/*Заполнение БД*/

INSERT INTO Product (product_id, product_name)
VALUES 
		(1, 'Potato'),
        (2, 'Cucumber'),
        (3, 'PlayStation'),
        (4, 'Pear'),
        (5, 'Apple');

INSERT INTO Category (category_id, category_name)
VALUES 
		(1, 'Vegetables'),
        (2, 'Food'),
        (3, 'Fruits');
        
INSERT INTO Products_categories (product, category)
VALUES 
		(1, 1),
        (1, 2),
        (2, 1),
        (2, 2),
        (4, 3),
        (4, 2),
        (5, 3),
        (5, 2),
        (3, NULL);
        
/*Запрос к БД*/

SELECT Product.product_name, category_name FROM Product
LEFT JOIN Products_categories ON Product.product_id = Products_categories.product  
LEFT JOIN Category ON Products_categories.category = Category.category_id