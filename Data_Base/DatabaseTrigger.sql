CREATE TRIGGER [DatabaseTrigger]
ON DATABASE
FOR DDL_TABLE_VIEW_EVENTS
AS
BEGIN
	SET NOCOUNT ON
END

GO
CREATE TRIGGER Products1_INSERT_UPDATE
ON dbo.Orders
AFTER INSERT, UPDATE
AS
UPDATE Orders
SET Quantity = Quantity + Quantity * 0.38
WHERE Id = (SELECT Id FROM inserted)




GO
CREATE TRIGGER Products2_INSERT_UPDATE
ON dbo.Orders
AFTER INSERT, UPDATE
AS
UPDATE Orders
SET Price = Price + Price * 0.38
WHERE Id = (SELECT Id FROM inserted)




GO
CREATE TRIGGER Delivery_INSERT_UPDATE
ON dbo.Deliveries
AFTER INSERT, UPDATE
AS
UPDATE Deliveries
SET Quantity = Quantity + Quantity * 0.38
WHERE Id = (SELECT Id FROM inserted)




GO
CREATE TRIGGER Loog3
ON dbo.Orders
AFTER INSERT
AS
INSERT INTO [LoggningClassess].Logging
SELECT Price
FROM INSERTED


GO
CREATE TRIGGER Loog4
ON dbo.Orders
AFTER INSERT
AS
INSERT INTO [LoggningClassess].Logging
SELECT Quantity
FROM INSERTED




GO
CREATE TRIGGER Loog5
ON dbo.Orders
AFTER UPDATE
AS
INSERT INTO [LoggningClassess].Logging
SELECT CONCAT( DateTime, Price)
FROM INSERTED





GO
CREATE TRIGGER Loog1
ON dbo.CustomerProfiles
AFTER INSERT
AS
INSERT INTO [LoggningClassess].Logging
SELECT PhoneNumber
FROM INSERTED






GO
CREATE TRIGGER RowCou
ON Orders
FOR INSERT
AS
    IF @@ROWCOUNT = 0
        RETURN
   
    SET NOCOUNT ON
    
    UPDATE Stocks
    SET Quantity = s.Quantity - i.Quantity
    FROM Stocks s JOIN
    inserted i
    ON s.ProductID = i.ProductID







