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
INSERT INTO `product` VALUES ('11030bc8-0835-415a-bcb3-d1d771377341','laptop dell 15','laptop dell 15','9d841751-82e3-4d8c-bbd3-4c9eb80f67f6',2,'laptop-del224718634.jpg',NULL,18000000.00,16000000.00,12,NULL,10,'Ngoài ra, công nghệ WVA (Wide Viewing Angle) còn giúp mang đến khung hình mở rộng lên đến 178 độ Công nghệ Anti Glare cho phép bạn làm việc trong thời gian dài ở những nơi có điều kiện ánh sáng kém mà không bị mỏi hay chói mắt.','2022-08-13 17:47:18','',NULL,NULL),('1be8df2f-63e0-44e3-aacd-f50f3ff8389a','Laptop Macbook Air 13','laptop macbook','9d841751-82e3-4d8c-bbd3-4c9eb80f67f6',2,'laptop-mac224329823.jpg',NULL,29000000.00,28000000.00,12,NULL,4,'Là một chiếc ultrabook cao cấp, MacBook Air mang trên mình tất cả thẩm mỹ tinh tế của Apple trong thiết kế sản phẩm. MacBook Air M1 được hoàn thiện từ chất liệu nhôm nguyên khối, không chỉ nhẹ mà còn rất sang trọng. Trọng lượng chỉ 1,29kg cũng giúp người dùng tiện lợi mang đi sử dụng ở mọi nơi. Khách hàng có thể lựa chọn ba phiên bản màu khác nhau phù hợp với cả tính mỗi người, bao gồm xám, bạc và vàng.','2022-08-13 17:43:29','','2022-08-20 16:57:02',NULL),('2e47f876-e512-41c8-9840-d6c227d51d13','Iphone 13','dien thoai ','2a42a979-29d8-4c7f-9b34-b86ef667cfac',1,'iphone-13-224121274.jpg',NULL,23000000.00,21000000.00,12,NULL,1,'Với những cải tiến không ngừng nghỉ cho những sản phẩm điện thoại thông minh của mình, Apple là hãng smartphone luôn nhận được sự tin tưởng từ người tiêu dùng Việt Nam. Dòng sản phẩm iPhone 13 được ra mắt gần đây với màu sắc mới và nâng cấp đáng kể về phần cứng của điện thoại đang nhận được rất nhiều sự quan tâm từ người hâm mộ.   ','2022-08-11 21:41:21','','2022-08-20 16:32:35',NULL),('428c7810-c91d-4c25-8a5c-59036ccc7afb','Samsung Galaxy S8','samsung galaxy','2a42a979-29d8-4c7f-9b34-b86ef667cfac',1,'samsung-ga223821366.jpg',NULL,15000000.00,12500000.00,10,NULL,4,'Samsung Galaxy Tab S8 sở hữu thiết kế hoàn thiện, chắc chắn từ khung nhôm Aluminum nguyên khối chống xước, đảm bảo cho sự an toàn của máy trong quá trình sử dụng. Bên cạnh đó, thân máy mỏng nhẹ cũng mang đến cho người dùng sự thoải mái và tiện lợi khi sử dụng.','2022-08-13 17:38:21','','2022-08-20 17:28:39',NULL),('5c4dcaad-98df-40bb-9a7e-55602ab72a98','Iphone 13 Plus','iphone 13 plus','2a42a979-29d8-4c7f-9b34-b86ef667cfac',1,'iphone-13-224041455.jpg',NULL,21000000.00,18000000.00,12,NULL,7,'Với những cải tiến không ngừng nghỉ cho những sản phẩm điện thoại thông minh của mình, Apple là hãng smartphone luôn nhận được sự tin tưởng từ người tiêu dùng Việt Nam. Dòng sản phẩm iPhone 13 được ra mắt gần đây với màu sắc mới và nâng cấp đáng kể về phần cứng của điện thoại đang nhận được rất nhiều sự quan tâm từ người hâm mộ.   ','2022-08-13 17:40:41','','2022-08-20 17:29:45',NULL),('8559350d-53dd-48f5-b050-3208126fa152','samsung galaxy','samsung galaxy','2a42a979-29d8-4c7f-9b34-b86ef667cfac',1,'samsung-ga225831405.jpg',NULL,12000000.00,11500000.00,12,NULL,10,'Thị trường điện thoại thông minh ngày càng xuất hiện nhiều thương hiệu sản xuất các sản phẩm giá rẻ. Realme là cái tên không còn xa lạ với phần lớn người dùng tại Việt Nam. Những chiếc smartphone Realme đều được hoàn thiện về thiết kế cũng như hiệu năng ổn trong tầm giá. Công ty đã giới thiệu chiếc Realme C11 tại thị trường Việt Nam. Nếu bạn đang tìm kiếm một chiếc điện thoại giá rẻ thì đừng bỏ qua sản phẩm này nhé. ','2022-08-13 17:58:31','',NULL,NULL),('a56bb32d-a7ab-4a8f-b6c2-4377bf8709f8','Oppo a55','oppo a55','2a42a979-29d8-4c7f-9b34-b86ef667cfac',1,'oppo-a55-0223140853.jpg',NULL,15000000.00,12000000.00,12,NULL,1,'OPPO A55 4G sở hữu 2 phiên bản màu sắc Starry Black và Rainbow Blue. Với thiết kế cong 3D cùng kích thước mỏng nhẹ, OPPO A55 4G mang đến cảm giác vừa vặn trong tay người dùng, đem đến từng thao tác trải nghiệm thoải mái và chắc chắn ngay cả khi sử dụng bằng một tay.','2022-08-11 21:31:40','','2022-08-20 17:28:39',NULL),('b7f6f41e-0bd0-4a50-ad01-af4f48005fad','laptop macbook air 2021','laptop macbook air 2021','9d841751-82e3-4d8c-bbd3-4c9eb80f67f6',2,'laptop-mac224956619.jpg',NULL,21000000.00,20000000.00,10,NULL,10,'Là một chiếc ultrabook cao cấp, MacBook Air mang trên mình tất cả thẩm mỹ tinh tế của Apple trong thiết kế sản phẩm. MacBook Air M1 được hoàn thiện từ chất liệu nhôm nguyên khối, không chỉ nhẹ mà còn rất sang trọng. Trọng lượng chỉ 1,29kg cũng giúp người dùng tiện lợi mang đi sử dụng ở mọi nơi. Khách hàng có thể lựa chọn ba phiên bản màu khác nhau phù hợp với cả tính mỗi người, bao gồm xám, bạc và vàng.','2022-08-13 17:49:56','','2022-08-20 16:48:50',NULL),('c16392c6-9862-440e-a6c4-aceae4fb5923','Laptop Dell Vostro 3400','laptop dell','9d841751-82e3-4d8c-bbd3-4c9eb80f67f6',2,'laptop-del224552400.jpg',NULL,19000000.00,17000000.00,12,NULL,9,'Dell Vostro 3400-70253899 sở hữu màn hình 14 inch độ phân giải full HD (1920 x 1080) giúp người dùng trải nghiệm được những hình ảnh chân thực và rõ nét, màu sắc tái tạo chính xác, đáp ứng tối đa nhu cầu sử dụng của người dùng.','2022-08-13 17:45:52','','2022-08-20 17:29:45',NULL);
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
INSERT INTO `productcategory` VALUES ('2a42a979-29d8-4c7f-9b34-b86ef667cfac','Điện thoại','1680d16c-0137-11ed-a724-6c2b59645b10','dien-thoai','điện thoại','Danh mục điện thoại',NULL,1,'','2022-08-11 21:29:10','','2022-08-11 21:29:10',''),('4e9e547d-a2b1-49e4-9afd-e4b265d72190','tivi','1680d16c-0137-11ed-a724-6c2b59645b10','tivi','tivi','Danh mục Tivi',NULL,4,'','2022-08-11 21:55:59','','2022-08-11 21:55:59',''),('9d841751-82e3-4d8c-bbd3-4c9eb80f67f6','Laptop','1680d16c-0137-11ed-a724-6c2b59645b10','laptop','laptop','Danh mục laptop',NULL,2,'','2022-08-11 21:29:31','','2022-08-11 21:29:31',''),('c80c49df-2960-4acc-a372-aa3f2a4fe63d','Máy tính bảng','1680d16c-0137-11ed-a724-6c2b59645b10','may-tinh-bang','máy tỉnh bảng','Danh mục máy tính bảng',NULL,3,'','2022-08-11 21:29:51','','2022-08-11 21:29:51','');
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
  `Image` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ProductOrderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productorder`
--

LOCK TABLES `productorder` WRITE;
/*!40000 ALTER TABLE `productorder` DISABLE KEYS */;
INSERT INTO `productorder` VALUES ('2bdaea3c-94fa-49b5-8fa2-f180ab3e71f8','b9741b59-151e-46e4-9e49-ac7a4681658d','0927783833','Đỗ Đình Hưng','Quốc Oai - Hà Nội','HungMien@gmail.com',NULL,1,NULL,'','2022-08-20 16:57:02','2022-08-20 16:57:02','',NULL),('355492db-8889-4a9a-b2d2-0a700f47146d',NULL,'','','','',NULL,1,NULL,'','2022-08-20 17:29:45','2022-08-20 17:29:45','',NULL),('b5107c8c-b584-4ef6-9226-af73fd02c460',NULL,'0963514289','Nguyen Van A','Hà Nội','NguyenVanA@gmail.com',NULL,1,NULL,'','2022-08-20 17:28:39','2022-08-20 17:28:39','',NULL);
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
  `TypeProduct` int DEFAULT NULL,
  PRIMARY KEY (`ProductOrderDetailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productorderdetail`
--

LOCK TABLES `productorderdetail` WRITE;
/*!40000 ALTER TABLE `productorderdetail` DISABLE KEYS */;
INSERT INTO `productorderdetail` VALUES ('0be6fa8e-599a-47d6-af6a-8ef59cfff51e','1be8df2f-63e0-44e3-aacd-f50f3ff8389a','2bdaea3c-94fa-49b5-8fa2-f180ab3e71f8','Laptop Macbook Air 13',29000000.00,3,NULL,'laptop-mac224329823.jpg',2),('1a36bd11-5052-48a7-a249-7c02557e86d8','428c7810-c91d-4c25-8a5c-59036ccc7afb','b5107c8c-b584-4ef6-9226-af73fd02c460','Samsung Galaxy S8',15000000.00,1,NULL,'samsung-ga223821366.jpg',1),('2383f089-b975-42c2-a346-9ed093c5c454','a56bb32d-a7ab-4a8f-b6c2-4377bf8709f8','b5107c8c-b584-4ef6-9226-af73fd02c460','Oppo a55',15000000.00,4,NULL,'oppo-a55-0223140853.jpg',1),('49c4ba55-50fd-4c27-bce5-2b9dc7d57213','c16392c6-9862-440e-a6c4-aceae4fb5923','2bdaea3c-94fa-49b5-8fa2-f180ab3e71f8','Laptop Dell Vostro 3400',19000000.00,1,NULL,'laptop-del224552400.jpg',2),('de14b2be-c5f8-4f8e-a2d2-c98e7ce4b7c5','c16392c6-9862-440e-a6c4-aceae4fb5923','355492db-8889-4a9a-b2d2-0a700f47146d','Laptop Dell Vostro 3400',19000000.00,1,NULL,'laptop-del224552400.jpg',2),('ef7ceda3-0105-47c1-a748-6f553878fe6e','5c4dcaad-98df-40bb-9a7e-55602ab72a98','355492db-8889-4a9a-b2d2-0a700f47146d','Iphone 13 Plus',21000000.00,1,NULL,'iphone-13-224041455.jpg',1);
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
INSERT INTO `user` VALUES ('b9741b59-151e-46e4-9e49-ac7a4681658d','Đỗ Đình Hưng','abcABC123','HungMien@gmail.com','0927783833',0,'Quốc Oai - Hà Nội','2022-07-25 21:09:41','',NULL,NULL),('bd0e7cde-7cb1-4042-95e9-552a13c58054','Hưng Đỗ Đình','abcABC1234','dodinhhung@gmail.com','0963514289',0,'Quốc Oai - Hà Nội','2022-08-13 18:03:09','',NULL,NULL);
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

-- Dump completed on 2022-08-21  0:08:23
