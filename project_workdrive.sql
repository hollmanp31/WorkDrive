-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 17-02-2025 a las 19:38:06
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `project_workdrive`
--
CREATE DATABASE IF NOT EXISTS `project_workdrive` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `project_workdrive`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `disponibilidad`
--

DROP TABLE IF EXISTS `disponibilidad`;
CREATE TABLE `disponibilidad` (
  `Id_disponibilidad` int(1) UNSIGNED NOT NULL,
  `Id_empleado` int(1) UNSIGNED NOT NULL,
  `Horario` datetime NOT NULL,
  `Estado` char(2) NOT NULL DEFAULT 'I'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `Id_empleado` int(1) UNSIGNED NOT NULL,
  `Id_R` int(1) UNSIGNED NOT NULL,
  `Certificado` varchar(100) NOT NULL,
  `Curriculum` varchar(100) NOT NULL,
  `Id_labor` int(1) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `labores`
--

DROP TABLE IF EXISTS `labores`;
CREATE TABLE `labores` (
  `Id_labor` int(1) UNSIGNED NOT NULL,
  `Nombre` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

DROP TABLE IF EXISTS `pagos`;
CREATE TABLE `pagos` (
  `Id_pagos` int(1) UNSIGNED NOT NULL,
  `Id_servicios` int(1) UNSIGNED NOT NULL,
  `Monto` decimal(10,3) NOT NULL,
  `Metodo_pago` enum('Efecitvo','Tarjetas','Transferencias Bancarias','') NOT NULL,
  `Hora` time NOT NULL,
  `Fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registros`
--

DROP TABLE IF EXISTS `registros`;
CREATE TABLE `registros` (
  `Id_registro` int(1) UNSIGNED NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellidos` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varbinary(100) NOT NULL,
  `Tipo_usuario` enum('1','2') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `servicios`
--

DROP TABLE IF EXISTS `servicios`;
CREATE TABLE `servicios` (
  `Id_servicio` int(1) UNSIGNED NOT NULL,
  `Id_R` int(1) UNSIGNED NOT NULL,
  `Direccion` varchar(100) NOT NULL,
  `Descripcion` text NOT NULL,
  `Valor` decimal(10,3) NOT NULL,
  `Metodo_pago` enum('Efectivo','Tarjetas','Transferencias Bancarias') NOT NULL,
  `estado` enum('N/A','En proceso','Realizado') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipos_usuarios`
--

DROP TABLE IF EXISTS `tipos_usuarios`;
CREATE TABLE `tipos_usuarios` (
  `Id_tipo_usuario` enum('1','2') NOT NULL,
  `Nombre` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tipos_usuarios`
--

INSERT INTO `tipos_usuarios` (`Id_tipo_usuario`, `Nombre`) VALUES
('1', 'Persona Natural '),
('2', 'Empleado ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `Id_usuario` int(1) UNSIGNED NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `Password` varbinary(100) NOT NULL,
  `Id_R` int(1) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios_servicios`
--

DROP TABLE IF EXISTS `usuarios_servicios`;
CREATE TABLE `usuarios_servicios` (
  `Id_usuario` int(1) UNSIGNED NOT NULL,
  `Id_servicio` int(1) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `disponibilidad`
--
ALTER TABLE `disponibilidad`
  ADD PRIMARY KEY (`Id_disponibilidad`),
  ADD KEY `Id_empleado_Id_Empleados` (`Id_empleado`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`Id_empleado`),
  ADD KEY `Id_R_Id_registro_FK` (`Id_R`),
  ADD KEY `Id_labor_Id_labor_FK` (`Id_labor`);

--
-- Indices de la tabla `labores`
--
ALTER TABLE `labores`
  ADD PRIMARY KEY (`Id_labor`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`Id_pagos`),
  ADD KEY `Id_servicios_Id_servico` (`Id_servicios`);

--
-- Indices de la tabla `registros`
--
ALTER TABLE `registros`
  ADD PRIMARY KEY (`Id_registro`),
  ADD KEY `Tipo_usuario_Id_tipo_usuario_FK` (`Tipo_usuario`);

--
-- Indices de la tabla `servicios`
--
ALTER TABLE `servicios`
  ADD PRIMARY KEY (`Id_servicio`);

--
-- Indices de la tabla `tipos_usuarios`
--
ALTER TABLE `tipos_usuarios`
  ADD PRIMARY KEY (`Id_tipo_usuario`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id_usuario`),
  ADD KEY `Id_registros_Id_R_FK` (`Id_R`);

--
-- Indices de la tabla `usuarios_servicios`
--
ALTER TABLE `usuarios_servicios`
  ADD KEY `Id_servicios_Id_servicio_FK` (`Id_servicio`),
  ADD KEY `Id_usuario_Id_usuario_FK` (`Id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `disponibilidad`
--
ALTER TABLE `disponibilidad`
  MODIFY `Id_disponibilidad` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `Id_empleado` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `labores`
--
ALTER TABLE `labores`
  MODIFY `Id_labor` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `Id_pagos` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `registros`
--
ALTER TABLE `registros`
  MODIFY `Id_registro` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `servicios`
--
ALTER TABLE `servicios`
  MODIFY `Id_servicio` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id_usuario` int(1) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `disponibilidad`
--
ALTER TABLE `disponibilidad`
  ADD CONSTRAINT `Id_empleado_Id_Empleados` FOREIGN KEY (`Id_empleado`) REFERENCES `empleados` (`Id_empleado`);

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `Id_R_Id_registro_FK` FOREIGN KEY (`Id_R`) REFERENCES `registros` (`Id_registro`),
  ADD CONSTRAINT `Id_labor_Id_labor_FK` FOREIGN KEY (`Id_labor`) REFERENCES `labores` (`Id_labor`);

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `Id_servicios_Id_servico` FOREIGN KEY (`Id_servicios`) REFERENCES `servicios` (`Id_servicio`);

--
-- Filtros para la tabla `registros`
--
ALTER TABLE `registros`
  ADD CONSTRAINT `Tipo_usuario_Id_tipo_usuario_FK` FOREIGN KEY (`Tipo_usuario`) REFERENCES `tipos_usuarios` (`Id_tipo_usuario`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `Id_registros_Id_R_FK` FOREIGN KEY (`Id_R`) REFERENCES `registros` (`Id_registro`);

--
-- Filtros para la tabla `usuarios_servicios`
--
ALTER TABLE `usuarios_servicios`
  ADD CONSTRAINT `Id_servicios_Id_servicio_FK` FOREIGN KEY (`Id_servicio`) REFERENCES `servicios` (`Id_servicio`),
  ADD CONSTRAINT `Id_usuario_Id_usuario_FK` FOREIGN KEY (`Id_usuario`) REFERENCES `usuarios` (`Id_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
