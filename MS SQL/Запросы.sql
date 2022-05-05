USE Kursach
GO

/* Все сотрудники */
SELECT Name, Surname, Post, Salary FROM Employees*/


/* Все возможные сотрудники и покупатели */
SELECT Employees.Name, Employees.Surname
FROM Employees
UNION
SELECT Visitors.Name, Visitors.Surname
FROM Visitors


/* Поставщики, которые представлены в Закупке Ингридиентов */
SELECT * FROM Suppliers
WHERE IdSupplier IN 
(SELECT idSupplier FROM PurchasesIngredients) 


/* Блюдо, которе никто не заказывал */
SELECT Name FROM Menu
WHERE NOT EXISTS 
(SELECT * FROM OrderList WHERE OrderList.IdDish = Menu.IdDish)


/* Состав Заказа */
SELECT  OrderList.IdOrder, Menu.Name, Menu.Price, Menu.CostPrice, OrderList.Quantity, Orders.IdTable 
FROM OrderList
JOIN Menu ON OrderList.IdDish=Menu.IdDish
JOIN Orders ON OrderList.IdOrder=Orders.IdOrder


/* Необходимые ингридиенты для приготовления определённого блюда */
SELECT  Menu.Name, Menu.Price, Ingredients.Name, СompositionОfDishes.Quantity
FROM Menu INNER
JOIN СompositionОfDishes ON СompositionОfDishes.IdDish = Menu.IdDish
INNER JOIN Ingredients ON СompositionОfDishes.IdIngredient  =Ingredients.IdIngredient 
where СompositionОfDishes.IdDish = 1


/* Что необходимо заказть */
SELECT  Storage.Name FROM Ingredients 
	JOIN Storage ON Ingredients.IdIngredient = Storage.IdIngredient
        WHERE Storage.Quantity - Ingredients.Quantity < '0'

/* Ингридиенты которые использовались в блюдах */
SELECT Name From Ingredients
WHERE EXISTS 
(SELECT * FROM  СompositionОfDishes WHERE Ingredients.IdIngredient = СompositionОfDishes.IdIngredient) 


/* Ингридиент которого нет на скалде но есть в закупке */
SELECT PurchasesIngredients.Name FROM PurchasesIngredients
EXCEPT 
SELECT Storage.Name FROM Storage

/* Сотрудник с большим количесвтом закзаков */
SELECT Count(*) AS Number_Of_orders, Name, Surname, Post
	FROM Orders INNER JOIN Employees ON Orders.IdEmployee=Employees.IdEmployee
GROUP BY Orders.IdEmployee, Employees.Name, Employees.Surname, Employees.Post
HAVING Count(Orders.IdOrder)>Max(1)


/* Общая выручка */
SELECT
 Sum(OrderList.Price * OrderList.Quantity)
    AS Price, Count(*) AS Количество_блюд 
    FROM Orders INNER JOIN OrderList
ON Orders.IdOrder=OrderList.IdOrder


/* Показывает у каждого сотрудника информацию о заказе и его статус */
SELECT Employees.IdEmployee, Employees.Name, Orders.IdOrder, Bill.Bill, Orders.IdTable, Visitors.Name, StatusOrders.Status FROM Orders
	JOIN Employees ON Orders.IdEmployee=Employees.IdEmployee
	JOIN Visitors ON Orders.IdVisitor=Visitors.IdVisitor
	JOIN Bill ON Orders.IdOrder=Bill.IdOrder
	JOIN StatusOrders ON Orders.IdOrder=StatusOrders.IdStatus
		WHERE Employees.IdEmployee = 1



---------------



SELECT OrderList.IdOrder, Menu.Name, OrderList.Quantity, OrderList.Price, StatusOrders.Status FROM OrderList
	JOIN Menu ON Menu.IdDish = OrderList.IdDish
	JOIN StatusOrders ON StatusOrders.IdOrder = OrderList.IdOrder
		WHERE OrderList.IdOrder = (SELECT IdOrder FROM Orders Where IdVisitor = '1')
	--JOIN Employees ON Employees.IdEmployee = Orders.IdOrder














SELECT Reviews.IdVisitor, Visitors.Name, Visitors.Surname, Rating, Comment FROM Reviews
         JOIN Visitors ON Visitors.IdVisitor = Reviews.IdVisitor






/* Самое популярное блюдо */
SELECT Count(*) AS  Quantity, Name, Menu.Price 
	FROM OrderList INNER JOIN Menu ON OrderList.IdDish=Menu.IdDish
	INNER JOIN Orders ON OrderList.IdOrder=Orders.IdOrder
		GROUP BY Menu.Name, Menu.Price
			HAVING Count(OrderList.Quantity)>Max(Quantity)


SELECT NumberOfTable FROM Tables 
	EXCEPT
	SELECT IdTable  FROM BookedTables

SELECT OrderList.IdOrder, Menu.Name, OrderList.Quantity, OrderList.Price, StatusOrders.Status FROM OrderList
                JOIN Menu ON Menu.IdDish = OrderList.IdDish 
                JOIN StatusOrders ON StatusOrders.IdOrder = OrderList.IdOrder 
               WHERE OrderList.IdOrder = (SELECT IdOrder FROM Orders Where IdVisitor = '3')

SELECT * FROM OrderList
   WHERE OrderList.IdOrder = (SELECT IdOrder FROM Orders Where IdVisitor = '3')             
				
				JOIN Menu ON Menu.IdDish = OrderList.IdDish 
                JOIN StatusOrders ON StatusOrders.IdOrder = OrderList.IdOrder 
               WHERE OrderList.IdOrder = (SELECT IdOrder FROM Orders Where IdVisitor = '3')


SELECT OrderList.IdOrder, Menu.Name, OrderList.Quantity, OrderList.Price, StatusOrders.Status FROM OrderList
                JOIN Menu ON Menu.IdDish = OrderList.IdDish 
				JOIN Orders ON Orders.IdOrder = OrderList.IdOrder
                JOIN StatusOrders ON StatusOrders.IdOrder = OrderList.IdOrder 
               WHERE Orders.IdVisitor =  '3'


INSERT INTO OrderList (IdOrder, IdDish, Quantity, Price) VALUES ((SELECT IdOrder FROM Orders Where IdVisitor = 3 AND IdTable = (SELECT IdTable FROM Tables Where NumberOfTable = 5))
                                                    (SELECT IdDish FROM Menu Where Name = 1)
                                                    2, (SELECT Price FROM Menu Where Name = 'Борщ'))