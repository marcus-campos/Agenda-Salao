/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50153
Source Host           : localhost:3306
Source Database       : bd_agenda

Target Server Type    : MYSQL
Target Server Version : 50153
File Encoding         : 65001

Date: 2011-06-18 10:20:25
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `tbl_account`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_account`;
CREATE TABLE `tbl_account` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) NOT NULL,
  `login` varchar(80) NOT NULL,
  `senha` varchar(80) NOT NULL,
  `nvadm` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_account
-- ----------------------------
INSERT INTO tbl_account VALUES ('1', 'Marcus', 'admin', 'admin', '1');
INSERT INTO tbl_account VALUES ('2', 'Rafael', 'admin2', 'admin', '2');
INSERT INTO tbl_account VALUES ('3', 'Paulo', 'paulo', 'admin', '3');

-- ----------------------------
-- Table structure for `tbl_agendamento`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_agendamento`;
CREATE TABLE `tbl_agendamento` (
  `codigo_do_agendamento` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome_do_cliente` varchar(80) NOT NULL,
  `dia_do_atendimento` varchar(80) NOT NULL,
  `horario_do_atendimento` time NOT NULL,
  `servico` varchar(80) NOT NULL,
  `profissional` varchar(80) NOT NULL,
  `valor` double NOT NULL,
  PRIMARY KEY (`codigo_do_agendamento`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_agendamento
-- ----------------------------
INSERT INTO tbl_agendamento VALUES ('9', 'Marcus', 'sexta-feira, 17 de junho de 2011', '11:11:00', 'Cabelereiro', 'Marcus', '21002');
INSERT INTO tbl_agendamento VALUES ('10', 'cesar', 'sábado, 18 de junho de 2011', '12:00:00', 'Cabelereiro', 'Rafael', '9910');
INSERT INTO tbl_agendamento VALUES ('11', 'Julesca', 'sábado, 18 de junho de 2011', '01:11:00', 'Cabelereiro', 'Paulo', '12000');

-- ----------------------------
-- Table structure for `tbl_ativado`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ativado`;
CREATE TABLE `tbl_ativado` (
  `ativado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_ativado
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_chave`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_chave`;
CREATE TABLE `tbl_chave` (
  `chave` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_chave
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_funcionarios`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_funcionarios`;
CREATE TABLE `tbl_funcionarios` (
  `cod_proficional` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(80) DEFAULT NULL,
  `cpf` varchar(20) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `numero` int(10) DEFAULT NULL,
  `complemento` varchar(80) NOT NULL,
  `cidade` varchar(80) DEFAULT NULL,
  `telefone` varchar(20) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `nascimento` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`cod_proficional`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- ----------------------------
-- Records of tbl_funcionarios
-- ----------------------------
INSERT INTO tbl_funcionarios VALUES ('2', 's', null, null, '123', '\'\'', null, '', '', null);
INSERT INTO tbl_funcionarios VALUES ('3', 'Carina', '111,111,111-11', '00:00:00', '15', '', 'São Joaquim de Bicas', '(31) 3534-9061', '(31) 8454-8222', 'sábado, 26 de setembro de 1998');
INSERT INTO tbl_funcionarios VALUES ('4', 'carinia', '111,111,111-11', 'Rua Sergipi', '15', '', 'São Joaquim das bixas', '(31) 3534-9061', '(  )     -', 'sábado, 26 de setembro de 1998');
INSERT INTO tbl_funcionarios VALUES ('5', 'Fernada', '222,222,222-22', 'dsada', '12', '12', 'dasda', '(11) 1111-1111', '(11) 1111-1111', 'domingo, 29 de maio de 2011');

-- ----------------------------
-- Table structure for `tbl_servico`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_servico`;
CREATE TABLE `tbl_servico` (
  `cod_servico` int(11) NOT NULL AUTO_INCREMENT,
  `nome_servico` varchar(80) DEFAULT NULL,
  `descricao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cod_servico`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tbl_servico
-- ----------------------------
INSERT INTO tbl_servico VALUES ('1', 'Manicure', 'passa esmalte na unha\npinturas');
INSERT INTO tbl_servico VALUES ('2', 'Cabelereiro', 'Escova.');
