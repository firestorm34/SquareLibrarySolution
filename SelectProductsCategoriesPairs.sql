CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name VARCHAR(100) NOT NULL
);

CREATE TABLE Products (
	Id int PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
);

CREATE TABLE ProductsCategories (
	Product_id  INT not null,
	Category_id INT not null
);

select prod.Name, cat.Name 
from Products prod
left join ProductsCategories prodcat on prod.Id = prodcat.Product_id
left join Categories cat on cat.Id = prodcat.Category_id
order by prod.Name;
