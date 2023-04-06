-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: localhost    Database: personal
-- ------------------------------------------------------
-- Server version	5.6.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tblabteilung`
--

DROP TABLE IF EXISTS `tblabteilung`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblabteilung` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bezeichnung` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblabteilung`
--

LOCK TABLES `tblabteilung` WRITE;
/*!40000 ALTER TABLE `tblabteilung` DISABLE KEYS */;
INSERT INTO `tblabteilung` VALUES (1,'Geschäftsleitung'),(2,'Transport'),(3,'Steuerungen'),(4,'Verwaltung'),(5,'Hausverwaltung'),(6,'Werbung');
/*!40000 ALTER TABLE `tblabteilung` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblabtleiter`
--

DROP TABLE IF EXISTS `tblabtleiter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblabtleiter` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PersID` int(11) DEFAULT '0',
  `AbtID` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblabtleiter`
--

LOCK TABLES `tblabtleiter` WRITE;
/*!40000 ALTER TABLE `tblabtleiter` DISABLE KEYS */;
INSERT INTO `tblabtleiter` VALUES (1,1,2),(2,13,4),(3,5,3);
/*!40000 ALTER TABLE `tblabtleiter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblauftrag`
--

DROP TABLE IF EXISTS `tblauftrag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblauftrag` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Wert` double DEFAULT '0',
  `Abrechgdatum` datetime DEFAULT NULL,
  `Kunde` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblauftrag`
--

LOCK TABLES `tblauftrag` WRITE;
/*!40000 ALTER TABLE `tblauftrag` DISABLE KEYS */;
INSERT INTO `tblauftrag` VALUES (26,22340,'1999-12-17 00:00:00','TransSys GmbH'),(27,65480,NULL,'SysControl AG'),(28,3500,NULL,'Maier&Co'),(29,12000,NULL,'LTM-Steuerungen'),(30,21650,NULL,'Kohler u. Söhne'),(31,15950,NULL,'SysControl AG'),(32,75630,NULL,'LTM-Steuerungen');
/*!40000 ALTER TABLE `tblauftrag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblbericht`
--

DROP TABLE IF EXISTS `tblbericht`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbericht` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PersID` int(11) NOT NULL DEFAULT '0',
  `Datum` datetime DEFAULT NULL,
  `AuftrID` int(11) NOT NULL DEFAULT '0',
  `TätID` int(11) NOT NULL DEFAULT '0',
  `stunden` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblbericht`
--

LOCK TABLES `tblbericht` WRITE;
/*!40000 ALTER TABLE `tblbericht` DISABLE KEYS */;
INSERT INTO `tblbericht` VALUES (1,2,NULL,3,2,8),(2,3,NULL,5,7,6),(3,2,NULL,4,3,5),(4,11,NULL,1,4,8),(5,3,NULL,2,7,22);
/*!40000 ALTER TABLE `tblbericht` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblfammitglieder`
--

DROP TABLE IF EXISTS `tblfammitglieder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblfammitglieder` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PersID` int(11) DEFAULT '0',
  `Verwandtschaftsgrad` varchar(1) DEFAULT NULL,
  `Vorname` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblfammitglieder`
--

LOCK TABLES `tblfammitglieder` WRITE;
/*!40000 ALTER TABLE `tblfammitglieder` DISABLE KEYS */;
INSERT INTO `tblfammitglieder` VALUES (1,1,'m','Jürgen'),(2,6,'f','Barbara'),(3,6,'s','Jochen'),(4,6,'t','Susanne'),(5,11,'t','Gabi'),(6,11,'t','Clara'),(7,6,'s','Jürgen'),(8,8,'f','Erika'),(9,9,'f','Erika'),(10,14,'m','Uli');
/*!40000 ALTER TABLE `tblfammitglieder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblpersonal`
--

DROP TABLE IF EXISTS `tblpersonal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblpersonal` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) NOT NULL,
  `Vorname` varchar(20) DEFAULT NULL,
  `Geschlecht` varchar(1) NOT NULL,
  `GebDatum` datetime DEFAULT NULL,
  `OrtsId` int(11) DEFAULT '0',
  `Strasse` varchar(30) DEFAULT NULL,
  `Tel` varchar(15) DEFAULT NULL,
  `Eintrittsdatum` datetime NOT NULL,
  `Grundgehalt` double NOT NULL DEFAULT '0',
  `AbtID` int(11) DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `OrtsId` (`OrtsId`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblpersonal`
--

LOCK TABLES `tblpersonal` WRITE;
/*!40000 ALTER TABLE `tblpersonal` DISABLE KEYS */;
INSERT INTO `tblpersonal` VALUES (1,'Abele','Ute','w','1956-02-17 00:00:00',77,'Saarstr. 123','0711 - 747576','1999-01-01 00:00:00',3000,2),(2,'Meyer','Luise','w','1947-01-03 00:00:00',97,'Im Rain 5','07151-441233','1987-01-01 00:00:00',2800,2),(3,'Gerhardt','Paul','m','1963-12-12 00:00:00',96,'Wiesenweg 17','07151/55657','1991-07-01 00:00:00',4000,2),(4,'Werner','Klaus Peter','m','1968-03-02 00:00:00',24,'Waldstr. 66','0711/5566778','1993-10-01 00:00:00',2500,2),(5,'Müller','Rainer','m','1955-11-11 00:00:00',51,'Im Stückle 12',NULL,'1990-04-01 00:00:00',2500,3),(6,'Hagen','Otto','m','1954-04-17 00:00:00',107,'Waldsstr. 14','07151-34 35 36','1990-04-01 00:00:00',2500,3),(7,'Klee','Paul','m','1951-05-04 00:00:00',71,'Burgstr. 55a',NULL,'1988-01-01 00:00:00',2800,3),(8,'Bea','Norbert','m','1968-07-02 00:00:00',110,'Weiler Str. 66',NULL,'1988-01-01 00:00:00',2800,3),(9,'Müller','Joachim','m','1961-05-05 00:00:00',5,'Heilbronner Weg 5',NULL,'1988-01-01 00:00:00',3250,3),(10,'Breitner','Paul','m','1962-09-03 00:00:00',98,'Honoldstr. 123/1','07191- 78 567','1996-11-15 00:00:00',3250,3),(11,'Mann','Bärbel','w','1972-07-02 00:00:00',97,'Sudetenweg 66',NULL,'1999-01-01 00:00:00',5000,NULL),(12,'Storm','Werner','m','1972-08-12 00:00:00',106,'Neckarstr. 67',NULL,'1999-01-01 00:00:00',3275,3),(13,'Norton','Ines','w','1969-09-17 00:00:00',48,'Haus 17',NULL,'1999-01-01 00:00:00',2900,4),(14,'Pecht','Petra','w','1965-11-23 00:00:00',99,'Damaschkestr. 66','07181 / 223445','1988-10-01 00:00:00',3000,NULL),(16,'Schnabel','Werner','m','1965-08-01 00:00:00',51,'Im Bankert 14',NULL,'1999-01-01 00:00:00',3250,2),(17,'Vögele','Klaus Peter','m','1956-08-02 00:00:00',106,'Neckarstr. 69',NULL,'1999-01-15 00:00:00',3425,NULL),(20,'Maier','Peter','m','1959-07-12 00:00:00',81,'Filsstr. 30',NULL,'1979-10-01 00:00:00',6000,1),(21,'Schulze','Werner','m','1956-05-17 00:00:00',80,'Gäustr.18',NULL,'1977-01-01 00:00:00',6000,NULL),(22,'Knalldorf','Luise','w','1975-05-11 00:00:00',80,'Talweg 4','0712 / 1492912','1991-09-01 00:00:00',3250,NULL);
/*!40000 ALTER TABLE `tblpersonal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltaetart`
--

DROP TABLE IF EXISTS `tbltaetart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbltaetart` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Bezeichnung` varchar(20) NOT NULL,
  `Preis` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltaetart`
--

LOCK TABLES `tbltaetart` WRITE;
/*!40000 ALTER TABLE `tbltaetart` DISABLE KEYS */;
INSERT INTO `tbltaetart` VALUES (1,'Akquisition',50),(2,'Vorbesprechung',55),(3,'Beratung',70),(4,'Projektentwurf',65),(5,'Ausarbeitung',70),(6,'Kalkulation',60),(7,'Zeichnen',50),(8,'Schreibarbeit',40);
/*!40000 ALTER TABLE `tbltaetart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblzuschuss`
--

DROP TABLE IF EXISTS `tblzuschuss`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblzuschuss` (
  `Verwandtschaftsgrad` varchar(1) NOT NULL,
  `Zuschuss` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Verwandtschaftsgrad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblzuschuss`
--

LOCK TABLES `tblzuschuss` WRITE;
/*!40000 ALTER TABLE `tblzuschuss` DISABLE KEYS */;
INSERT INTO `tblzuschuss` VALUES ('f','60'),('m','60'),('s','40'),('t','40');
/*!40000 ALTER TABLE `tblzuschuss` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-02-25 21:15:29
