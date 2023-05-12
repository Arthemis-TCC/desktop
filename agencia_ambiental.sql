/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

DROP DATABASE IF EXISTS `agencia_ambiental`;
CREATE DATABASE IF NOT EXISTS `agencia_ambiental` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `agencia_ambiental`;

CREATE TABLE IF NOT EXISTS `autorizacao` (
  `Número` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(50) NOT NULL DEFAULT '0',
  `Nome do interessado` varchar(50) NOT NULL DEFAULT '0',
  `Endereço de residência` varchar(150) NOT NULL DEFAULT '0',
  `Telefone` int(16) NOT NULL DEFAULT '0',
  `CPF` int(11) NOT NULL DEFAULT '0',
  `E-mail` varchar(50) NOT NULL DEFAULT '0',
  `Endereço do imóvel` varchar(150) NOT NULL DEFAULT '0',
  `Latitude` int(11) NOT NULL DEFAULT '0',
  `Longitude` int(11) NOT NULL DEFAULT '0',
  `Bacia hidrográfica` varchar(50) NOT NULL DEFAULT '0',
  `Área do imóvel (em hectares)` int(11) NOT NULL DEFAULT '0',
  `Quantidade de árvores a serem cortadas` int(11) NOT NULL DEFAULT '0',
  `Área a ser cortada (em hectares)` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Número`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40000 ALTER TABLE `autorizacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `autorizacao` ENABLE KEYS */;

CREATE TABLE IF NOT EXISTS `boleto` (
  `Número` int(11) NOT NULL,
  `Valor` int(11) NOT NULL,
  PRIMARY KEY (`Número`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40000 ALTER TABLE `boleto` DISABLE KEYS */;
/*!40000 ALTER TABLE `boleto` ENABLE KEYS */;

CREATE TABLE IF NOT EXISTS `funcionario` (
  `Nome` varchar(50) NOT NULL,
  `CPF` int(11) NOT NULL,
  `E-mail` varchar(50) NOT NULL,
  `Senha` varchar(50) NOT NULL,
  PRIMARY KEY (`CPF`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;

CREATE TABLE IF NOT EXISTS `interessado` (
  `Nome` varchar(50) NOT NULL,
  `CPF` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `Senha` varchar(50) NOT NULL,
  PRIMARY KEY (`CPF`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40000 ALTER TABLE `interessado` DISABLE KEYS */;
/*!40000 ALTER TABLE `interessado` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;


insert into funcionario values ('eduarda', 2147483647, 'eduarda@gmail.com', 125, 'admin');


create table svn_engenheiro(
cidade varchar(200) not null, 
status_svn varchar(50) not null, 
data_svn date not null, 
check_svn bool not null);


insert into svn_engenheiro values ('Vistoria - Registro, São Paulo', 'Em atraso', 20170610);
