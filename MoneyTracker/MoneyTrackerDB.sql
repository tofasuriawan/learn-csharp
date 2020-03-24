-- --------------------------------------------------------
-- Host:                         DESKTOP-1I9G0CI
-- Server version:               Microsoft SQL Server 2019 (RTM) - 15.0.2000.5
-- Server OS:                    Windows 10 Enterprise 10.0 <X64> (Build 18363: )
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for MoneyTrackerDB
CREATE DATABASE IF NOT EXISTS "MoneyTrackerDB";
USE "MoneyTrackerDB";

-- Dumping structure for table MoneyTrackerDB.Transaction
CREATE TABLE IF NOT EXISTS "Transaction" (
	"ID" INT NOT NULL,
	"Description" VARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Amount" DECIMAL(18,2) NULL DEFAULT NULL,
	"Type" BIT NULL DEFAULT NULL,
	"Date" DATETIME NULL DEFAULT NULL,
	PRIMARY KEY ("ID")
);

-- Dumping data for table MoneyTrackerDB.Transaction: -1 rows
/*!40000 ALTER TABLE "Transaction" DISABLE KEYS */;
INSERT INTO "Transaction" ("ID", "Description", "Amount", "Type", "Date") VALUES
	(1, 'Income March', 100000, b'1', '2020-03-24 16:21:23.233'),
	(2, 'Buy food', 50000, b'0', '2020-03-24 16:21:23.233'),
	(3, 'Tabungan', 2000, b'1', '2020-03-24 16:42:28.767'),
	(5, 'Cicilan', 1000, b'0', '2020-03-24 17:16:46.603');
/*!40000 ALTER TABLE "Transaction" ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
