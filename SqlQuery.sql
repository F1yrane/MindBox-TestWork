SELECT p.ProductName, 
	COALESCE (c.CategoryName, 'Без категории') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID
ORDER BY p.ProductName, CategoryName;

/* 
использовал LEFT JOIN чтобы включить все продукты
даже если  у них нет категорий
и соединить с таблицами Products, ProductCategories и Categories 
*/