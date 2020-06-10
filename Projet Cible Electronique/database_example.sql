-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           8.0.19 - MySQL Community Server - GPL
-- SE du serveur:                Win64
-- HeidiSQL Version:             10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Listage de la structure de la base pour electronic_target
CREATE DATABASE IF NOT EXISTS `electronic_target` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `electronic_target`;

-- Listage de la structure de la table electronic_target. shooting_sessions
CREATE TABLE IF NOT EXISTS `shooting_sessions` (
  `id` int NOT NULL,
  `user` varchar(50) NOT NULL DEFAULT '',
  `date` int NOT NULL,
  `shoots` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table electronic_target. targets
CREATE TABLE IF NOT EXISTS `targets` (
  `name` varchar(50) NOT NULL,
  `width_mm` int NOT NULL,
  `height_mm` int NOT NULL,
  `img` mediumblob NOT NULL,
  `radius_zone_1` float DEFAULT NULL,
  `score_zone_1` int DEFAULT NULL,
  `radius_zone_2` float DEFAULT NULL,
  `score_zone_2` int DEFAULT NULL,
  `radius_zone_3` float DEFAULT NULL,
  `score_zone_3` int DEFAULT NULL,
  `radius_zone_4` float DEFAULT NULL,
  `score_zone_4` int DEFAULT NULL,
  `radius_zone_5` float DEFAULT NULL,
  `score_zone_5` int DEFAULT NULL,
  `radius_zone_6` float DEFAULT NULL,
  `score_zone_6` int DEFAULT NULL,
  `radius_zone_7` float DEFAULT NULL,
  `score_zone_7` int DEFAULT NULL,
  `radius_zone_8` float DEFAULT NULL,
  `score_zone_8` int DEFAULT NULL,
  `radius_zone_9` float DEFAULT NULL,
  `score_zone_9` int DEFAULT NULL,
  `radius_zone_10` float DEFAULT NULL,
  `score_zone_10` int DEFAULT NULL,
  `radius_zone_11` float DEFAULT NULL,
  `score_zone_11` int DEFAULT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table electronic_target. users
CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(50) NOT NULL DEFAULT '',
  `lastname` varchar(50) NOT NULL DEFAULT '',
  `firstname` varchar(50) NOT NULL DEFAULT '',
  `e_mail` varchar(100) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `category` varchar(50) NOT NULL,
  `picture` mediumblob,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Les données exportées n'étaient pas sélectionnées.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
