UPDATE Suppliers
SET ContactPerson = ''
WHERE ContactPerson IS NULL;

UPDATE Suppliers
SET Phone = ''
WHERE Phone IS NULL;

UPDATE Suppliers
SET Email = ''
WHERE Email IS NULL;