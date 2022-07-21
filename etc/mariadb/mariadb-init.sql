DROP USER IF EXISTS 'azuremyst';
CREATE USER 'azuremyst'@'%' IDENTIFIED BY 'azuremyst';
GRANT ALL PRIVILEGES ON *.* TO 'azuremyst'@'%' IDENTIFIED BY 'azuremyst';
FLUSH PRIVILEGES;
