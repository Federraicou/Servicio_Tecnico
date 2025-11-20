-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: mibasededatos
-- ------------------------------------------------------
-- Server version	8.0.43

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `telefono` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (26,'Lionel Messi','291 777 7777');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipo` (
  `id_equipo` int NOT NULL AUTO_INCREMENT,
  `procesador` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `fecha_ingreso` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tipo` varchar(100) NOT NULL,
  `id_cliente` int NOT NULL,
  `ram` varchar(100) NOT NULL,
  `fuente` varchar(100) DEFAULT NULL,
  `almacenamiento` varchar(100) NOT NULL,
  `gpu` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_equipo`),
  KEY `equipo_cliente_FK` (`id_cliente`),
  CONSTRAINT `equipo_cliente_FK` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
INSERT INTO `equipo` VALUES (18,'Intel i10 Version Furbo','2025-10-14 07:03:09','Notebook',26,'8gb kingston 3200mhz','furbo','1TB ssd','no tiene');
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pago`
--

DROP TABLE IF EXISTS `pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pago` (
  `id_pago` int NOT NULL AUTO_INCREMENT,
  `fecha_pago` varchar(100) NOT NULL,
  `precio_total` int NOT NULL,
  `tipo_pago` varchar(100) NOT NULL,
  `id_cliente` int NOT NULL,
  `precio_servicio` int NOT NULL,
  `precio_repuesto` int NOT NULL,
  PRIMARY KEY (`id_pago`),
  KEY `pago_cliente_FK` (`id_cliente`),
  CONSTRAINT `pago_cliente_FK` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
INSERT INTO `pago` VALUES (9,'2025-11-19 07:09:22',50500,'Efectivo',26,500,50000);
/*!40000 ALTER TABLE `pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reparaciones`
--

DROP TABLE IF EXISTS `reparaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reparaciones` (
  `id_reparacion` int NOT NULL AUTO_INCREMENT,
  `diagnostico` varchar(100) NOT NULL,
  `id_repuesto` int DEFAULT NULL,
  `fecha_estimada` varchar(100) NOT NULL,
  `id_equipo` int DEFAULT NULL,
  PRIMARY KEY (`id_reparacion`),
  KEY `reparaciones_repuestos_FK` (`id_repuesto`),
  KEY `reparaciones_equipo_FK` (`id_equipo`),
  CONSTRAINT `reparaciones_equipo_FK` FOREIGN KEY (`id_equipo`) REFERENCES `equipo` (`id_equipo`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `reparaciones_repuestos_FK` FOREIGN KEY (`id_repuesto`) REFERENCES `repuestos` (`id_repuesto`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reparaciones`
--

LOCK TABLES `reparaciones` WRITE;
/*!40000 ALTER TABLE `reparaciones` DISABLE KEYS */;
INSERT INTO `reparaciones` VALUES (23,'Pantalla rota, se enojo jugando fifa',20,'2025-12-25 07:07:29',18);
/*!40000 ALTER TABLE `reparaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `repuestos`
--

DROP TABLE IF EXISTS `repuestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `repuestos` (
  `id_repuesto` int NOT NULL AUTO_INCREMENT,
  `precio` int NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `cantidad` int NOT NULL,
  PRIMARY KEY (`id_repuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `repuestos`
--

LOCK TABLES `repuestos` WRITE;
/*!40000 ALTER TABLE `repuestos` DISABLE KEYS */;
INSERT INTO `repuestos` VALUES (17,89000,'Fuente 700W ThermalTake',2),(19,45000,'SSD',2),(20,50000,'Modulo Pantalla notebook',2),(23,77000,'Gpu Ryzen 8 Version Cristiano Rolando',1),(24,20000,'Procesador i7 Siuu edition',1);
/*!40000 ALTER TABLE `repuestos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tecnico`
--

DROP TABLE IF EXISTS `tecnico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tecnico` (
  `id_tecnico` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  PRIMARY KEY (`id_tecnico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tecnico`
--

LOCK TABLES `tecnico` WRITE;
/*!40000 ALTER TABLE `tecnico` DISABLE KEYS */;
/*!40000 ALTER TABLE `tecnico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `idUser` int NOT NULL AUTO_INCREMENT,
  `User` varchar(50) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Nombre` varchar(100) DEFAULT NULL,
  `idTipoUser` int DEFAULT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (21,'fa','215a956168f77421253e947c2436371d56aa7ea1','fa',0);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'mibasededatos'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-20  3:46:41
