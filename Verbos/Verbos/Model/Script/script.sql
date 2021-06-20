CREATE TABLE IF NOT EXISTS `Person` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `Address` varchar(100) NOT NULL,
  `FirstName` varchar(80) NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `LastName` varchar(80) NOT NULL,
  PRIMARY KEY (`Id`)
) 