-- INSERT into [Tablo Adi] ([Kolon Adı 1], [Kolon Adı 2], [Kolon Adı N])
--        values           ([Değer1],      [Değer2],      [DeğerN])

INSERT into Categories(CategoryName, Description)
                values('Tatlılar', 'Her türlü Türk tatlıları') 

--T-SQL: Transact - Structured Query Language
--UPDATE
-- UPDATE [TabloAdi] SET [Kolon Adı 1]=[Değer1], [Kolon Adı 2]=[Değer2]
-- WHERE [Koşul]

Update Categories SET Description='Türk mutfağında bulunan eşsiz tatlı lezzetler'
WHERE CategoryId = 9

Select * from Employees
           


