SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductId = PC.ProductId
LEFT JOIN Categories C ON PC.CategoryId = C.CategoryId;