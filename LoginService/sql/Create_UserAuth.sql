﻿SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;
-- ----------------------------
-- Table structure for user_auth
-- ----------------------------
DROP TABLE IF EXISTS `user_auth`;
CREATE TABLE `user_auth` (
     `account_id` INT(11) NOT NULL AUTO_INCREMENT,
     `account_name` VARCHAR(14) NOT NULL,
     `password` VARCHAR(50) NOT NULL,
     `email` VARCHAR(50) NOT NULL,
     `last_login` DATETIME NOT NULL DEFAULT (curdate()),
     `last_logout` DATETIME NOT NULL DEFAULT (curdate()),
     `last_world` TINYINT(4) NOT NULL DEFAULT '0',
     PRIMARY KEY (`account_id`)
)
    COLLATE='utf8mb4_general_ci'
    ENGINE=InnoDB
;

SET FOREIGN_KEY_CHECKS = 1;