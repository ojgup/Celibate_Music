/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM SALE2177;
DELETE FROM Customer2177;
DELETE FROM RECORD2177;
DELETE FROM INTEREST2177;


INSERT INTO INTEREST2177(INTERESTCODE, [DESCRIPTION]) VALUES
('RR', 'ROCK AND ROLL'),
('JA', 'JAZZ'),
('RB', 'RHYTHM AND BLUES');


INSERT INTO Record2177(ID, TITLE, PERFORMER) VALUES
('PF003', 'THE WALL', 'PINK FLOYD'),
('IX002', 'KICK', 'INXS'),
('SP069', 'NEVER MIND THE BOLLOCKS', 'SEX PISTOLS'),
('PF002', 'THE DARK SIDE OF THE MOON', 'PINK FLOYD'),
('IX005','Shabooh Shoobah', 'INXS'),
('SP070', 'Floggin a Dead Horse', 'SEX PISTOLS'),
('PF004', 'THE ENDLESS RIVER', 'PINK FLOYD'),
('PF006', 'WISH YOU WERE HERE', 'PINK FLOYD'),
('SP075', 'AGENTS OF ANARCHY', 'SEX PISTOLS'),
('PF007', 'THE DIVISION BELL', 'PINK FLOYD');

INSERT INTO CUSTOMER2177(CUSTOMERID, [NAME], [ADDRESS], POSTCODE, INTERESTCODE) VALUES
('123', 'Jimmy Barnes', '1 Sesame Street', '3000', 'RR'),
('456', 'Ian Moss', '10 Downing Street', '4000', 'JA'),
('789', 'Don Walker', '221B Baker Street', '5000', 'RB'),
('234', 'Steve Prestwich', 'LG1 College Cres, Parkville', '6000', 'RR'),
('567', 'Phil Small', '1 Adelaide Avenue', '7000', 'RB');



INSERT INTO SALE2177(CUSTOMERID, INTERESTCODE, RECORDID, SALEDATE, PRICE) VALUES
('123', 'RR', 'PF003', '2015-12-1', 30.00),
('123', 'RR', 'IX002', '2015-12-1', 29.95),
('123', 'RR', 'SP069', '2015-12-2', 12.45),
('123', 'RR', 'IX002', '2015-12-5', 30.00),
('456', 'JA', 'PF002', '2015-12-1', 31.00),
('456', 'JA', 'IX005', '2015-12-3', 28.95),
('456', 'JA', 'SP070', '2015-12-6', 13.45),
('789', 'RB', 'PF004', '2015-12-2', 29.00),
('789', 'RB', 'IX002', '2015-12-5', 29.95),
('234', 'RR', 'PF006', '2015-12-1', 45.00),
('234', 'RR', 'SP075', '2015-12-4', 5.67),
('567', 'RB', 'PF007', '2015-12-3', 9.95);



