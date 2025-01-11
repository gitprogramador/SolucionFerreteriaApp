-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: bdatosfer
-- ------------------------------------------------------
-- Server version	8.0.40

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `bdatosfer`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `bdatosfer` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `bdatosfer`;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `IdCategoria` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  `Estado` tinyint NOT NULL DEFAULT '1',
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Herramientas Manuales',1,'2024-12-13 21:40:23'),(2,'Herramientas Eléctricas',1,'2024-12-13 21:40:23'),(3,'Pinturas y Accesorios',1,'2024-12-13 21:40:23'),(4,'Materiales de Construcción',1,'2024-12-13 21:40:23'),(5,'Ferretería General',1,'2024-12-13 21:40:23'),(6,'Plomería',1,'2024-12-13 21:40:23'),(7,'Iluminación',1,'2024-12-13 21:40:23'),(8,'Jardinería',1,'2024-12-13 21:40:23'),(9,'Seguridad y Protección',1,'2024-12-13 21:40:23'),(10,'Tornillería',1,'2024-12-13 21:40:23'),(11,'Adhesivos y Selladores',1,'2024-12-13 21:40:23'),(12,'Cerraduras y Herrajes',1,'2024-12-13 21:40:23'),(13,'Productos de Limpieza',1,'2024-12-13 21:40:23'),(14,'Automotriz',1,'2024-12-13 21:40:23'),(15,'Accesorios de Baño',1,'2024-12-13 21:40:23'),(16,'Maderas y Derivados',1,'2024-12-13 21:40:23'),(17,'Eléctricos',1,'2024-12-13 21:40:23'),(18,'Muebles para Taller',1,'2024-12-13 21:40:23'),(19,'Equipos de Medición',1,'2024-12-13 21:40:23'),(20,'Abrasivos y Discos de Corte',1,'2024-12-13 21:40:23'),(25,'Circuitos Electronicos',1,'2025-01-06 20:53:58');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `Documento` varchar(50) DEFAULT NULL,
  `NombreCompleto` varchar(50) DEFAULT NULL,
  `Correo` varchar(80) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Estado` tinyint NOT NULL DEFAULT '1',
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdCliente`),
  UNIQUE KEY `Documento` (`Documento`),
  UNIQUE KEY `Correo` (`Correo`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (2,'CF-000','Consumidor Final','consumidor.final@nulo.com','0000-0000',1,'2024-12-13 23:12:59'),(3,'C001','Juan Pérez','juan.perez@example.com','+505-8888-1234',1,'2024-12-13 23:12:59'),(4,'C002','María López','maria.lopez@example.com','+505-8899-5678',1,'2024-12-13 23:12:59'),(5,'C003','Carlos Rodríguez','carlos.rodriguez@example.com','+505-8777-4321',1,'2024-12-13 23:12:59'),(6,'C004','Ana Castillo','ana.castillo@example.com','+505-8866-3456',1,'2024-12-13 23:12:59'),(7,'C005','Luis Gómez','luis.gomez@example.com','+505-8999-6543',1,'2024-12-13 23:12:59'),(8,'C006','Sofía Vargas','sofia.vargas@example.com','+505-8333-6789',1,'2024-12-13 23:12:59'),(9,'C007','José Hernández','jose.hernandez@example.com','+505-8555-9876',1,'2024-12-13 23:12:59'),(10,'C008','Gloria Morales','gloria.morales@example.com','+505-8222-3456',1,'2024-12-13 23:12:59'),(11,'C009','Miguel Rivas','miguel.rivas@example.com','+505-8777-5678',1,'2024-12-13 23:12:59'),(12,'C010','Paola Martínez','paola.martinez@example.com','+505-8666-7890',1,'2024-12-13 23:12:59'),(13,'C011','Terry Ramirez','terryman42@gmail.com','+505-8558-4910',0,'2024-12-14 22:00:52'),(18,'C012','Carlos Tellez','CarlosM@gmail.com','+505-3789-5909',1,'2025-01-06 20:51:20');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra` (
  `IdCompra` int NOT NULL AUTO_INCREMENT,
  `IdUsuario` int DEFAULT NULL,
  `IdProveedor` int DEFAULT NULL,
  `MontoTotal` decimal(9,2) DEFAULT NULL,
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdCompra`),
  KEY `fk_compra_usuario` (`IdUsuario`),
  KEY `fk_compra_proveedor` (`IdProveedor`),
  CONSTRAINT `fk_compra_proveedor` FOREIGN KEY (`IdProveedor`) REFERENCES `proveedor` (`IdProveedor`) ON DELETE SET NULL,
  CONSTRAINT `fk_compra_usuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES (1,9,NULL,50.00,'2024-12-26 17:30:41'),(2,9,1,60.00,'2024-12-26 17:34:41'),(3,9,4,60.00,'2024-12-26 17:37:17'),(4,9,5,540.00,'2024-12-26 17:37:56'),(5,5,11,60.00,'2024-12-26 17:41:49'),(6,5,1,5.00,'2024-12-26 20:00:58'),(7,5,4,150.00,'2025-01-06 19:23:30'),(8,5,23,750.00,'2025-01-06 20:53:28'),(9,5,23,10500.00,'2025-01-06 21:06:34'),(10,5,6,1800.00,'2025-01-10 20:23:53'),(11,3,7,210.00,'2025-01-10 20:38:53');
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_compra`
--

