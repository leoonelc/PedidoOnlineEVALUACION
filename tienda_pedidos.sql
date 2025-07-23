-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-07-2025 a las 01:22:08
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda_pedidos`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCliente` (IN `nom` VARCHAR(100), IN `dir` VARCHAR(255))   BEGIN
    INSERT INTO Cliente (Nombre, Direccion) VALUES (nom, dir);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerDetallePedido` (IN `pedidoId` INT)   BEGIN
    SELECT dp.ID, p.Nombre AS Producto, dp.Cantidad, dp.Precio
    FROM DetallePedido dp
    JOIN Producto p ON dp.ID_Producto = p.ID
    WHERE dp.ID_Pedido = pedidoId;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerProductos` ()   BEGIN
    SELECT * FROM Producto;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertar_cliente` (IN `nombre` VARCHAR(100), IN `direccion` VARCHAR(255))   BEGIN
    IF nombre IS NOT NULL AND direccion IS NOT NULL THEN
        INSERT INTO Cliente(Nombre, Direccion) VALUES (nombre, direccion);
    ELSE
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Nombre y Dirección son obligatorios';
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_resumen_pedidos_por_cliente` (IN `cliente_id` INT)   BEGIN
    SELECT 
        p.ID AS PedidoID,
        p.Fecha,
        SUM(dp.Cantidad * dp.Precio) AS Total
    FROM Pedido p
    JOIN DetallePedido dp ON p.ID = dp.ID_Pedido
    WHERE p.ID_Cliente = cliente_id
    GROUP BY p.ID;
END$$

--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `fn_total_pedido` (`pedido_id` INT) RETURNS DECIMAL(10,2) DETERMINISTIC BEGIN
    DECLARE total DECIMAL(10,2);
    SELECT SUM(Cantidad * Precio) INTO total FROM DetallePedido WHERE ID_Pedido = pedido_id;
    RETURN IFNULL(total, 0.00);
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `TotalPedido` (`pedidoId` INT) RETURNS DECIMAL(10,2) DETERMINISTIC BEGIN
    DECLARE total DECIMAL(10,2);
    SELECT SUM(Cantidad * Precio) INTO total FROM DetallePedido WHERE ID_Pedido = pedidoId;
    RETURN IFNULL(total, 0.00);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Direccion` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ID`, `Nombre`, `Direccion`) VALUES
(6, 'Carlos Torres  prueba', 'Av. Eloy Alfaro 789'),
(7, 'Lucía Ramírez', 'Calle Sucre 321'),
(8, 'José Castillo  prueba', 'Av. Amazonas 654  prueba'),
(13, 'María Gómez  PRUEBA', 'Calle Bolívar 456'),
(15, 'JHOE CADENA prueba', 'STA ROSA DE CUZUBAMBA'),
(18, 'KARLA LOPEZ', 'CAYAMBE'),
(20, 'Carlos Torres', 'Av. Eloy Alfaro 789'),
(21, 'María Gómez  PRUEBA', 'Calle Bolívar 456'),
(22, 'JHOE CADENA  10', 'STA ROSA DE CUZUBAMBA'),
(23, 'Lucía Ramírez', 'Calle Sucre 321'),
(24, 'JHOE LEONEL', 'PRUEBA'),
(25, 'JHOE LEONEL', 'PRUEBA REGISTRAR '),
(26, 'jhoe prueba 2', 'sta prueba');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `logprecios`
--

CREATE TABLE `logprecios` (
  `ID` int(11) NOT NULL,
  `ID_Producto` int(11) DEFAULT NULL,
  `PrecioAnterior` decimal(10,2) DEFAULT NULL,
  `PrecioNuevo` decimal(10,2) DEFAULT NULL,
  `FechaCambio` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `logprecios`
--

INSERT INTO `logprecios` (`ID`, `ID_Producto`, `PrecioAnterior`, `PrecioNuevo`, `FechaCambio`) VALUES
(1, 1, 20.00, 25.00, '2025-07-23 01:28:04'),
(2, 2, 28.00, 30.00, '2025-07-23 01:28:04'),
(3, 3, 38.00, 40.00, '2025-07-23 01:28:04'),
(4, 4, 18.00, 20.00, '2025-07-23 01:28:04'),
(5, 5, 15.00, 18.00, '2025-07-23 01:28:04'),
(6, 1, 25.00, 45.00, '2025-07-23 10:52:01'),
(7, 53, 80.00, 30.00, '2025-07-23 11:21:18');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `ID` int(11) NOT NULL,
  `ID_Cliente` int(11) NOT NULL,
  `NombreCliente` varchar(255) DEFAULT NULL,
  `ID_Producto` int(11) NOT NULL,
  `Fecha` date NOT NULL DEFAULT curdate(),
  `Estado` varchar(255) DEFAULT NULL,
  `Pagado` tinyint(1) DEFAULT 0,
  `Precio` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`ID`, `ID_Cliente`, `NombreCliente`, `ID_Producto`, `Fecha`, `Estado`, `Pagado`, `Precio`) VALUES
