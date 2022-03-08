CREATE DATABASE ciberinfraestructura;

CREATE TABLE IF NOT EXISTS `ciberinfraestructura`.`CatPersonal` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(180) NOT NULL,
  `Cargo` VARCHAR(180) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `ciberinfraestructura`.`CatProducto` (
  `ID` INT NOT NULL,
  `Descripcion` VARCHAR(40) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `ciberinfraestructura`.`tblInventario` (
  `ID` INT NOT NULL,
  `IDProducto` INT NOT NULL,
  `Cantidad` INT NOT NULL DEFAULT 0,
  `FechaAlta` VARCHAR(45) NOT NULL DEFAULT 'CURRENT_TIMESTAMP',
  PRIMARY KEY (`ID`),
  INDEX `fk_tblInventario_CatProducto_idx` (`IDProducto` ASC) VISIBLE,
  CONSTRAINT `fk_tblInventario_CatProducto`
    FOREIGN KEY (`IDProducto`)
    REFERENCES `ciberinfraestructura`.`CatProducto` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;