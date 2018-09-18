
BEGIN TRANSACTION;

CREATE TABLE IF NOT EXISTS `Asset` (
	`AssetID`     INTEGER PRIMARY KEY,
	`Name`        TEXT NOT NULL,
	`Description` TEXT NOT NULL,
	`Price`       REAL NOT NULL,
	`StockAmount` INTEGER NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS `SalesRecord` (
	`SaleID`    INTEGER PRIMARY KEY AUTOINCREMENT,
	`Timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
	`AmountPaidCash` REAL NOT NULL,
	`AmountPaidEftpos` REAL NOT NULL
);

CREATE TABLE IF NOT EXISTS `SalesAssets` (
	`SaleID`    INTEGER,
	`AssetID`   INTEGER,
	`Qty`       INTEGER NOT NULL,
	FOREIGN KEY(`SaleID`) REFERENCES `SalesRecord`(`SaleID`),
	PRIMARY KEY(`SaleID`,`AssetID`),
	FOREIGN KEY(`AssetID`) REFERENCES `Asset`(`AssetID`)
);

-- For testing, add some initial items
INSERT INTO Asset (`AssetID`, `Name`, `Description`, `Price`, `StockAmount`) VALUES (1, 'Meds',  'General Medicine', 1.50, 2);
INSERT INTO Asset (`AssetID`, `Name`, `Description`, `Price`, `StockAmount`) VALUES (2, 'Drugs', 'Its good stuff', 150, 4);
INSERT INTO Asset (`AssetID`, `Name`, `Description`, `Price`, `StockAmount`) VALUES (3, 'Pill', 'Try some', 10.40, 8);
INSERT INTO Asset (`AssetID`, `Name`, `Description`, `Price`, `StockAmount`) VALUES (4, 'Steak', 'All good chemists sell steak', 25, 16);

-- For testing, add some initial sales
INSERT INTO SalesRecord (`SaleID`, `AmountPaidCash`, `AmountPaidEftpos`) VALUES (1, 20, 0);
INSERT INTO SalesRecord (`SaleID`, `AmountPaidCash`, `AmountPaidEftpos`) VALUES (2, 0, 30);
INSERT INTO SalesRecord (`SaleID`, `AmountPaidCash`, `AmountPaidEftpos`) VALUES (3, 40, 50);

INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (1, 1, 5);
INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (1, 2, 6);

INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (2, 1, 4);
INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (2, 3, 8);
INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (2, 4, 3);

INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (3, 1, 5);
INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (3, 2, 6);
INSERT INTO SalesAssets(`SaleID`, `AssetID`, `Qty`) VALUES (3, 3, 7);

COMMIT;