(49, 20, NULL, 0, '2025-07-10', 'No disponible', 0, NULL),
(50, 8, NULL, 0, '2025-07-23', 'No Disponible', 0, NULL),
(72, 8, NULL, 30, '2025-07-23', 'No Disponible', 1, NULL),
(77, 20, NULL, 48, '2025-07-23', 'No Disponible', 1, NULL),
(81, 20, NULL, 30, '2025-07-18', 'No Disponible', 0, NULL),
(82, 13, NULL, 30, '2025-07-03', 'No Disponible', 1, NULL),
(83, 26, NULL, 29, '2025-07-23', 'No Disponible', 1, NULL),
(84, 8, NULL, 31, '2025-07-23', 'No Disponible', 1, NULL),
(85, 8, NULL, 47, '2025-07-23', 'No Disponible', 1, NULL),
(86, 8, NULL, 47, '2025-07-23', 'No Disponible', 1, NULL),
(87, 13, NULL, 25, '2025-07-23', 'No Disponible', 1, NULL),
(88, 13, NULL, 25, '2025-07-23', 'No Disponible', 1, NULL),
(89, 20, NULL, 47, '2025-07-18', 'No Disponible', 1, NULL),
(90, 8, NULL, 50, '2025-07-23', 'No Disponible', 1, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Precio` decimal(10,2) NOT NULL CHECK (`Precio` >= 0),
  `Stock` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`ID`, `Nombre`, `Precio`, `Stock`) VALUES
(2, 'ZAPATOS DE CUERO', 30.00, 150),
(3, 'ZAPATOS DE PIEL NEGRA', 40.00, 100),
(5, 'ZAPATOS DE GOMA', 20.00, 200),
(6, 'ZAPATOS DE MADERA', 60.00, 50),
(7, 'ZAPATOS DE VINO', 45.00, 120),
(8, 'ZAPATOS DE FIESTA DE DAMA', 60.00, 90),
(9, 'ZAPATOS DE FIESTA DE HOMBRE', 65.00, 75),
(10, 'ZAPATOS DE CORDÓN', 35.00, 180),
(11, 'BOTINES DE HOMBRE', 50.00, 140),
(12, 'BOTINES DE DAMA', 55.00, 130),
(13, 'BOTINES DE LONA', 40.00, 200),
(14, 'BOTINES DE PIEL', 70.00, 60),
(15, 'ZAPATOS DE MODA', 50.00, 100),
(16, 'ZAPATOS FORMAL', 75.00, 90),
(17, 'ZAPATOS DE TRAJE', 80.00, 50),
(18, 'ZAPATOS DE GALA', 85.00, 40),
(19, 'SANDALIAS DE GOMA', 25.00, 250),
(20, 'SANDALIAS DE PIEL', 40.00, 200),
(21, 'SANDALIAS DE MODA', 30.00, 150),
(22, 'SANDALIAS DE HOMBRE', 45.00, 120),
(23, 'SANDALIAS DE MUJER', 50.00, 110),
(24, 'ZAPATOS DE YOGA', 40.00, 160),
(25, 'ZAPATOS DE GIMNASIO', 55.00, 80),
(26, 'SNEAKERS DE CORRER', 70.00, 180),
(27, 'ZAPATILLAS DE BÁSQUET', 65.00, 200),
(28, 'ZAPATILLAS DE TENIS', 50.00, 220),
(29, 'ZAPATILLAS DE FÚTBOL', 60.00, 150),
(30, 'ZAPATILLAS DE VOLLEY', 45.00, 140),
(31, 'ZAPATILLAS DE GIMNASIO', 50.00, 130),
(32, 'ZAPATOS DE EXCURSIONISMO', 55.00, 90),
(33, 'ZAPATOS DE TÁCTICA', 70.00, 60),
(34, 'ZAPATOS DE ESTUDIO', 40.00, 180),
(35, 'ZAPATOS DE DIARIO', 30.00, 200),
(36, 'ZAPATOS DE FAMILIA', 25.00, 220),
(37, 'ZAPATOS DE CONFERENCIA', 60.00, 150),
(38, 'ZAPATOS DE CAMINATA', 45.00, 180),
(39, 'ZAPATOS DE ENERGÍA', 80.00, 110),
(40, 'ZAPATOS DE CONSTRUCCIÓN', 100.00, 40),
(41, 'BOTAS DE LLUVIA', 35.00, 300),
(42, 'BOTAS DE NIEVE', 90.00, 70),
(43, 'ZAPATOS DE HORMA ', 45.00, 0),
(44, 'ZAPATOS DE HORMA ', 45.00, 0),
(45, 'ZAPATOS DE HORMA ', 45.00, 0),
(46, 'ZAPATOS DE HORMA ', 45.00, 0),
(47, 'ZAPATOS DE HORMA ', 45.00, 0),
(48, 'ZAPATOS DE HORMA ', 45.00, 0),
(49, 'ZAPATOS DE HORMA ', 45.00, 0),
(50, 'ZAPATOS DE HORMA ', 45.00, 0),
(51, 'ZAPATOS DE HORMA ', 45.00, 0),
(52, 'ZAPATOS DE HORMA ', 45.00, 0),
(53, 'prueba de zpatos ', 30.00, 0);

--
-- Disparadores `producto`
--
DELIMITER $$
CREATE TRIGGER `PrecioProductoUpdate` BEFORE UPDATE ON `producto` FOR EACH ROW BEGIN
    IF OLD.Precio != NEW.Precio THEN
        INSERT INTO LogPrecios (ID_Producto, PrecioAnterior, PrecioNuevo)
        VALUES (OLD.ID, OLD.Precio, NEW.Precio);
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `prevent_delete_producto` BEFORE DELETE ON `producto` FOR EACH ROW BEGIN
    IF EXISTS (SELECT 1 FROM DetallePedido WHERE ID_Producto = OLD.ID) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'No se puede eliminar el producto porque está asociado a un pedido.';
    END IF;
END
$$
DELIMITER ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `logprecios`
--
ALTER TABLE `logprecios`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_Cliente` (`ID_Cliente`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de la tabla `logprecios`
--
ALTER TABLE `logprecios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
