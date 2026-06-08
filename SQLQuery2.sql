UPDATE Users
SET FullName = 'Administrator'
WHERE FullName IS NULL;

UPDATE Users
SET Email = 'admin@gmail.com'
WHERE Email IS NULL;

UPDATE Users
SET Role = 'Admin'
WHERE Role IS NULL;