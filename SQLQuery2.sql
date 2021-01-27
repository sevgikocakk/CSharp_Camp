-- Select seç demektir. 
-- * hepsini getir demektir. 
-- from şuradan seç getir anlamına gelir.
-- SQL case insensetivedir, yani büyük küçük harf duyarlılığı yoktur.
-- sorgular seçilerek çalıştırılır.
Select * from Customers -- demek customaers tablosunda ki her şeyi getir demek.

select CustomerID,City  from Customers --Select den sonra kolon adı gelir. 

select ProductName ürünadi , CategoryID kategoriId from Products 
-- burada ki ürün adı ve kategoriId alias yani takma addır. Sorgu sonucunu getirirken bana bu isimler ile getir demek gibi düşünebiliriz.

select * from Customers where City = 'London' -- whwere şuna göre listele filtrele demektir.
-- metinsel ifadeler '..' arasına yazılır. ANSII standartlarında tek tırnak ile yazılır.

select * from Products where CategoryID=1

select * from Products where CategoryID=1 or CategoryID=3 -- or yada demektir categoriIdsi 1 veya 3 olanı getir demektir.

select * from Products  where CategoryID=1 and UnitPrice= 18 -- and de iki şartın da sağlanması gerekir.
-- <> 10 dan farksız yani eşit değil demek.

select * from Products order by ProductName -- ordey by sırala demektir asc default özelliğidir.
-- bütün ürünleri seç ama ürün ismine göre sırala demektir.

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice asc -- ascending artan demek

select * from Products order by UnitPrice desc --descending azalan düşen demek

select * from Products where CategoryID = 1 order by UnitPrice desc
-- categoryIdsi 1 olanları filtrele  fiyatı azalana göre sırala demek

select count(*) from Products -- count adet demek, products tablosunda tüm datayı verir

select count(*) adet  from Products where CategoryID = 2 --categoryId 2 olan kaç ürün varsa getir demek

select CategoryID from Products group by CategoryID -- group by gruplama yapar.

select CategoryID,count(*)from Products group by CategoryID -- her bir grup elemanı için ayrı ayrı count hesaplanır.

select CategoryID,count(*)from Products group by CategoryID having count(*)<10
--havingi group baya konu olan kümelatiflere uygularız

select CategoryID,count(*)from Products where UnitPrice>20 --önce her zaman where çalışır
group by CategoryID having count(*)<10 --birim fiyatı 20 den fazla olan ürünleri kategoriıd e
--göre grupla sayısı 10 dan küçük olanları getir

select * from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

--inner join sadece iki tabloda da eşleşen verileri getirir.iki tabloda da ortak olan kolunu
-- bulmamamız gerekir.

select Products.ProductID , Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select * from Products p left join [Order Details] od 
on p.ProductID = od.ProductID
-- solda olup sağda olmayanları getir demektir

select * from Customers c left join Orders o
on c.CustomerID = CustomerID

select * from Customers c left join Orders o
on c.CustomerID = CustomerID
where o.CustomerID is null -- null demek yok demek












