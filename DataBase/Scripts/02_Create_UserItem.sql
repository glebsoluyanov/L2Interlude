﻿CREATE TABLE `user_item` (
     `item_id` INT(11) NOT NULL AUTO_INCREMENT,
     `char_id` INT(11) NOT NULL,
     `item_type` INT(11) NOT NULL,
     `amount` INT(11) NOT NULL,
     `enchant` INT(11) NOT NULL,
     `created_at` DATETIME NULL DEFAULT curdate(),
     `updated_at` DATETIME NULL DEFAULT curdate(),
     PRIMARY KEY (`item_id`),
     INDEX `char_id` (`char_id`)
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
;