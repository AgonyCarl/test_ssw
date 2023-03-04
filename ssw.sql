/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80016
 Source Host           : localhost:3306
 Source Schema         : ssw

 Target Server Type    : MySQL
 Target Server Version : 80016
 File Encoding         : 65001

 Date: 04/03/2023 21:15:18
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for product
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product`  (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '产品编号',
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '产品名称',
  `code` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '产品编码',
  `size` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '产品规格',
  `number` int(11) NULL DEFAULT NULL COMMENT '产品数量',
  `createtime` datetime NULL DEFAULT CURRENT_TIMESTAMP COMMENT '创建时间',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 12 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of product
-- ----------------------------
INSERT INTO `product` VALUES (3, 'airpods', '789', '100g', 90, '2023-03-04 13:33:33');
INSERT INTO `product` VALUES (4, '测试', '101', '100', 4, '2023-03-04 14:43:22');
INSERT INTO `product` VALUES (9, '枸杞', 'gq-103', '60g', 80, '2023-03-04 18:19:00');
INSERT INTO `product` VALUES (10, '水杯', 'sb-104', '500ml', 100, '2023-03-04 18:33:45');
INSERT INTO `product` VALUES (11, '口罩', 'mask-105', '5g', 100, '2023-03-04 20:55:38');

SET FOREIGN_KEY_CHECKS = 1;
