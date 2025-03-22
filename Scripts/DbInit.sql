CREATE DATABASE ShopDB;
GO

USE ShopDB;
GO

CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL
);

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    CategoryId INT,
    Description NVARCHAR(MAX),
    Price DECIMAL(10,2) NOT NULL,
    IsAvaliable BIT NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id) ON DELETE SET NULL
);

INSERT INTO Categories (Name) VALUES ('Bluzy'), ('Koszulki'), ('Dodatki');
GO

INSERT INTO Products (Name, CategoryId, Description, Price, IsAvaliable) VALUES
    ('Bluza z kapturem', 1, 'Ciep�a bluza z kapturem', 149.99, 1),
    ('Bluza oversize', 1, 'Lu�na bluza unisex', 129.99, 1),
    ('Bluza z nadrukiem', 1, 'Modna bluza z grafik�', 159.99, 1),
    ('Bluza polarowa', 1, 'Mi�kka bluza z polaru', 179.99, 1),
    ('Bluza sportowa', 1, 'Wygodna bluza do treningu', 139.99, 1),
    ('Koszulka basic', 2, 'Prosta koszulka bawe�niana', 49.99, 1),
    ('Koszulka sportowa', 2, 'Oddychaj�ca koszulka na si�owni�', 69.99, 1),
    ('Koszulka premium', 2, 'Wysokiej jako�ci koszulka bawe�niana', 89.99, 1),
    ('Koszulka z grafik�', 2, 'Koszulka z designerskim nadrukiem', 59.99, 1),
    ('Koszulka termoaktywna', 2, 'Idealna na aktywno�� fizyczn�', 99.99, 1),
    ('Czapka z daszkiem', 3, 'Stylowa czapka na lato', 39.99, 1),
    ('Skarpetki kolorowe', 3, 'Zestaw 3 par skarpet w r�nych wzorach', 29.99, 1),
    ('Plecak sportowy', 3, 'Lekki i pojemny plecak', 99.99, 1),
    ('Saszetka na pas', 3, 'Praktyczna nerka na pas', 79.99, 1),
    ('R�kawiczki zimowe', 3, 'Ciep�e r�kawiczki na ch�odne dni', 49.99, 1);
GO



