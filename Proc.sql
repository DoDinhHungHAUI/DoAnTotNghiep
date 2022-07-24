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
-- Create procedure `Proc_UpdateProduct`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_UpdateProduct (IN ProductId varchar(36), IN ProductName varchar(255), IN Alias varchar(255), IN CategoryID varchar(36), IN TypeProduct int, IN Image varchar(255), IN MoreImages varchar(255), IN Price decimal, IN PromotionPrice decimal, IN Warranty int, IN Description text, IN Quantity int, IN Content text)
BEGIN
  UPDATE product p
  SET p.ProductName = ProductName,
      p.Alias = 'Đỗ Đình Hưng',
      p.CategoryID = CategoryID,
      p.TypeProduct = TypeProduct,
      p.Image = Image,
      p.MoreImages = MoreImages,
      p.Price = Price,
      p.PromotionPrice = PromotionPrice,
      p.Warranty = Warranty,
      p.Description = Description,
      p.Quantity = Quantity,
      p.Content = Content,
      p.ModifiedDate = NOW()
  WHERE p.ProductId = ProductId;
END
$$

--
-- Create procedure `Proc_InsertUser`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_InsertUser (IN UserId varchar(36), IN UserName varchar(255), IN UserEmail varchar(255), IN PassWord varchar(255), IN UserPhone varchar(255), IN Address varchar(255))
BEGIN
  INSERT INTO user (UserId, UserName, PassWord, UserEmail, UserPhone, UserRole, Address, CreatedDate, CreatedBy)
    VALUES (UserId, UserName, PassWord, UserEmail, UserPhone, 0, Address, NOW(), '');
END
$$

--
-- Create procedure `Proc_InsertProductOrderDetail`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_InsertProductOrderDetail (IN $ProductOrderDetailId varchar(36), IN $ProductId varchar(36), IN $ProductName varchar(255), IN $ProductPrice decimal(10, 0), IN $Quantity int, IN $PromotionPrice decimal(10, 0), IN $Image varchar(255))
BEGIN
  -- ========================================
  -- Author : DDHung
  -- Store xử lý insert đơn hàng chi tiết  

  INSERT INTO productorderdetail (ProductOrderDetailId, ProductId, ProductOrderId, ProductName, ProductPrice, Quantity, PromotionPrice, Image)
    VALUES ($ProductOrderDetailId, $ProductId, $ProductName, $ProductPrice, $Quantity, $PromotionPrice, $Image);


END
$$

--
-- Create procedure `Proc_InsertProductOrder`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_InsertProductOrder (IN ProductOrderId varchar(36), IN UserId varchar(36), IN UserPhone varchar(255), IN UserName varchar(255), IN UserAddress varchar(255), IN UserEmail varchar(255), IN UserMessage text, IN Status int, IN CheckOrder int)
BEGIN

  INSERT INTO productorder (ProductOrderId, UserId, UserPhone, UserName, UserAddress, UserEmail, UserMessage, Status, CheckOrder, CreatedBy, CreatedDate, ModifiedDate, ModifiedBy)
    VALUES (ProductOrderId, UserId, UserPhone, UserName, UserAddress, UserEmail, UserMessage, Status, CheckOrder, '', NOW(), NOW(), '');


END
$$

--
-- Create procedure `Proc_InsertMultyProductOrderDetail`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_InsertMultyProductOrderDetail (IN lstEntity text)
BEGIN
  -- ======================================== 
  -- Author : DDHung
  -- Store xử lý insert nhiều bản ghi đơn hàng chi tiết  

  -- tạo bảng tạm lấy dữ liệu đơn hàng chi tiết

  DROP TEMPORARY TABLE IF EXISTS tmpProductDetailOrder;
  CREATE TEMPORARY TABLE tmpProductDetailOrder (
    ProductOrderDetailId varchar(36),
    ProductId varchar(36),
    ProductOrderId varchar(36),
    ProductName varchar(255),
    ProductPrice decimal,
    Quantity int,
    PromotionPrice decimal,
    Image varchar(355)
  );

  -- parse json thành table
  INSERT INTO tmpProductDetailOrder
    SELECT
      tmp.ProductOrderDetailId,
      tmp.ProductId,
      tmp.ProductOrderId,
      tmp.ProductName,
      tmp.ProductPrice,
      tmp.Quantity,
      tmp.PromotionPrice,
      tmp.Image
    FROM JSON_TABLE (lstEntity, '$[*]' COLUMNS (
    ProductOrderDetailId varchar(36) PATH '$.ProductOrderDetailId',
    ProductId varchar(36) PATH '$.ProductId',
    ProductOrderId varchar(36) PATH '$.ProductOrderId',
    ProductName varchar(255) PATH '$.ProductName',
    ProductPrice decimal PATH '$.ProductPrice',
    Quantity int PATH '$.Quantity',
    PromotionPrice decimal PATH '$.PromotionPrice',
    Image varchar(355) PATH '$.Image')) AS tmp;

  -- insert dữ liệu vào đơn hàng chi tiết
  INSERT INTO productorderdetail (ProductOrderDetailId, ProductId, ProductOrderId, ProductName, ProductPrice, Quantity, PromotionPrice, Image)
    SELECT
      tmp.ProductOrderDetailId,
      tmp.ProductId,
      tmp.ProductOrderId,
      tmp.ProductName,
      tmp.ProductPrice,
      tmp.Quantity,
      tmp.PromotionPrice,
      tmp.Image
    FROM tmpProductDetailOrder tmp;


END
$$

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
    a.PassWord,
    a.UserPhone,
    a.UserRole,
    a.Address,
    a.CreatedDate,
    a.CreatedBy,
    a.ModifiedBy,
    a.ModifiedDate
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

--
-- Create procedure `Proc_GetFooterProduct`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE Proc_GetFooterProduct ()
BEGIN
  SELECT
    *
  FROM footerproduct f;
END
$$

DELIMITER ;