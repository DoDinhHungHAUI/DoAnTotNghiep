-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: doantotnghiepdb
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `menuheader`
--

DROP TABLE IF EXISTS `menuheader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menuheader` (
  `MenuHeaderId` char(36) NOT NULL DEFAULT '',
  `MenuHeaderName` varchar(255) DEFAULT NULL,
  `IsDropDown` int DEFAULT NULL COMMENT '1. Có dropdown, 2.Ko có dropdown',
  `SortOrder` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL COMMENT 'Dùng để sort menu theo thứ tự',
  `MenuLink` varchar(255) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CreatedBy` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
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
INSERT INTO `product` VALUES ('2ff4424c-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ff4429c-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffae93d-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffae960-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffaeb9d-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffaeba6-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffaec19-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffaec20-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffaec7f-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffaec85-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffaece0-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffaece8-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffaed46-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffaed4d-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL),('2ffaef7f-0123-11ed-a724-6c2b59645b10','Điện thoại abc','','2ffaef88-0123-11ed-a724-6c2b59645b10','product-1.jpg','',100000.00,0.00,0,'',0,'',NULL,NULL,NULL,NULL);
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
INSERT INTO `productcategory` VALUES ('a8d33e02-0236-11ed-a724-6c2b59645b10','Điện Thoại','1680d16c-0137-11ed-a724-6c2b59645b10','danh-muc-dien-thoai','Điện Thoại','Điện Thoại','a8d33e36-0236-11ed-a724-6c2b59645b10',1,'',NULL,NULL,NULL,NULL),('a8d39c8e-0236-11ed-a724-6c2b59645b10','LapTop','1680d16c-0137-11ed-a724-6c2b59645b10','danh-muc-laptop','Điện Thoại','Điện Thoại','a8d39ca2-0236-11ed-a724-6c2b59645b10',2,'',NULL,NULL,NULL,NULL),('a8d39dd1-0236-11ed-a724-6c2b59645b10','Tivi','1680d16c-0137-11ed-a724-6c2b59645b10','danh-muc-tivi','Điện Thoại','Điện Thoại','a8d39ddb-0236-11ed-a724-6c2b59645b10',3,'',NULL,NULL,NULL,NULL);
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
  `UserName` varchar(255) DEFAULT NULL COMMENT 'Tên sản phẩm',
  `UserAddress` varchar(255) DEFAULT NULL COMMENT 'Giá sản phẩm',
  `UserEmail` varchar(255) DEFAULT NULL COMMENT 'Giá khuyến mãi',
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
INSERT INTO `user` VALUES ('60471158-002a-11ed-b343-6c2b59645b10','Đỗ Đình Hưng','HungMien0411@gmail.com','09287382',0,'','2022-07-10 15:29:12','','','2022-07-10 15:29:12');
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

-- Dump completed on 2022-07-16 15:33:30
