-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: doantotnghiepdb
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `footerproduct`
--

DROP TABLE IF EXISTS `footerproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `footerproduct` (
  `FooterProductId` char(36) NOT NULL DEFAULT '',
  `FooterInfo` longtext,
  `FooterContact` longtext,
  `FooterHelp` longtext,
  PRIMARY KEY (`FooterProductId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `footerproduct`
--

LOCK TABLES `footerproduct` WRITE;
/*!40000 ALTER TABLE `footerproduct` DISABLE KEYS */;
INSERT INTO `footerproduct` VALUES ('e033721e-0580-11ed-9a9a-6c2b59645b10','Bán hàng Online Chăm sóc Khách Hàng Hỗ Trợ Kỹ thuật Hỗ trợ Bảo hành & Sửa chữa Liên hệ khối văn phòng','Danh sách 104 siêu thị trên toàn quốc','[\"43 Phố Nhổn, Thành Phố Hà Nội, Việt Nam\",\"0963514289\",\"dodinhhungHaui@gmail.com\"]');
/*!40000 ALTER TABLE `footerproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menuheader`
--

DROP TABLE IF EXISTS `menuheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menuheader` (
  `MenuHeaderId` char(36) NOT NULL DEFAULT '',
  `MenuHeaderName` varchar(255) DEFAULT NULL,
  `IsDropDown` int DEFAULT NULL COMMENT '1. Có dropdown, 2.Ko có dropdown',
  `SortOrder` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL COMMENT 'Dùng để sort menu theo thứ tự',
  `MenuLink` varchar(255) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8_general_ci DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MenuHeaderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menuheader`
--

LOCK TABLES `menuheader` WRITE;
/*!40000 ALTER TABLE `menuheader` DISABLE KEYS */;
INSERT INTO `menuheader` VALUES ('1680af60-0137-11ed-a724-6c2b59645b10','Trang Chủ',2,'MN01',NULL,NULL,NULL,NULL,NULL),('1680d16c-0137-11ed-a724-6c2b59645b10','Danh Mục',1,'MN02','danh-muc.html',NULL,NULL,NULL,NULL),('1680d2c9-0137-11ed-a724-6c2b59645b10','Thông tin',2,'MN03','thong-tin.html',NULL,NULL,NULL,NULL),('1680d38d-0137-11ed-a724-6c2b59645b10','Liên Hệ',2,'MN04','lien-he.html',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `menuheader` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductId` char(36) NOT NULL DEFAULT '' COMMENT 'Id sản phẩm',
  `ProductName` varchar(255) DEFAULT NULL COMMENT 'Tên sản phẩm',
  `Alias` varchar(255) DEFAULT NULL COMMENT 'Title sản phẩm',
  `CategoryID` char(36) NOT NULL DEFAULT '' COMMENT 'Id danh mục sản phẩm',
  `TypeProduct` int DEFAULT NULL COMMENT 'Loại sản phẩm',
  `Image` varchar(255) DEFAULT NULL COMMENT 'Hình ảnh sản phẩm',
  `MoreImages` varchar(255) DEFAULT NULL COMMENT 'Ảnh chi tiết sản phẩm',
  `Price` decimal(19,2) DEFAULT NULL COMMENT 'Giá sản phẩm',
  `PromotionPrice` decimal(19,2) DEFAULT NULL COMMENT 'Giá khuyến mãi của sản phẩm',
  `Warranty` int DEFAULT NULL COMMENT 'Bảo hành',
  `Description` longtext COMMENT 'Mô tả sản phẩm',
  `Quantity` int DEFAULT NULL COMMENT 'Số lượng sản phẩm',
  `Content` longtext COMMENT 'Nội dung sản phẩm',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ProductId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COMMENT='Table sản phẩm';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES ('27b7ea04-057e-11ed-9a9a-6c2b59645b10','Iphone 13','Iphone 13','a8d33e02-0236-11ed-a724-6c2b59645b10',1,'iphone-13-01.jpg','iphone-13-detail-01.jpg|iphone-13-detail-02.jpg|iphone-13-detail-03.jpg',11390000.00,10500000.00,12,'',8,'<h3>Hiệu năng mạnh mẽ với bộ vi xử l&yacute; mới</h3>  <p>Macbook Pro 2020 được trang bị con&nbsp;chip Apple M1&nbsp;độc quyền của Apple d&agrave;nh cho c&aacute;c d&ograve;ng Mac. CPU 8 l&otilde;i bao gồm&nbsp;<strong>4 l&otilde;i tiết kiệm điện</strong>&nbsp;v&agrave;&nbsp;<strong>4 l&otilde;i hiệu suất cao</strong>&nbsp;gi&uacute;p bạn ho&agrave;n th&agrave;nh c&aacute;c t&aacute;c vụ chuy&ecirc;n s&acirc;u như kết xuất 3D, chỉnh sửa h&igrave;nh ảnh, render video chuy&ecirc;n nghiệp qua c&aacute;c phần mềm như AI, Photoshop,... Đồng thời c&ograve;n cho tốc độ xử l&yacute; nhanh ch&oacute;ng gấp&nbsp;<strong>2.8</strong>&nbsp;<strong>lần</strong>&nbsp;c&aacute;c thế hệ Macbook trước, gi&uacute;p tiết kiệm năng lượng ti&ecirc;u thụ hiệu quả cho thời pin được k&eacute;o d&agrave;i.</p>  <p>Đi k&egrave;m theo đ&oacute; l&agrave;&nbsp;<strong>GPU 8 nh&acirc;n&nbsp;</strong>với khả năng xử l&yacute; cao v&agrave; th&ocirc;ng qua c&aacute;c b&agrave;i đ&aacute;nh gi&aacute; của benchmark, card cho hiệu suất xử l&yacute; gấp&nbsp;<strong>5 lần,&nbsp;</strong>bạn c&oacute; thể thoả sức s&aacute;ng tạo nội dung, ph&aacute;t trực tuyến, sử dụng c&aacute;c ứng dụng đồ họa chuy&ecirc;n nghiệp mượt m&agrave; với độ ph&acirc;n giải đạt chuẩn 4K.</p>  <p>Laptop sở hữu<strong>&nbsp;</strong>RAM 8 GB&nbsp;đ&aacute;p ứng tốt khả năng đa nhiệm, tức l&agrave; bạn c&oacute; thể mở nhiều ứng dụng c&ugrave;ng l&uacute;c m&agrave; m&aacute;y vẫn hoạt động ổn định</p>','2022-07-17 10:11:30',NULL,'2022-07-23 17:17:57',NULL),('38e3e5ca-056e-11ed-9a9a-6c2b59645b10','Iphone 13','Đỗ Đình Hưng','a8d33e02-0236-11ed-a724-6c2b59645b10',1,'iphone-13-01.jpg','iphone-13-detail-01.jpg|iphone-13-detail-02.jpg|iphone-13-detail-03.jpg',11390000.00,10500000.00,12,'',5,'<h3>Hiệu năng mạnh mẽ với bộ vi xử l&yacute; mới</h3>  <p>Macbook Pro 2020 được trang bị con&nbsp;chip Apple M1&nbsp;độc quyền của Apple d&agrave;nh cho c&aacute;c d&ograve;ng Mac. CPU 8 l&otilde;i bao gồm&nbsp;<strong>4 l&otilde;i tiết kiệm điện</strong>&nbsp;v&agrave;&nbsp;<strong>4 l&otilde;i hiệu suất cao</strong>&nbsp;gi&uacute;p bạn ho&agrave;n th&agrave;nh c&aacute;c t&aacute;c vụ chuy&ecirc;n s&acirc;u như kết xuất 3D, chỉnh sửa h&igrave;nh ảnh, render video chuy&ecirc;n nghiệp qua c&aacute;c phần mềm như AI, Photoshop,... Đồng thời c&ograve;n cho tốc độ xử l&yacute; nhanh ch&oacute;ng gấp&nbsp;<strong>2.8</strong>&nbsp;<strong>lần</strong>&nbsp;c&aacute;c thế hệ Macbook trước, gi&uacute;p tiết kiệm năng lượng ti&ecirc;u thụ hiệu quả cho thời pin được k&eacute;o d&agrave;i.</p>  <p>Đi k&egrave;m theo đ&oacute; l&agrave;&nbsp;<strong>GPU 8 nh&acirc;n&nbsp;</strong>với khả năng xử l&yacute; cao v&agrave; th&ocirc;ng qua c&aacute;c b&agrave;i đ&aacute;nh gi&aacute; của benchmark, card cho hiệu suất xử l&yacute; gấp&nbsp;<strong>5 lần,&nbsp;</strong>bạn c&oacute; thể thoả sức s&aacute;ng tạo nội dung, ph&aacute;t trực tuyến, sử dụng c&aacute;c ứng dụng đồ họa chuy&ecirc;n nghiệp mượt m&agrave; với độ ph&acirc;n giải đạt chuẩn 4K.</p>  <p>Laptop sở hữu<strong>&nbsp;</strong>RAM 8 GB&nbsp;đ&aacute;p ứng tốt khả năng đa nhiệm, tức l&agrave; bạn c&oacute; thể mở nhiều ứng dụng c&ugrave;ng l&uacute;c m&agrave; m&aacute;y vẫn hoạt động ổn định</p>','2022-07-17 08:17:27',NULL,'2022-07-23 20:44:51',NULL),('3e427dc7-0576-11ed-9a9a-6c2b59645b10','Iphone 13','Iphone 13','a8d33e02-0236-11ed-a724-6c2b59645b10',1,'iphone-13-01.jpg','iphone-13-detail-01.jpg|iphone-13-detail-02.jpg|iphone-13-detail-03.jpg',11390000.00,10500000.00,12,'',8,'<h3>Hiệu năng mạnh mẽ với bộ vi xử l&yacute; mới</h3>  <p>Macbook Pro 2020 được trang bị con&nbsp;chip Apple M1&nbsp;độc quyền của Apple d&agrave;nh cho c&aacute;c d&ograve;ng Mac. CPU 8 l&otilde;i bao gồm&nbsp;<strong>4 l&otilde;i tiết kiệm điện</strong>&nbsp;v&agrave;&nbsp;<strong>4 l&otilde;i hiệu suất cao</strong>&nbsp;gi&uacute;p bạn ho&agrave;n th&agrave;nh c&aacute;c t&aacute;c vụ chuy&ecirc;n s&acirc;u như kết xuất 3D, chỉnh sửa h&igrave;nh ảnh, render video chuy&ecirc;n nghiệp qua c&aacute;c phần mềm như AI, Photoshop,... Đồng thời c&ograve;n cho tốc độ xử l&yacute; nhanh ch&oacute;ng gấp&nbsp;<strong>2.8</strong>&nbsp;<strong>lần</strong>&nbsp;c&aacute;c thế hệ Macbook trước, gi&uacute;p tiết kiệm năng lượng ti&ecirc;u thụ hiệu quả cho thời pin được k&eacute;o d&agrave;i.</p>  <p>Đi k&egrave;m theo đ&oacute; l&agrave;&nbsp;<strong>GPU 8 nh&acirc;n&nbsp;</strong>với khả năng xử l&yacute; cao v&agrave; th&ocirc;ng qua c&aacute;c b&agrave;i đ&aacute;nh gi&aacute; của benchmark, card cho hiệu suất xử l&yacute; gấp&nbsp;<strong>5 lần,&nbsp;</strong>bạn c&oacute; thể thoả sức s&aacute;ng tạo nội dung, ph&aacute;t trực tuyến, sử dụng c&aacute;c ứng dụng đồ họa chuy&ecirc;n nghiệp mượt m&agrave; với độ ph&acirc;n giải đạt chuẩn 4K.</p>  <p>Laptop sở hữu<strong>&nbsp;</strong>RAM 8 GB&nbsp;đ&aacute;p ứng tốt khả năng đa nhiệm, tức l&agrave; bạn c&oacute; thể mở nhiều ứng dụng c&ugrave;ng l&uacute;c m&agrave; m&aacute;y vẫn hoạt động ổn định</p>','2022-07-17 09:14:52',NULL,'2022-07-23 17:17:57',NULL),('5312be4f-0575-11ed-9a9a-6c2b59645b10','Iphone 13','Iphone 13','a8d33e02-0236-11ed-a724-6c2b59645b10',1,'iphone-13-01.jpg','iphone-13-detail-01.jpg|iphone-13-detail-02.jpg|iphone-13-detail-03.jpg',11390000.00,10500000.00,12,'',8,'<h3>Hiệu năng mạnh mẽ với bộ vi xử l&yacute; mới</h3>  <p>Macbook Pro 2020 được trang bị con&nbsp;chip Apple M1&nbsp;độc quyền của Apple d&agrave;nh cho c&aacute;c d&ograve;ng Mac. CPU 8 l&otilde;i bao gồm&nbsp;<strong>4 l&otilde;i tiết kiệm điện</strong>&nbsp;v&agrave;&nbsp;<strong>4 l&otilde;i hiệu suất cao</strong>&nbsp;gi&uacute;p bạn ho&agrave;n th&agrave;nh c&aacute;c t&aacute;c vụ chuy&ecirc;n s&acirc;u như kết xuất 3D, chỉnh sửa h&igrave;nh ảnh, render video chuy&ecirc;n nghiệp qua c&aacute;c phần mềm như AI, Photoshop,... Đồng thời c&ograve;n cho tốc độ xử l&yacute; nhanh ch&oacute;ng gấp&nbsp;<strong>2.8</strong>&nbsp;<strong>lần</strong>&nbsp;c&aacute;c thế hệ Macbook trước, gi&uacute;p tiết kiệm năng lượng ti&ecirc;u thụ hiệu quả cho thời pin được k&eacute;o d&agrave;i.</p>  <p>Đi k&egrave;m theo đ&oacute; l&agrave;&nbsp;<strong>GPU 8 nh&acirc;n&nbsp;</strong>với khả năng xử l&yacute; cao v&agrave; th&ocirc;ng qua c&aacute;c b&agrave;i đ&aacute;nh gi&aacute; của benchmark, card cho hiệu suất xử l&yacute; gấp&nbsp;<strong>5 lần,&nbsp;</strong>bạn c&oacute; thể thoả sức s&aacute;ng tạo nội dung, ph&aacute;t trực tuyến, sử dụng c&aacute;c ứng dụng đồ họa chuy&ecirc;n nghiệp mượt m&agrave; với độ ph&acirc;n giải đạt chuẩn 4K.</p>  <p>Laptop sở hữu<strong>&nbsp;</strong>RAM 8 GB&nbsp;đ&aacute;p ứng tốt khả năng đa nhiệm, tức l&agrave; bạn c&oacute; thể mở nhiều ứng dụng c&ugrave;ng l&uacute;c m&agrave; m&aacute;y vẫn hoạt động ổn định</p>','2022-07-17 09:08:18',NULL,'2022-07-23 17:17:57',NULL),('58a0eccb-0574-11ed-9a9a-6c2b59645b10','Iphone 13','Iphone 13','a8d33e02-0236-11ed-a724-6c2b59645b10',1,'iphone-13-01.jpg','iphone-13-detail-01.jpg|iphone-13-detail-02.jpg|iphone-13-detail-03.jpg',11390000.00,10500000.00,12,'',8,'<h3>Hiệu năng mạnh mẽ với bộ vi xử l&yacute; mới</h3>  <p>Macbook Pro 2020 được trang bị con&nbsp;chip Apple M1&nbsp;độc quyền của Apple d&agrave;nh cho c&aacute;c d&ograve;ng Mac. CPU 8 l&otilde;i bao gồm&nbsp;<strong>4 l&otilde;i tiết kiệm điện</strong>&nbsp;v&agrave;&nbsp;<strong>4 l&otilde;i hiệu suất cao</strong>&nbsp;gi&uacute;p bạn ho&agrave;n th&agrave;nh c&aacute;c t&aacute;c vụ chuy&ecirc;n s&acirc;u như kết xuất 3D, chỉnh sửa h&igrave;nh ảnh, render video chuy&ecirc;n nghiệp qua c&aacute;c phần mềm như AI, Photoshop,... Đồng thời c&ograve;n cho tốc độ xử l&yacute; nhanh ch&oacute;ng gấp&nbsp;<strong>2.8</strong>&nbsp;<strong>lần</strong>&nbsp;c&aacute;c thế hệ Macbook trước, gi&uacute;p tiết kiệm năng lượng ti&ecirc;u thụ hiệu quả cho thời pin được k&eacute;o d&agrave;i.</p>  <p>Đi k&egrave;m theo đ&oacute; l&agrave;&nbsp;<strong>GPU 8 nh&acirc;n&nbsp;</strong>với khả năng xử l&yacute; cao v&agrave; th&ocirc;ng qua c&aacute;c b&agrave;i đ&aacute;nh gi&aacute; của benchmark, card cho hiệu suất xử l&yacute; gấp&nbsp;<strong>5 lần,&nbsp;</strong>bạn c&oacute; thể thoả sức s&aacute;ng tạo nội dung, ph&aacute;t trực tuyến, sử dụng c&aacute;c ứng dụng đồ họa chuy&ecirc;n nghiệp mượt m&agrave; với độ ph&acirc;n giải đạt chuẩn 4K.</p>  <p>Laptop sở hữu<strong>&nbsp;</strong>RAM 8 GB&nbsp;đ&aacute;p ứng tốt khả năng đa nhiệm, tức l&agrave; bạn c&oacute; thể mở nhiều ứng dụng c&ugrave;ng l&uacute;c m&agrave; m&aacute;y vẫn hoạt động ổn định</p>','2022-07-17 09:01:17',NULL,'2022-07-23 17:17:57',NULL),('f1627390-0572-11ed-9a9a-6c2b59645b10','Iphone 13','Đỗ Đình Hưng','a8d33e02-0236-11ed-a724-6c2b59645b10',1,'iphone-13-01.jpg','iphone-13-detail-01.jpg|iphone-13-detail-02.jpg|iphone-13-detail-03.jpg',11390000.00,10500000.00,12,'',5,'<h3>Hiệu năng mạnh mẽ với bộ vi xử l&yacute; mới</h3>  <p>Macbook Pro 2020 được trang bị con&nbsp;chip Apple M1&nbsp;độc quyền của Apple d&agrave;nh cho c&aacute;c d&ograve;ng Mac. CPU 8 l&otilde;i bao gồm&nbsp;<strong>4 l&otilde;i tiết kiệm điện</strong>&nbsp;v&agrave;&nbsp;<strong>4 l&otilde;i hiệu suất cao</strong>&nbsp;gi&uacute;p bạn ho&agrave;n th&agrave;nh c&aacute;c t&aacute;c vụ chuy&ecirc;n s&acirc;u như kết xuất 3D, chỉnh sửa h&igrave;nh ảnh, render video chuy&ecirc;n nghiệp qua c&aacute;c phần mềm như AI, Photoshop,... Đồng thời c&ograve;n cho tốc độ xử l&yacute; nhanh ch&oacute;ng gấp&nbsp;<strong>2.8</strong>&nbsp;<strong>lần</strong>&nbsp;c&aacute;c thế hệ Macbook trước, gi&uacute;p tiết kiệm năng lượng ti&ecirc;u thụ hiệu quả cho thời pin được k&eacute;o d&agrave;i.</p>  <p>Đi k&egrave;m theo đ&oacute; l&agrave;&nbsp;<strong>GPU 8 nh&acirc;n&nbsp;</strong>với khả năng xử l&yacute; cao v&agrave; th&ocirc;ng qua c&aacute;c b&agrave;i đ&aacute;nh gi&aacute; của benchmark, card cho hiệu suất xử l&yacute; gấp&nbsp;<strong>5 lần,&nbsp;</strong>bạn c&oacute; thể thoả sức s&aacute;ng tạo nội dung, ph&aacute;t trực tuyến, sử dụng c&aacute;c ứng dụng đồ họa chuy&ecirc;n nghiệp mượt m&agrave; với độ ph&acirc;n giải đạt chuẩn 4K.</p>  <p>Laptop sở hữu<strong>&nbsp;</strong>RAM 8 GB&nbsp;đ&aacute;p ứng tốt khả năng đa nhiệm, tức l&agrave; bạn c&oacute; thể mở nhiều ứng dụng c&ugrave;ng l&uacute;c m&agrave; m&aacute;y vẫn hoạt động ổn định</p>','2022-07-17 08:51:15',NULL,'2022-07-23 20:44:51',NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productcategory`
--

DROP TABLE IF EXISTS `productcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productcategory` (
  `ProductCategoryId` char(36) NOT NULL DEFAULT '' COMMENT 'Id danh mục sản phẩm',
  `ProductCategoryName` varchar(255) DEFAULT NULL COMMENT 'Tên danh mục sản phẩm',
  `MenuHeaderId` char(36) DEFAULT NULL,
  `ProductCategoryLink` varchar(255) DEFAULT NULL,
  `Alias` varchar(255) DEFAULT NULL COMMENT 'alias sản phẩm',
  `Description` longtext COMMENT 'Mô tả sản phẩm',
  `ParentID` char(36) DEFAULT NULL COMMENT 'Danh mục cha',
  `DisplayOrder` int DEFAULT NULL COMMENT 'Thứ tự sắp xếp',
  `Image` varchar(255) DEFAULT NULL COMMENT 'Ảnh danh mục',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ProductCategoryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COMMENT='Bảng danh mục';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcategory`
--

LOCK TABLES `productcategory` WRITE;
/*!40000 ALTER TABLE `productcategory` DISABLE KEYS */;
INSERT INTO `productcategory` VALUES ('1a12af4d-057e-11ed-9a9a-6c2b59645b10','Máy Tính Bảng','1680d16c-0137-11ed-a724-6c2b59645b10','may-tinh-bang','Máy Tính Bảng','Máy Tính Bảng','a8d39ddb-0236-11ed-a724-6c2b59645b10',4,'',NULL,NULL,NULL,NULL),('a8d33e02-0236-11ed-a724-6c2b59645b10','Điện Thoại','1680d16c-0137-11ed-a724-6c2b59645b10','dien-thoai','Điện Thoại','Điện Thoại','a8d33e36-0236-11ed-a724-6c2b59645b10',1,'',NULL,NULL,NULL,NULL),('a8d39c8e-0236-11ed-a724-6c2b59645b10','LapTop','1680d16c-0137-11ed-a724-6c2b59645b10','laptop','Điện Thoại','Điện Thoại','a8d39ca2-0236-11ed-a724-6c2b59645b10',2,'',NULL,NULL,NULL,NULL),('a8d39dd1-0236-11ed-a724-6c2b59645b10','Tivi','1680d16c-0137-11ed-a724-6c2b59645b10','tivi','Điện Thoại','Điện Thoại','a8d39ddb-0236-11ed-a724-6c2b59645b10',3,'',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `productcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productorder`
--

DROP TABLE IF EXISTS `productorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productorder` (
  `ProductOrderId` char(36) NOT NULL DEFAULT '',
  `UserId` char(36) DEFAULT NULL COMMENT 'Id người dùng',
  `UserPhone` varchar(255) DEFAULT NULL COMMENT 'Số điện thoại người dùng',
  `UserName` varchar(255) DEFAULT NULL COMMENT 'Tên sản phẩm',
  `UserAddress` varchar(255) DEFAULT NULL COMMENT 'Giá sản phẩm',
  `UserEmail` varchar(255) DEFAULT NULL COMMENT 'Giá khuyến mãi',
  `UserMessage` longtext,
  `Status` int DEFAULT NULL COMMENT 'Trang thái đặt hàng : 1.chưa đặt hàng, 2. đã đặt hàng',
  `CheckOrder` int DEFAULT NULL COMMENT '1. người dùng nhập thông tin, 2.người dùng đăng nhập',
  `CreatedBy` varchar(255) DEFAULT NULL COMMENT 'người tạo',
  `CreatedDate` datetime DEFAULT NULL COMMENT 'Ngày tạo',
  `ModifiedDate` datetime DEFAULT NULL COMMENT 'Ngày sửa đổi',
  `ModifiedBy` varchar(255) DEFAULT NULL COMMENT 'Người sửa đổi',
  PRIMARY KEY (`ProductOrderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productorder`
--

LOCK TABLES `productorder` WRITE;
/*!40000 ALTER TABLE `productorder` DISABLE KEYS */;
INSERT INTO `productorder` VALUES ('1aef826c-15e2-430b-86dc-c53d635bc176',NULL,'','','','',NULL,1,NULL,'','2022-07-23 17:34:37','2022-07-23 17:34:37',''),('2709211a-2cde-4681-a697-1855a1c29074',NULL,'','','','',NULL,1,NULL,'','2022-07-23 20:44:11','2022-07-23 20:44:11',''),('6938041f-f095-4fc6-b8ec-a53822372b5e',NULL,'','','','',NULL,1,NULL,'','2022-07-23 20:44:51','2022-07-23 20:44:51',''),('774bb404-2d82-4020-ae9b-80209940e8f8',NULL,'','','','',NULL,1,NULL,'','2022-07-23 17:32:32','2022-07-23 17:32:32',''),('976a74c2-f4e6-4966-b279-2f1f968cfc49',NULL,'0963514289','Đỗ Đình Hưng','Hà Nội','hungonlineshop@gmail.com',NULL,1,NULL,'','2022-07-23 17:32:01','2022-07-23 17:32:01',''),('b6de712f-0e86-4855-8d53-eb4c5b40f84b',NULL,'0963514289','Đỗ Đình Hưng','Hà Nội','hungonlineshop@gmail.com',NULL,1,NULL,'','2022-07-23 17:17:57','2022-07-23 17:17:57','');
/*!40000 ALTER TABLE `productorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productorderdetail`
--

DROP TABLE IF EXISTS `productorderdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productorderdetail` (
  `ProductOrderDetailId` char(36) NOT NULL DEFAULT '',
  `ProductId` char(36) DEFAULT NULL,
  `ProductOrderId` char(36) NOT NULL DEFAULT '',
  `ProductName` varchar(255) DEFAULT NULL COMMENT 'Tên sản phẩm',
  `ProductPrice` decimal(19,2) DEFAULT NULL COMMENT 'Giá sản phẩm',
  `Quantity` int DEFAULT NULL COMMENT 'Số lượng',
  `PromotionPrice` decimal(19,2) DEFAULT NULL COMMENT 'Giá khuyến mãi',
  `Image` varchar(255) DEFAULT NULL COMMENT 'Hình ảnh sản phẩm',
  PRIMARY KEY (`ProductOrderDetailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productorderdetail`
--

LOCK TABLES `productorderdetail` WRITE;
/*!40000 ALTER TABLE `productorderdetail` DISABLE KEYS */;
INSERT INTO `productorderdetail` VALUES ('22cbe5d7-b6ae-448d-8f29-ba297c1a7de3','f1627390-0572-11ed-9a9a-6c2b59645b10','976a74c2-f4e6-4966-b279-2f1f968cfc49',NULL,11390000.00,1,NULL,NULL),('24ad7d39-118a-44cc-9066-1d022c5bbb07','38e3e5ca-056e-11ed-9a9a-6c2b59645b10','6938041f-f095-4fc6-b8ec-a53822372b5e',NULL,11390000.00,1,NULL,NULL),('3f38895c-4e7a-445e-b99f-2a1527d37e60','38e3e5ca-056e-11ed-9a9a-6c2b59645b10','774bb404-2d82-4020-ae9b-80209940e8f8',NULL,11390000.00,1,NULL,NULL),('65347fe8-33e6-42f9-a306-b7197d097a24','f1627390-0572-11ed-9a9a-6c2b59645b10','1aef826c-15e2-430b-86dc-c53d635bc176',NULL,11390000.00,1,NULL,NULL),('6c35b4ef-0778-4616-8320-933d8f2ac8a4','58a0eccb-0574-11ed-9a9a-6c2b59645b10','b6de712f-0e86-4855-8d53-eb4c5b40f84b',NULL,11390000.00,1,NULL,NULL),('b67eadd1-3346-426d-a2a3-46a24c4de587','f1627390-0572-11ed-9a9a-6c2b59645b10','b6de712f-0e86-4855-8d53-eb4c5b40f84b',NULL,11390000.00,1,NULL,NULL),('d24e753a-e314-4ff7-a35f-96ab7e439405','38e3e5ca-056e-11ed-9a9a-6c2b59645b10','976a74c2-f4e6-4966-b279-2f1f968cfc49',NULL,11390000.00,1,NULL,NULL),('d77ffe93-d689-48e9-b092-530580a1b59d','38e3e5ca-056e-11ed-9a9a-6c2b59645b10','1aef826c-15e2-430b-86dc-c53d635bc176',NULL,11390000.00,100,NULL,NULL),('fc09fc7b-d81c-48c8-a100-760e680b4f9d','f1627390-0572-11ed-9a9a-6c2b59645b10','6938041f-f095-4fc6-b8ec-a53822372b5e',NULL,11390000.00,1,NULL,NULL);
/*!40000 ALTER TABLE `productorderdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `slide`
--

DROP TABLE IF EXISTS `slide`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `slide` (
  `SlideId` char(36) NOT NULL DEFAULT '' COMMENT 'Id slide',
  `SlideName` varchar(255) DEFAULT NULL COMMENT 'Tên Slide',
  `Image` varchar(255) DEFAULT NULL,
  `Description` longtext COMMENT 'Mô tả slide',
  `Content` longtext COMMENT 'Nội dung slide',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  `ModifiedBy` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`SlideId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `slide`
--

LOCK TABLES `slide` WRITE;
/*!40000 ALTER TABLE `slide` DISABLE KEYS */;
INSERT INTO `slide` VALUES ('b6deef5e-0131-11ed-a724-6c2b59645b10','','image-slider-2.png','bg_2.jpg','',NULL,NULL,NULL,NULL),('b6eafa4f-0131-11ed-a724-6c2b59645b10','','image-slider-1.png','bg_2.jpg','',NULL,NULL,NULL,NULL),('b6eafdf7-0131-11ed-a724-6c2b59645b10','','image-slider-3.png','bg_2.jpg','',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `slide` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserId` char(36) NOT NULL DEFAULT '',
  `UserName` varchar(255) DEFAULT NULL COMMENT 'Tên người dung',
  `PassWord` varchar(255) DEFAULT NULL,
  `UserEmail` varchar(255) DEFAULT NULL COMMENT 'Email người dùng',
  `UserPhone` varchar(255) DEFAULT NULL COMMENT 'Số điện thoại',
  `UserRole` int DEFAULT NULL COMMENT 'Phân quyền cho user',
  `Address` varchar(255) DEFAULT NULL COMMENT 'Địa chỉ người dùng',
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) DEFAULT NULL,
  `ModifiedBy` varchar(255) DEFAULT NULL,
  `ModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('60471158-002a-11ed-b343-6c2b59645b10','Đỗ Đình Hưng','abc','HungMien0411@gmail.com','09287382',0,'','2022-07-10 15:29:12','','','2022-07-10 15:29:12'),('7cea8fbc-4bbc-4787-86fd-43a3c25a990c','Đỗ Đình Hưng','abcABC123','HungMien@gmail.com','0927783833',0,'Quốc Oai - Hà Nội','2022-07-24 22:34:55','',NULL,NULL);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-24 23:12:05
