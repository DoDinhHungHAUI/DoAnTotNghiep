-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8';

--
-- Set default database
--
USE doantotnghiepdb;

DELIMITER $$

--
-- Create procedure `Proc_GetUser`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_GetUser ()
BEGIN

  SELECT
    a.UserId,
    a.UserName,
    a.UserEmail,
    a.UserPhone,
    a.Address
  FROM user a;

END
$$

--
-- Create procedure `Proc_GetSlide`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_GetSlide ()
BEGIN
  SELECT
    s.SlideId,
    s.SlideName,
    s.Image,
    s.Description,
    s.Content
  FROM slide s;
END
$$

--
-- Create procedure `Proc_GetProductCategory`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_GetProductCategory ()
BEGIN
  SELECT
    *
  FROM productcategory p;
END
$$

--
-- Create procedure `Proc_GetProduct`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_GetProduct ()
BEGIN
  SELECT
    *
  FROM product p;
END
$$

--
-- Create procedure `Proc_GetMenuHeader`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_GetMenuHeader ()
BEGIN
  SELECT
    *
  FROM menuheader m;
END
$$

DELIMITER ;