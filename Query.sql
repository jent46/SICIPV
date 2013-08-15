SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `Base` ;
CREATE SCHEMA IF NOT EXISTS `Base` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `Base` ;

-- -----------------------------------------------------
-- Table `Base`.`Usuario`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Usuario` (
  `idUsuario` BIGINT NOT NULL AUTO_INCREMENT ,
  `nombre` VARCHAR(45) NOT NULL ,
  `apellido` VARCHAR(45) NOT NULL ,
  `usuario` VARCHAR(45) NOT NULL ,
  `contrasena` VARCHAR(45) NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  `estado` INT NOT NULL ,
  PRIMARY KEY (`idUsuario`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`Producto`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Producto` (
  `idProducto` BIGINT NOT NULL AUTO_INCREMENT ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `descripcion` VARCHAR(100) NOT NULL ,
  `valor` FLOAT NOT NULL ,
  `pvp` FLOAT NOT NULL ,
  `stock` INT NOT NULL ,
  `estado` INT NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idProducto`) ,
  INDEX `fk_Producto_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_Producto_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_Producto_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Producto_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`EstadoCivil`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`EstadoCivil` (
  `idEstadoCivil` BIGINT NOT NULL AUTO_INCREMENT ,
  `descripcion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`idEstadoCivil`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`Persona`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Persona` (
  `idPersona` BIGINT NOT NULL AUTO_INCREMENT ,
  `idEstadoCivil` BIGINT NOT NULL ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `nombre` VARCHAR(45) NOT NULL ,
  `cedula` VARCHAR(10) NOT NULL ,
  `telefono` VARCHAR(45) NOT NULL ,
  `direccion` VARCHAR(200) NOT NULL ,
  `estado` INT NOT NULL ,
  `fecha_nacimiento` DATE NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idPersona`) ,
  INDEX `fk_Persona_EstadoCivil1_idx` (`idEstadoCivil` ASC) ,
  INDEX `fk_Persona_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_Persona_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_Persona_EstadoCivil1`
    FOREIGN KEY (`idEstadoCivil` )
    REFERENCES `Base`.`EstadoCivil` (`idEstadoCivil` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Persona_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`TipoVenta`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`TipoVenta` (
  `idTipoVenta` BIGINT NOT NULL AUTO_INCREMENT ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `descripcion` VARCHAR(100) NOT NULL ,
  `estado` INT NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idTipoVenta`) ,
  INDEX `fk_TipoVenta_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_TipoVenta_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_TipoVenta_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TipoVenta_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`Factura`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Factura` (
  `idFactura` BIGINT NOT NULL AUTO_INCREMENT ,
  `idTipoVenta` BIGINT NOT NULL ,
  `idPersona` BIGINT NOT NULL ,
  `idGarante` BIGINT NOT NULL ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `numeroFactura` BIGINT NOT NULL ,
  `numeroContrato` BIGINT NOT NULL ,
  `fechaVenta` DATE NOT NULL ,
  `subtotal` FLOAT NOT NULL ,
  `iva` FLOAT NOT NULL ,
  `porcentajeDescuento` FLOAT NOT NULL ,
  `descuento` FLOAT NOT NULL ,
  `totalVenta` FLOAT NOT NULL ,
  `estado` INT(11) NOT NULL ,
  `cuotas` INT NOT NULL ,
  `clienteNombre` VARCHAR(45) NOT NULL ,
  `clienteCedula` VARCHAR(10) NOT NULL ,
  `clienteTelefono` VARCHAR(15) NOT NULL ,
  `clienteDireccion` VARCHAR(200) NOT NULL ,
  `garanteNombre` VARCHAR(45) NOT NULL ,
  `garanteCedula` VARCHAR(10) NOT NULL ,
  `garanteTelefono` VARCHAR(15) NOT NULL ,
  `garanteDireccion` VARCHAR(200) NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idFactura`) ,
  INDEX `fk_Factura_TipoVenta1_idx` (`idTipoVenta` ASC) ,
  INDEX `fk_Factura_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_Factura_Persona1_idx` (`idPersona` ASC) ,
  INDEX `fk_Factura_Persona2_idx` (`idGarante` ASC) ,
  INDEX `fk_Factura_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_Factura_TipoVenta1`
    FOREIGN KEY (`idTipoVenta` )
    REFERENCES `Base`.`TipoVenta` (`idTipoVenta` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Factura_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Factura_Persona1`
    FOREIGN KEY (`idPersona` )
    REFERENCES `Base`.`Persona` (`idPersona` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Factura_Persona2`
    FOREIGN KEY (`idGarante` )
    REFERENCES `Base`.`Persona` (`idPersona` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Factura_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`ItemFactura`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`ItemFactura` (
  `idItemFactura` BIGINT NOT NULL AUTO_INCREMENT ,
  `idFactura` BIGINT NOT NULL ,
  `idProducto` BIGINT NOT NULL ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `precioUnitario` FLOAT NOT NULL ,
  `cantidad` INT NOT NULL ,
  `precioTotal` FLOAT NOT NULL ,
  `descripcionProducto` VARCHAR(100) NOT NULL ,
  `costoProducto` FLOAT NOT NULL ,
  `estado` INT NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idItemFactura`) ,
  INDEX `fk_ItemFactura_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_ItemFactura_Producto1_idx` (`idProducto` ASC) ,
  INDEX `fk_ItemFactura_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  INDEX `fk_ItemFactura_Factura1_idx` (`idFactura` ASC) ,
  CONSTRAINT `fk_ItemFactura_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemFactura_Producto1`
    FOREIGN KEY (`idProducto` )
    REFERENCES `Base`.`Producto` (`idProducto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemFactura_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemFactura_Factura1`
    FOREIGN KEY (`idFactura` )
    REFERENCES `Base`.`Factura` (`idFactura` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`IngresoProducto`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`IngresoProducto` (
  `idIngresoProducto` BIGINT NOT NULL AUTO_INCREMENT ,
  `idProducto` BIGINT NOT NULL ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `cantidad` INT NOT NULL ,
  `fecha` DATE NOT NULL ,
  `estado` INT NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idIngresoProducto`) ,
  INDEX `fk_IngresoProducto_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_IngresoProducto_Producto1_idx` (`idProducto` ASC) ,
  INDEX `fk_IngresoProducto_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_IngresoProducto_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IngresoProducto_Producto1`
    FOREIGN KEY (`idProducto` )
    REFERENCES `Base`.`Producto` (`idProducto` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_IngresoProducto_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`Rol`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Rol` (
  `id_Rol` BIGINT NOT NULL AUTO_INCREMENT ,
  `idUsuario` BIGINT NOT NULL ,
  `descripcion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`id_Rol`) ,
  INDEX `fk_Rol_Usuario1_idx` (`idUsuario` ASC) ,
  CONSTRAINT `fk_Rol_Usuario1`
    FOREIGN KEY (`idUsuario` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`Cuota`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Cuota` (
  `idCuota` BIGINT NOT NULL AUTO_INCREMENT ,
  `idFactura` BIGINT NOT NULL ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `fecha` DATE NOT NULL ,
  `saldo` FLOAT NOT NULL ,
  `valorCuota` FLOAT NOT NULL ,
  `porcentajeInteres` FLOAT NOT NULL ,
  `interesFactura` FLOAT NOT NULL ,
  `interesMora` FLOAT NOT NULL ,
  `valorTotal` FLOAT NOT NULL ,
  `comentario` VARCHAR(45) NOT NULL ,
  `estado` INT NOT NULL ,
  `fechaCreacion` DATE NOT NULL ,
  `fechaModificacion` DATE NOT NULL ,
  PRIMARY KEY (`idCuota`) ,
  INDEX `fk_Cuota_Factura1_idx` (`idFactura` ASC) ,
  INDEX `fk_Cuota_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_Cuota_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_Cuota_Factura1`
    FOREIGN KEY (`idFactura` )
    REFERENCES `Base`.`Factura` (`idFactura` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cuota_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cuota_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Base`.`Abono`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Base`.`Abono` (
  `idAbono` BIGINT NOT NULL AUTO_INCREMENT ,
  `idCuota` BIGINT NOT NULL ,
  `idUsuarioCreacion` BIGINT NOT NULL ,
  `idUsuarioModificacion` BIGINT NOT NULL ,
  `fecha` DATE NOT NULL ,
  `valor` FLOAT NOT NULL ,
  PRIMARY KEY (`idAbono`) ,
  INDEX `fk_Abono_Cuota1_idx` (`idCuota` ASC) ,
  INDEX `fk_Abono_Usuario1_idx` (`idUsuarioCreacion` ASC) ,
  INDEX `fk_Abono_Usuario2_idx` (`idUsuarioModificacion` ASC) ,
  CONSTRAINT `fk_Abono_Cuota1`
    FOREIGN KEY (`idCuota` )
    REFERENCES `Base`.`Cuota` (`idCuota` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Abono_Usuario1`
    FOREIGN KEY (`idUsuarioCreacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Abono_Usuario2`
    FOREIGN KEY (`idUsuarioModificacion` )
    REFERENCES `Base`.`Usuario` (`idUsuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Base` ;

-- -----------------------------------------------------
-- procedure INS_Cuota
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_Cuota`(
IN _idFactura BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _fecha DATE, 
IN _saldo FLOAT,
IN _valorCuota FLOAT,
IN _porcentajeInteres FLOAT,
IN _interesFactura FLOAT,
IN _interesMora FLOAT,
IN _valorTotal FLOAT,
IN _comentario VARCHAR(500),
IN _estado	INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
INSERT INTO Cuota(idFactura,idUsuarioCreacion,idUsuarioModificacion,fecha,saldo,valorCuota,porcentajeInteres,
				interesFactura,interesMora,valorTotal,comentario,estado,fechaCreacion,fechaModificacion)
VALUES (_idFactura,_idUsuarioCreacion,_idUsuarioModificacion,_fecha,_saldo,_valorCuota,_porcentajeInteres,
				_interesFactura,_interesMora,_valorTotal,_comentario,_estado,_fechaCreacion,_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_Usuario
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE PROCEDURE `base`.`INS_Usuario`(
IN _nombre VARCHAR(45),
IN _apellido VARCHAR(45),
IN _usuario VARCHAR(45),
IN _contrasena VARCHAR(45),
IN _fechaCreacion DATE,
IN _fechaModificacion DATE,
IN _estado INT
)
BEGIN
INSERT INTO Usuario (nombre,apellido,usuario,contrasena,fechaCreacion,fechaModificacion,estado)
VALUES(_nombre,_apellido,_usuario,_contrasena,_fechaCreacion,_fechaModificacion,_estado);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_Producto
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_Producto`(
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _descripcion VARCHAR(200),
IN _valor FLOAT,
IN _pvp FLOAT,
IN _stock INT,
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
INSERT INTO Producto(idUsuarioCreacion,idUsuarioModificacion,descripcion,valor,pvp,stock,estado,fechaCreacion,fechaModificacion)
VALUES (_idUsuarioCreacion,_idUsuarioModificacion,_descripcion,_valor,_pvp,_stock,_estado,_fechaCreacion,_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_IngresoProducto
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_IngresoProducto`(
IN _idProducto BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _cantidad INT,
IN _fecha DATE,
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
INSERT INTO IngresoProducto(idProducto,idUsuarioCreacion,idUsuarioModificacion,
			cantidad,fecha,estado,fechaCreacion,fechaModificacion)
VALUES (_idProducto,_idUsuarioCreacion,_idUsuarioModificacion,
	_cantidad,_fecha,_estado,_fechaCreacion,_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_TipoVenta
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_TipoVenta`(
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _descripcion VARCHAR(100),
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion BIGINT
)
BEGIN
INSERT INTO TipoVenta(idUsuarioCreacion,idUsuarioModificacion,descripcion,
					  estado,fechaCreacion,_fechaModificacion)
VALUES (_idUsuarioCreacion,_idUsuarioModificacion,_descripcion,_estado,_fechaCreacion,
		_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_Abono
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_Abono`(
IN _idCuota BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _fecha DATE,
IN _valor FLOAT
)
BEGIN
INSERT INTO Abono(idCuota,idUsuarioCreacion,idUsuarioModificacion,fecha ,valor)
VALUES(_idCuota,_idUsuarioCreacion,_idUsuarioModificacion,_fecha ,_valor);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_Persona
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_Persona`(
IN _idEstadoCivil BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _nombre VARCHAR(45),
IN _cedula VARCHAR(10),
IN _telefono VARCHAR(45),
IN _direccion VARCHAR(200),
IN _estado INT,
IN _fechaDeNacimiento DATE,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
INSERT INTO Persona(idEstadoCivil,idUsuarioCreacion
,idUsuarioModificacion,nombre,cedula,telefono,direccion,estado
,fechaDeNacimiento,fechaCreacion,fechaModificacion)
VALUES(_idEstadoCivil,_idUsuarioCreacion,_idUsuarioModificacion,
		_nombre,_cedula,_telefono,_direccion,_estado,
		_fechaDeNacimiento,_fechaCreacion,_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_Factura
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_Factura`(
IN _idTipoVenta BIGINT,
IN _idPersona BIGINT,
IN _idGarante BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _numeroFactura BIGINT,
IN _numeroContrato BIGINT,
IN _fechaVenta DATE,
IN _subtotal FLOAT,
IN _iva FLOAT,
IN _porcentajeDescuento FLOAT,
IN _descuento FLOAT,
IN _totalVenta FLOAT,
IN _estado INT,
IN _cuotas INT,
IN _clienteNombre VARCHAR(45),
IN _clienteCedula VARCHAR(10),
IN _clienteTelefono VARCHAR(15),
IN _clienteDireccion VARCHAR(200),
IN _garanteNombre VARCHAR(45),
IN _garanteCedula VARCHAR(10),
IN _garanteTelefono VARCHAR(15),
IN _garanteDireccion VARCHAR(200),
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
INSERT INTO Factura(idTipoVenta,idPersona,idGarante,idUsuarioCreacion,idUsuarioModificacion,numeroFactura,
	   numeroContrato,fechaVenta,subtotal,iva,porcentajeDescuento,descuento,totalVenta,estado,cuotas,
	   clienteNombre,clienteCedula,clienteTelefono,clienteDireccion,garanteNombre,garanteCedula,garanteTelefono,
	   garanteDireccion,fechaCreacion,fechaModificacion)
VALUES(_idTipoVenta,_idPersona,_idGarante,_idUsuarioCreacion,_idUsuarioModificacion,_numeroFactura,
	   _numeroContrato,_fechaVenta,_subtotal,_iva,_porcentajeDescuento,_descuento,_totalVenta,_estado,_cuotas,
	   _clienteNombre,_clienteCedula,_clienteTelefono,_clienteDireccion,_garanteNombre,_garanteCedula,_garanteTelefono,
	   _garanteDireccion,_fechaCreacion,_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INS_ItemFactura
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_ItemFactura`(
IN _idFactura BIGINT,
IN _idProducto BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _precioUnitario FLOAT,
IN _cantidad INT,
IN _precioTotal FLOAT,
IN _descripcionProducto VARCHAR(100),
IN _costoProducto FLOAT,
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
INSERT INTO ItemFactura(idFactura,idProducto,idUsuarioCreacion,idUsuarioModificacion,precioUnitario,cantidad,
						precioTotal,descripcionProducto,costoProducto,estado,fechaCreacion,fechaModificacion)
VALUES (_idFactura,_idProducto,_idUsuarioCreacion,_idUsuarioModificacion,_precioUnitario,_cantidad,
		_precioTotal,_descripcionProducto,_costoProducto,_estado,_fechaCreacion,_fechaModificacion);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_Usuario
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_Usuario`(
IN _idUsuario BIGINT,
IN _nombre VARCHAR(45),
IN _apellido VARCHAR(45),
IN _usuario VARCHAR(45),
IN _contrasena VARCHAR(45),
IN _fechaCreacion DATE,
IN _fechaModificacion DATE,
IN _estado INT
)
BEGIN
UPDATE Usuario
SET nombre=_nombre,apellido=_apellido,usuario=_usuario,contrasena=_contrasena,fechaCreacion=_fechaCreacion,fechaModificacion=_fechaModificacion,estado=_estado
WHERE idUsuario=_idUsuario;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_Producto
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_Producto`(
IN _idProducto BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _descripcion VARCHAR(200),
IN _valor FLOAT,
IN _pvp FLOAT,
IN _stock INT,
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
UPDATE Producto
SET idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	descripcion=_descripcion,
	valor=_valor,pvp=_pvp,stock=_stock,estado=_estado,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idProducto=_idProducto;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_IngresoProducto
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_IngresoProducto`(
IN _idIngresoProducto BIGINT,
IN _idProducto BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _cantidad INT,
IN _fecha DATE,
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
UPDATE IngresoProducto
SET	idProducto=_idProducto,
	idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	cantidad=_cantidad,
	fecha=_fecha,
	estado=_estado,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idIngresoProducto=_idIngresoProducto;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_TipoVenta
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_TipoVenta`(
IN _idTipoVenta BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _descripcion VARCHAR(100),
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion BIGINT
)
BEGIN
UPDATE TipoVenta
SET idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	descripcion=_descripcion,
	estado=_estado,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idTipoVenta=_idTipoVenta;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_Cuota
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_Cuota`(
IN _idCuota BIGINT,
IN _idFactura BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _fecha DATE, 
IN _saldo FLOAT,
IN _valorCuota FLOAT,
IN _porcentajeInteres FLOAT,
IN _interesFactura FLOAT,
IN _interesMora FLOAT,
IN _valorTotal FLOAT,
IN _comentario VARCHAR(500),
IN _estado	INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
UPDATE Cuota
SET idFactura=_idFactura,
	idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	fecha=_fecha,
	saldo=_saldo,
	valorCuota=_valorCuota,
	porcentajeInteres=_porcentajeInteres,
	interesFactura=_interesFactura,
	interesMora=_interesMora,
	valorTotal=_valorTotal,
	comentario=_comentario,
	estado=_estado,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idCuota=_idCuota ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_Abono
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_Abono`(
IN _idAbono BIGINT,
IN _idCuota BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _fecha DATE,
IN _valor FLOAT
)
BEGIN
UPDATE Abono
SET idCuota=_idCuota,
	idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	fecha=_fecha,
	valor=_valor
WHERE idAbono=_idAbono;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_Persona
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_Persona`(
IN _idPersona BIGINT,
IN _idEstadoCivil BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _nombre VARCHAR(45),
IN _cedula VARCHAR(10),
IN _telefono VARCHAR(45),
IN _direccion VARCHAR(200),
IN _estado INT,
IN _fechaDeNacimiento DATE,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
UPDATE Persona
SET idEstadoCivil=_idEstadoCivil,
	idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	nombre=_nombre,
	cedula=_cedula,
	telefono=_telefono,
	direccion=_direccion,
	estado=_estado,
	fechaDeNacimiento=_fechaDeNacimiento,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idPersona=_idPersona;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_Factura
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_Factura`(
IN _idFactura BIGINT,
IN _idTipoVenta BIGINT,
IN _idPersona BIGINT,
IN _idEstadoCivil BIGINT,
IN _idGarante BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _numeroFactura BIGINT,
IN _numeroContrato BIGINT,
IN _fechaVenta DATE,
IN _subtotal FLOAT,
IN _iva FLOAT,
IN _porcentajeDescuento FLOAT,
IN _descuento FLOAT,
IN _totalVenta FLOAT,
IN _estado INT,
IN _cuotas INT,
IN _clienteNombre VARCHAR(45),
IN _clienteCedula VARCHAR(10),
IN _clienteTelefono VARCHAR(15),
IN _clienteDireccion VARCHAR(200),
IN _garanteNombre VARCHAR(45),
IN _garanteCedula VARCHAR(10),
IN _garanteTelefono VARCHAR(15),
IN _garanteDireccion VARCHAR(200),
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
UPDATE Factura
SET	idTipoVenta=_idTipoVenta,
	idPersona=_idPersona,
	idEstadoCivil=_idEstadoCivil,
	idGarante=_idGarante,
	idUsuarioCreacion=_idUsuarioCreacion,	
	idUsuarioModificacion=_idUsuarioModificacion,	
	numeroFactura=_numeroFactura,
	numeroContrato=_numeroContrato,
	fechaVenta=_fechaVenta,
	subtotal=_subtotal,
	iva=_iva,
	porcentajeDescuento=_porcentajeDescuento,
	descuento=_descuento,
	totalVenta=_totalVenta,
	estado=_estado,
	cuotas=_cuotas,
	clienteNombre=_clienteNombre,
	clienteCedula=_clienteCedula,
	clienteTelefono=_clienteTelefono,
	clienteDireccion=_clienteDireccion,
	garanteNombre=_garanteNombre,
	garanteCedula=_garanteCedula,
	garanteTelefono=_garanteTelefono,
	garanteDireccion=_garanteDireccion,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idFactura=_idFactura;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UPD_ItemFactura
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_ItemFactura`(
IN _idItemFactura BIGINT,
IN _idFactura BIGINT,
IN _idProducto BIGINT,
IN _idUsuarioCreacion BIGINT,
IN _idUsuarioModificacion BIGINT,
IN _precioUnitario FLOAT,
IN _cantidad INT,
IN _precioTotal FLOAT,
IN _descripcionProducto VARCHAR(100),
IN _costoProducto FLOAT,
IN _estado INT,
IN _fechaCreacion DATE,
IN _fechaModificacion DATE
)
BEGIN
UPDATE ItemFactura
SET idFactura=_idFactura,
	idProducto=_idProducto,
	idUsuarioCreacion=_idUsuarioCreacion,
	idUsuarioModificacion=_idUsuarioModificacion,
	precioUnitario=_precioUnitario,
	cantidad=_cantidad,
	precioTotal=_precioTotal,
	descripcionProducto=_descripcionProducto,
	costoProducto=_costoProducto,
	estado=_estado,
	fechaCreacion=_fechaCreacion,
	fechaModificacion=_fechaModificacion
WHERE idItemFactura=_idItemFactura;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure QRY_ConsultarFacturasPorNombreCliente
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `QRY_ConsultarFacturasPorNombreCliente`(IN _contrato BIGINT)
BEGIN
SELECT * FROM Factura 
WHERE  numeroContratro=_contrato;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure QRY_ConsultarFacturasPorNumeroContrato
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `QRY_ConsultarFacturasPorNumeroContrato`(IN _nombre VARCHAR(45))
BEGIN
SELECT * FROM Factura 
WHERE  clienteNombre=_nombre;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure QRY_ConsultarFacturasPorNumeroFactura
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `QRY_ConsultarFacturasPorNumeroFactura`(IN _factura BIGINT)
BEGIN
SELECT * FROM Factura 
WHERE  numeroFactura=_factura;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure QRY_ConsultarFacturasPorCedula
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `QRY_ConsultarFacturasPorCedula`(IN _cedula VARCHAR(45))
BEGIN
SELECT * FROM Factura 
WHERE  clienteCedula=_cedula;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure QRY_login
-- -----------------------------------------------------

DELIMITER $$
USE `Base`$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `QRY_login`(IN _usuario VARCHAR(45),IN _clave VARCHAR(45))
BEGIN
SELECT * FROM Usuario 
WHERE  usuario=_usuario AND contrasena=_contrasena;
END$$

DELIMITER ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
