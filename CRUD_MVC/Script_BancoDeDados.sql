drop database if exists `cad_usuarios`;
CREATE DATABASE `cad_usuarios`;
use `cad_usuarios` ;
 

CREATE TABLE `nivel` (
  `id_nivel` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  PRIMARY KEY (`id_nivel`),
  UNIQUE KEY `nome` (`nome`)
); 

 

INSERT INTO `nivel` VALUES (1,'Administrador'),(3,'Desenvolvedor'),(2,'Usuário');

 

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `senha` varchar(25) DEFAULT NULL,
  `nivel` int(11) DEFAULT NULL,
  `data` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `email` (`email`),
  KEY `fk_nivel` (`nivel`),
  CONSTRAINT `fk_nivel` FOREIGN KEY (`nivel`) REFERENCES `nivel` (`id_nivel`)
);

 

INSERT INTO `usuarios` VALUES (1,'admin','admin@barth.com.br','123456',1,'2021-05-10 21:38:35');
INSERT INTO usuarios VALUES (2,'samuel','samuel@barth.com.br','password',1,'2022-11-24 14:16:25');





