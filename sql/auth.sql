/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.7.15-log : Database - d_auth
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`d_auth` /*!40100 DEFAULT CHARACTER SET utf8 */;

/*Table structure for table `account` */

CREATE TABLE `account` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Primary Key - ID',
  `acc_name` varchar(17) NOT NULL COMMENT 'Account name',
  `acc_pasword` varchar(255) NOT NULL COMMENT 'Account password',
  `acc_nick` varchar(20) NOT NULL COMMENT 'Account Nickname',
  `acc_level` int(11) NOT NULL DEFAULT '0' COMMENT 'Account level',
  `acc_subTime` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Subscribe Time',
  `acc_email` varchar(25) NOT NULL COMMENT 'Account email',
  `last_time_online` time DEFAULT NULL COMMENT 'Last Time Online',
  `isOnline` tinyint(1) DEFAULT '0' COMMENT 'Player is Online, boolean, true or false',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `account` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
