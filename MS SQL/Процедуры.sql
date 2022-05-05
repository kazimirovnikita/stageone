USE Kursach
GO

/* Выборка всех ингридиентов */
CREATE PROCEDURE all_Ingredients
AS
	SELECT Name, Quantity, CostPrice FROM Ingredients
GO

EXEC all_Ingredients


/*Занести в таблицу Orders нового заказа*/
CREATE PROCEDURE insert_new_order (@id_Visitor AS INT, @id_Empoye AS INT, @id_Table AS INT, @id_Status AS INT, @bill AS INT, @status AS VARCHAR(30))
AS	INSERT INTO Orders (IdVisitor,IdEmployee, IdTable, IdStatus, Bill, Status) VALUES (@id_Visitor, @id_Empoye, @id_Table, @id_Status, @bill, @status);
GO*/

DECLARE @visitor int = 2,  @emp int= 3, @table int= 2, @status_ int = 2, @bill_ int = 1200, @stat varchar(30) = 'Завершен';
EXEC insert_new_order @visitor, @emp,  @table, @status_, @bill_, @stat;


/* Блюдо, которое еще не заказывали */
CREATE PROCEDURE Dish_that_not_ordered
AS
	SELECT Name FROM Menu
	WHERE NOT EXISTS 
	(SELECT * FROM OrderList WHERE OrderList.IdDish = Menu.IdDish)
GO

EXEC Dish_that_not_ordered


/* ТРИГЕР на чек в заказе */
CREATE TRIGGER orders_insert_trigger
ON Orders
AFTER INSERT, UPDATE 
AS
UPDATE Orders SET Bill = Bill + Bill* 0.3
	WHERE IdOrder = (SELECT IdOrder FROM INSERTED)
GO