DROP TABLE IF EXISTS `detalle_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_compra` (
  `IdDetalleCompra` int NOT NULL AUTO_INCREMENT,
  `IdCompra` int DEFAULT NULL,
  `IdProducto` int DEFAULT NULL,
  `PrecioCompra` decimal(9,2) DEFAULT '0.00',
  `PrecioVenta` decimal(9,2) DEFAULT '0.00',
  `Cantidad` int DEFAULT NULL,
  `MontoTotal` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`IdDetalleCompra`),
  KEY `fk_detalle_compra_compra` (`IdCompra`),
  KEY `fk_detalle_compra_producto` (`IdProducto`),
  CONSTRAINT `fk_detalle_compra_compra` FOREIGN KEY (`IdCompra`) REFERENCES `compra` (`IdCompra`) ON DELETE CASCADE,
  CONSTRAINT `fk_detalle_compra_producto` FOREIGN KEY (`IdProducto`) REFERENCES `producto` (`IdProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_compra`
--

LOCK TABLES `detalle_compra` WRITE;
/*!40000 ALTER TABLE `detalle_compra` DISABLE KEYS */;
INSERT INTO `detalle_compra` VALUES (1,1,31,0.00,5.00,10,50.00),(2,NULL,31,0.00,5.00,12,60.00),(3,2,31,0.00,5.00,12,60.00),(4,3,31,0.00,5.00,12,60.00),(5,4,31,0.00,5.00,8,40.00),(6,4,34,0.00,50.00,10,500.00),(7,5,40,12.00,0.00,5,60.00),(8,6,32,2.50,4.00,2,5.00),(9,7,44,15.00,25.00,10,150.00),(10,8,51,25.00,35.00,30,750.00),(11,9,62,350.00,400.00,30,10500.00),(12,10,59,40.00,65.00,45,1800.00),(13,11,58,35.00,50.00,6,210.00);
/*!40000 ALTER TABLE `detalle_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_venta`
--

DROP TABLE IF EXISTS `detalle_venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_venta` (
  `IdDetalleVenta` int NOT NULL AUTO_INCREMENT,
  `IdVenta` int DEFAULT NULL,
  `IdProducto` int DEFAULT NULL,
  `PrecioVenta` decimal(9,2) DEFAULT NULL,
  `Cantidad` int DEFAULT NULL,
  `SubTotal` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`IdDetalleVenta`),
  KEY `fk_detalle_venta_venta` (`IdVenta`),
  KEY `fk_detalle_venta_producto` (`IdProducto`),
  CONSTRAINT `fk_detalle_venta_producto` FOREIGN KEY (`IdProducto`) REFERENCES `producto` (`IdProducto`),
  CONSTRAINT `fk_detalle_venta_venta` FOREIGN KEY (`IdVenta`) REFERENCES `venta` (`IdVenta`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_venta`
--

LOCK TABLES `detalle_venta` WRITE;
/*!40000 ALTER TABLE `detalle_venta` DISABLE KEYS */;
INSERT INTO `detalle_venta` VALUES (2,2,36,12.00,20,240.00),(3,3,37,5.50,50,275.00),(4,4,62,400.00,10,4000.00),(5,5,62,400.00,10,4000.00),(6,6,59,65.00,3,195.00),(7,7,58,50.00,6,300.00);
/*!40000 ALTER TABLE `detalle_venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medida`
--

DROP TABLE IF EXISTS `medida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medida` (
  `IdMedida` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  `Abreviatura` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`IdMedida`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medida`
--

LOCK TABLES `medida` WRITE;
/*!40000 ALTER TABLE `medida` DISABLE KEYS */;
INSERT INTO `medida` VALUES (1,'Metro','m'),(2,'Centímetro','cm'),(3,'Milímetro','mm'),(4,'Litro','L'),(5,'Mililitro','ml'),(6,'Kilogramo','kg'),(7,'Gramo','g'),(8,'Pulgada','in'),(9,'Pie','ft'),(10,'Onza','oz'),(11,'Libra','lb'),(12,'Galón','gal'),(13,'Mililitro por Segundo','ml/s'),(14,'Metro Cúbico','m³'),(15,'Centímetro Cúbico','cm³'),(16,'Kilopascal','kPa'),(17,'Newton','N'),(18,'Voltio','V'),(19,'Amperio','A'),(20,'Watt','W'),(21,'Unidad','Und');
/*!40000 ALTER TABLE `medida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `IdProducto` int NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(50) DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Descripcion` varchar(50) DEFAULT NULL,
  `IdCategoria` int DEFAULT NULL,
  `Stock` int NOT NULL DEFAULT '0',
  `PrecioCompra` decimal(9,2) DEFAULT '0.00',
  `PrecioVenta` decimal(9,2) DEFAULT '0.00',
  `Estado` tinyint NOT NULL DEFAULT '1',
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  `IdMedida` int DEFAULT NULL,
  PRIMARY KEY (`IdProducto`),
  KEY `fk_prodcuto_categoria` (`IdCategoria`),
  KEY `fk_producto_medida_idx` (`IdMedida`),
  CONSTRAINT `fk_prodcuto_categoria` FOREIGN KEY (`IdCategoria`) REFERENCES `categoria` (`IdCategoria`) ON DELETE SET NULL,
  CONSTRAINT `fk_producto_medida` FOREIGN KEY (`IdMedida`) REFERENCES `medida` (`IdMedida`) ON DELETE SET NULL ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (31,'PROD001','Martillo de Uña','Martillo de acero con mango de madera',1,50,5.00,8.00,1,'2024-12-13 23:08:10',8),(32,'PROD002','Destornillador Plano','Destornillador de punta plana',2,102,2.50,4.00,1,'2024-12-13 23:08:10',8),(33,'PROD003','Llave Inglesa','Llave ajustable de 8 pulgadas',3,30,10.00,15.00,1,'2024-12-13 23:08:10',8),(34,'PROD004','Taladro Eléctrico','Taladro de 500W con brocas incluidas',4,30,50.00,75.00,1,'2024-12-13 23:08:10',18),(35,'PROD005','Cinta Métrica','Cinta métrica de 5 metros',5,70,3.00,5.00,1,'2024-12-13 23:08:10',1),(36,'PROD006','Sierra Manual','Sierra de mano para madera',6,20,8.00,12.00,1,'2024-12-13 23:08:10',8),(37,'PROD007','Tornillos 1 pulgada','Paquete de 100 tornillos de acero',7,100,3.50,5.50,1,'2024-12-13 23:08:10',9),(38,'PROD008','Clavos de 2 pulgadas','Paquete de 200 clavos galvanizados',7,200,4.00,6.50,1,'2024-12-13 23:08:10',9),(39,'PROD009','Pegamento Epóxico','Resina epóxica de 50 ml',8,60,2.00,3.50,1,'2024-12-13 23:08:10',5),(40,'PROD010','Pintura Blanca','Galón de pintura blanca mate',9,30,12.00,18.00,1,'2024-12-13 23:08:10',12),(41,'PROD011','Brocha 2 pulgadas','Brocha para pintar superficies lisas',9,80,1.50,3.00,1,'2024-12-13 23:08:10',8),(42,'PROD012','Rodillo de Pintura','Rodillo para pintura de paredes',9,50,4.00,6.50,1,'2024-12-13 23:08:10',8),(43,'PROD013','Cemento Portland','Bolsa de cemento de 50 kg',10,100,6.00,10.00,1,'2024-12-13 23:08:10',6),(44,'PROD014','Arena Fina','Metro cúbico de arena fina',10,30,15.00,25.00,1,'2024-12-13 23:08:10',14),(45,'PROD015','Tubería PVC 1 pulgada','Tubería de PVC para agua',11,60,1.20,2.00,1,'2024-12-13 23:08:10',1),(46,'PROD016','Codo PVC 90°','Codo de PVC para unión de tuberías',11,100,0.50,1.00,1,'2024-12-13 23:08:10',8),(47,'PROD017','Lija Grano Fino','Hoja de lija de 200 granos',12,200,0.30,0.60,1,'2024-12-13 23:08:10',8),(48,'PROD018','Masilla Plástica','Bote de masilla para reparación',12,50,3.00,5.00,1,'2024-12-13 23:08:10',5),(49,'PROD019','Cerradura de Puerta','Cerradura con llave y perilla',13,30,12.00,20.00,1,'2024-12-13 23:08:10',8),(50,'PROD020','Bisagra de Acero','Juego de bisagras para puertas',13,70,2.50,4.50,1,'2024-12-13 23:08:10',8),(51,'PROD021','Cable Eléctrico 2x16','Rollo de 100 metros',14,40,25.00,35.00,1,'2024-12-13 23:08:10',1),(52,'PROD022','Interruptor Unipolar','Interruptor eléctrico de pared',14,80,1.50,2.50,1,'2024-12-13 23:08:10',8),(53,'PROD023','Bombillo LED 9W','Bombillo LED de luz blanca',15,100,2.00,3.50,1,'2024-12-13 23:08:10',8),(54,'PROD024','Extensión Eléctrica','Extensión de 5 metros',15,50,6.00,10.00,1,'2024-12-13 23:08:10',1),(55,'PROD025','Guantes de Trabajo','Guantes de seguridad talla M',16,60,2.50,4.00,1,'2024-12-13 23:08:10',8),(56,'PROD026','Casco de Seguridad','Casco de seguridad para construcción',16,20,8.00,12.00,1,'2024-12-13 23:08:10',8),(57,'PROD027','Mascarilla Antipolvo','Paquete de 10 mascarillas',16,100,1.50,3.00,1,'2024-12-13 23:08:10',8),(58,'PROD028','Escalera de Aluminio','Escalera de 6 peldaños',17,15,35.00,50.00,1,'2024-12-13 23:08:10',1),(59,'PROD029','Carretilla','Carretilla metálica reforzada',17,47,40.00,65.00,1,'2024-12-13 23:08:10',1),(60,'PROD030','Nivel de Burbuja','Nivel de burbuja de 60 cm',18,30,6.00,9.00,1,'2024-12-13 23:08:10',8),(62,'PROD031','Placas de Oro','Placas Base para Robotica de 30 Cm',25,20,350.00,400.00,1,'2025-01-06 20:56:02',21);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `IdProveedor` int NOT NULL AUTO_INCREMENT,
  `Documento` varchar(50) DEFAULT NULL,
  `RazonSocial` varchar(50) DEFAULT NULL,
  `Correo` varchar(80) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Estado` tinyint NOT NULL DEFAULT '1',
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdProveedor`),
  UNIQUE KEY `Documento` (`Documento`),
  UNIQUE KEY `Correo` (`Correo`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'JID123456','Distribuidora El Tornillo S.A.','contacto@eltornillo.com.ni','+505 2255 1234',1,'2024-12-13 22:45:37'),(2,'JID654321','Ferreterías Unidas S.A.','ventas@ferunidas.com.ni','+505 2277 5678',1,'2024-12-13 22:45:37'),(3,'JID789012','ConstruMarket Nicaragua','info@construmarket.com.ni','+505 2288 9012',1,'2024-12-13 22:45:37'),(4,'JID210987','Herramientas y Más S.R.L.','ventas@herramientasy.com.ni','+505 2244 2100',1,'2024-12-13 22:45:37'),(5,'JID345678','Pinturas La Paleta','soporte@lapaleta.com.ni','+505 2299 3456',1,'2024-12-13 22:45:37'),(6,'JID876543','Materiales J&M S.A.','info@materialesjm.com.ni','+505 2233 8765',1,'2024-12-13 22:45:37'),(7,'JID456789','Aceros y Metales Nicaragua','ventas@acerosni.com.ni','+505 2266 4567',1,'2024-12-13 22:45:37'),(8,'JID567890','Plomería Centro','contacto@plomeriacentro.com.ni','+505 2211 5678',1,'2024-12-13 22:45:37'),(9,'JID098765','Ilumina Nicaragua S.A.','ventas@ilumina.com.ni','+505 2200 0987',1,'2024-12-13 22:45:37'),(10,'JID123890','Tornillos y Accesorios S.A.','info@tornillosya.com.ni','+505 2250 1238',1,'2024-12-13 22:45:37'),(11,'JID321987','Jardinería Proverde','soporte@proverde.com.ni','+505 2270 3219',1,'2024-12-13 22:45:37'),(12,'JID654098','Grupo Seguridad Total S.A.','ventas@seguridadtotal.com.ni','+505 2280 6540',1,'2024-12-13 22:45:37'),(13,'JID765432','Adhesivos Maxifix S.A.','contacto@maxifix.com.ni','+505 2245 7654',1,'2024-12-13 22:45:37'),(14,'JID234567','Cerraduras y Herrajes El Candado','ventas@elcandado.com.ni','+505 2290 2345',1,'2024-12-13 22:45:37'),(15,'JID543210','Productos de Limpieza CleanUp','info@cleanup.com.ni','+505 2222 5432',1,'2024-12-13 22:45:37'),(16,'JID678901','Accesorios Automotrices AutoTech','ventas@autotech.com.ni','+505 2233 6789',1,'2024-12-13 22:45:37'),(17,'JID890123','Soluciones en Maderas S.A.','contacto@solumaderas.com.ni','+505 2260 8901',1,'2024-12-13 22:45:37'),(18,'JID456012','Eléctricos ProSistemas','info@prosistemas.com.ni','+505 2240 4560',1,'2024-12-13 22:45:37'),(19,'JID345601','Muebles para Taller Workshop S.A.','ventas@workshop.com.ni','+505 2277 3456',1,'2024-12-13 22:45:37'),(20,'JID567098','Abrasivos y Discos CortePerfecto','contacto@corteperfecto.com.ni','+505 2255 5670',1,'2024-12-13 22:45:37'),(23,'JID389268','Metales Unidos de Nicaragua.SA','Ventas@MetalesUnidosdenicaragua.com','+505 2311 6143',1,'2025-01-06 20:52:32');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `IdRol` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(50) DEFAULT NULL,
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'ADMINISTRADOR','2024-12-12 23:13:04'),(2,'VENDEDOR','2024-12-12 23:13:04'),(3,'CONSULTA','2024-12-12 23:13:04'),(4,'SUPERADMINISTRADOR','2024-12-15 01:44:59');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `IdUsuario` int NOT NULL AUTO_INCREMENT,
  `NombreCompleto` varchar(50) DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Pwd` varchar(60) DEFAULT NULL,
  `IdRol` int DEFAULT NULL,
  `Estado` tinyint NOT NULL DEFAULT '1',
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdUsuario`),
  KEY `fk_usuario_Rol` (`IdRol`),
  CONSTRAINT `fk_usuario_Rol` FOREIGN KEY (`IdRol`) REFERENCES `rol` (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (3,'Biarny Salinas','superadmin','$2a$11$1GcBoAHifpXPNN6stvoaK.U3EBZh3iMxPTcQsBG.K1koHlDekeFjG',4,1,'2024-12-12 23:13:15'),(5,'Denis Telléz','Admin','$2a$11$B2NoEqzDwrZculwrv9SZm.Zleq13lb4WQtb73VMhV2J4fj7CA9QFa',1,1,'2024-12-13 15:08:16'),(9,'Rodrigo Fanor','Vendedor1','$2a$11$k5ZLgHe0J1nhjI0KbflYLuozFj4EYyEHn6pxQBFpWvWl9cmyaJ2Aa',2,1,'2024-12-16 22:33:29'),(10,'Elena Muñoz','Consulta','$2a$11$L6I.nXUFKv.Grf84ZFRAcOA/89K/aZ/vQ2XJzWxw826d93FMhU9AS',3,1,'2024-12-16 22:33:56'),(24,'Jose Melendez','Consulta2','$2a$11$Kn.gJtRdbMA.Z86dvW.sNenkC22MryHo6RPVn1eNyraqUETCd9NAK',3,1,'2025-01-10 20:40:13');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `IdVenta` int NOT NULL AUTO_INCREMENT,
  `IdUsuario` int DEFAULT NULL,
  `IdCliente` int DEFAULT NULL,
  `MontoPago` decimal(9,2) DEFAULT NULL,
  `MontoCambio` decimal(9,2) DEFAULT NULL,
  `MontoTotal` decimal(9,2) DEFAULT NULL,
  `FechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdVenta`),
  KEY `fk_venta_usuario` (`IdUsuario`),
  KEY `fk_venta_cliente` (`IdCliente`),
  CONSTRAINT `fk_venta_cliente` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`),
  CONSTRAINT `fk_venta_usuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (2,5,13,300.00,60.00,240.00,'2024-12-26 19:00:40'),(3,5,4,300.00,25.00,275.00,'2024-12-26 19:01:57'),(4,5,18,5000.00,1000.00,4000.00,'2025-01-06 21:07:10'),(5,5,10,4000.00,0.00,4000.00,'2025-01-06 21:07:56'),(6,5,6,200.00,5.00,195.00,'2025-01-10 20:30:06'),(7,3,8,300.00,0.00,300.00,'2025-01-10 20:39:25');
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bdatosfer'
--

--
-- Dumping routines for database 'bdatosfer'
--
/*!50003 DROP PROCEDURE IF EXISTS `ComprasEntreFechas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ComprasEntreFechas`(
    IN p_FechaInicio DATE,
    IN p_FechaFin DATE
)
BEGIN
  -- Ajustar la fecha final al final del día
    SET p_FechaFin = DATE_ADD(p_FechaFin, INTERVAL 1 DAY) - INTERVAL 1 SECOND;

    SELECT 
        c.IdCompra AS `ID Compra`,
        p.RazonSocial AS `Proveedor`,
        u.NombreCompleto AS `Usuario`,
        c.MontoTotal AS `Monto Total`,
        c.FechaRegistro AS `Fecha de Registro`
    FROM 
        compra c
    LEFT JOIN proveedor p ON c.IdProveedor = p.IdProveedor
    LEFT JOIN usuario u ON c.IdUsuario = u.IdUsuario
    WHERE 
        DATE(c.FechaRegistro) BETWEEN p_FechaInicio AND p_FechaFin
    ORDER BY 
        c.FechaRegistro ASC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ComprasEntreFechasPorUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ComprasEntreFechasPorUsuario`(
    IN p_IdUsuario INT,
    IN p_FechaInicio DATETIME,
    IN p_FechaFin DATETIME
)
BEGIN
    SELECT 
        c.IdCompra,
        c.IdUsuario,
        u.NombreCompleto AS NombreUsuario,
        c.IdProveedor,
        p.RazonSocial AS NombreProveedor,
        c.MontoTotal,
        c.FechaRegistro
    FROM 
        compra c
    LEFT JOIN 
        usuario u ON c.IdUsuario = u.IdUsuario
    LEFT JOIN 
        proveedor p ON c.IdProveedor = p.IdProveedor
    WHERE 
        c.IdUsuario = p_IdUsuario
        AND c.FechaRegistro BETWEEN p_FechaInicio AND p_FechaFin
    ORDER BY 
        c.FechaRegistro DESC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DetallesVenta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DetallesVenta`(IN p_IdVenta INT)
BEGIN
    SELECT 
        dv.IdProducto, 
        p.Nombre AS Producto, 
        dv.cantidad, 
        dv.PrecioVenta, 
        (dv.Cantidad * dv.PrecioVenta) AS Total
    FROM 
        detalle_venta dv
    JOIN 
        producto p ON dv.IdProducto = p.IdProducto
    WHERE 
        dv.IdVenta = p_IdVenta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProductosPorCategoria` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ProductosPorCategoria`()
BEGIN
    SELECT 
        c.IdCategoria,
        c.Descripcion AS Categoria,
        COUNT(p.IdProducto) AS CantidadProductos
    FROM 
        categoria c
    LEFT JOIN 
        producto p ON c.IdCategoria = p.IdCategoria
    GROUP BY 
        c.IdCategoria, c.Descripcion
    ORDER BY 
        CantidadProductos DESC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProductosStockBajo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ProductosStockBajo`()
BEGIN
    SELECT 
        p.IdProducto,
        p.Descripcion AS NombreProducto, 
        p.Stock AS 'Stock Actual',
        c.Descripcion AS 'Categoria'
    FROM 
        producto p 
        INNER JOIN categoria c ON p.IdCategoria = c.IdCategoria
    WHERE 
        p.Stock <= 20
    ORDER BY 
        p.Stock ASC;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ReporteComprasEntreFechas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReporteComprasEntreFechas`(
    IN FechaInicio DATE,
    IN FechaFin DATE
)
BEGIN
    SELECT 
        c.IdCompra AS `ID Compra`,
        p.RazonSocial AS `Proveedor`,
        u.NombreCompleto AS `Usuario`,
        c.MontoTotal AS `Monto Total`,
        c.FechaRegistro AS `Fecha de Registro`
    FROM 
        compra c
    LEFT JOIN proveedor p ON c.IdProveedor = p.IdProveedor
    LEFT JOIN usuario u ON c.IdUsuario = u.IdUsuario
    WHERE 
        DATE(c.FechaRegistro) BETWEEN FechaInicio AND FechaFin
    ORDER BY 
        c.FechaRegistro ASC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ReporteInventario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReporteInventario`()
BEGIN
    SELECT 
        p.IdProducto AS `ID del Producto`,
        c.Descripcion AS `Categoria`,
        p.Descripcion AS `Producto`,
        p.Stock AS `Cantidad Disponible`,
        p.PrecioCompra AS `Precio de Compra`,
        p.PrecioVenta AS `Precio de Venta`,
        (PrecioVenta - PrecioCompra) AS `Margen de Ganancia`
    FROM 
        producto p 
        inner join 
        categoria c on p.IdCategoria=c.IdCategoria
    WHERE 
        p.Estado = 1 
    ORDER BY 
        p.Descripcion ASC; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `VentasDelDia` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `VentasDelDia`()
BEGIN
    SELECT 
        v.IdVenta,
        u.NombreCompleto AS NombreUsuario,
        c.NombreCompleto AS NombreCliente,
        v.MontoPago,
        v.MontoCambio,
        v.MontoTotal,
        v.FechaRegistro,
        dv.IdDetalleVenta,
        p.Descripcion AS NombreProducto,
        dv.PrecioVenta,
        dv.Cantidad,
        dv.SubTotal
    FROM 
        venta v
    INNER JOIN 
        usuario u ON v.IdUsuario = u.IdUsuario
    LEFT JOIN 
        cliente c ON v.IdCliente = c.IdCliente
    INNER JOIN 
        detalle_venta dv ON v.IdVenta = dv.IdVenta
    INNER JOIN 
        producto p ON dv.IdProducto = p.IdProducto
    WHERE 
        DATE(v.FechaRegistro) = CURDATE()
    ORDER BY 
        v.FechaRegistro desc, v.IdVenta desc, dv.IdDetalleVenta;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `VentasEntreFechas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `VentasEntreFechas`(
    IN p_FechaInicio DATETIME,
    IN p_FechaFin DATETIME
)
BEGIN
    -- Ajustar la fecha final al final del día
    SET p_FechaFin = DATE_ADD(p_FechaFin, INTERVAL 1 DAY) - INTERVAL 1 SECOND;

    SELECT 
        v.IdVenta,
        v.IdUsuario,
        u.NombreCompleto AS NombreUsuario,
        v.IdCliente,
        c.NombreCompleto AS NombreCliente,
        v.MontoTotal,
        v.FechaRegistro
    FROM 
        venta v
    LEFT JOIN 
        usuario u ON v.IdUsuario = u.IdUsuario
    LEFT JOIN 
        cliente c ON v.IdCliente = c.IdCliente
    WHERE 
        v.FechaRegistro BETWEEN p_FechaInicio AND p_FechaFin
    ORDER BY 
        v.FechaRegistro DESC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `VentasEntreFechasPorUsuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `VentasEntreFechasPorUsuario`(
    IN p_IdUsuario INT,
    IN p_FechaInicio DATETIME,
    IN p_FechaFin DATETIME
)
BEGIN
    SELECT 
        v.IdVenta,
        v.IdUsuario,
        u.NombreCompleto AS NombreUsuario,
        v.IdCliente,
        c.NombreCompleto AS NombreCliente,
        v.MontoTotal,
        v.FechaRegistro
    FROM 
        venta v
    LEFT JOIN 
        usuario u ON v.IdUsuario = u.IdUsuario
    LEFT JOIN 
        cliente c ON v.IdCliente = c.IdCliente
    WHERE 
        v.IdUsuario = p_IdUsuario
        AND v.FechaRegistro BETWEEN p_FechaInicio AND p_FechaFin
    ORDER BY 
        v.FechaRegistro DESC;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-10 20:40:24
