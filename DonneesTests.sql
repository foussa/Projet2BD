use BD5B6TP2_BrodeurKouma;

print 'Insertion des enregistrements dans la table Employes...'
INSERT INTO Employes VALUES (2, 'Secret2', 'Vincent', 'George', 'H', 55, 324, 'Marquette', 'Laval', 'QC', 'H7E2B5', 4503548575, NULL, 'canard@hotmail.com', 38.00, 2, NULL);
INSERT INTO Employes VALUES (3, 'Secret3', 'Capicolo', 'Tony', 'H', 48, 24, 'Fenelon', 'Dorval', 'QC', 'H9T7A2', 5146336473, NULL, 'georgy44@gmail.com', 55.66, 3, NULL);
INSERT INTO Employes VALUES (4, 'Secret4', 'Right', 'Amanda', 'F', 39, 64, 'Fabiola', 'Rosemère', 'QC', 'H7Y8S9', 5147773847, NULL, 'Capicolo@hotmail.com', 52.55, 3, NULL);
INSERT INTO Employes VALUES (5, 'Secret5', 'Jefferson', 'Pamela', 'F', 60, 3, 'Deschamps', 'Saint-Raphaël', 'QC', 'J4V2N9', 4506638277, NULL, 'Jeffpam@gdi.com', 55.00, 3, NULL);
INSERT INTO Employes VALUES (6, 'Secret6', 'Tremblay', 'Arthur', 'H', 32, 4, 'Champlain', 'Candiac', 'QC', 'J4R1C9', 4508889483, 5149938373, 'arttrem3@gmail.com', 20.33, 4, NULL);
INSERT INTO Employes VALUES (7, 'Secret7', 'Farant', 'Charles', 'H', 37, 432, 'Avenue Dorval', 'Dorval', 'QC', 'H9S1A2', 5146337748, NULL, 'salut76@google.com', 18.44, 4, NULL);
INSERT INTO Employes VALUES (8, 'Secret8', 'Mcarthy', 'John', 'H', 46, 123, 'Don Quichote', 'Ile-Perrot', 'QC', 'J7V7P2',5144537464, NULL, 'Johnm@hotmail.com', 19.44, 4, NULL);
INSERT INTO Employes VALUES (9, 'Secret9', 'Sanson', 'Gaby', 'H', 22, 444, '35e avenue', 'Montréal', 'QC', 'H2S3T4', 5145537272, NULL, 'gaby.sanson@videotron.ca', 12.65, 5, NULL);
INSERT INTO Employes VALUES (10, 'Secret10', 'Tremblay', 'Isabelle', 'F', 29, 643, 'Sherbrooke', 'Montréal', 'QC', 'H8S3Z4', 5149389999 ,5145553838, 'Isa756@gmail.com', 14.66, 5, NULL);
INSERT INTO Employes VALUES (11, 'Secret11', 'Gabrieli', 'Fiona', 'F', 31, 44, 'Lakeshore', 'Dorval', 'QC', 'H9T7A2', 5146345566, NULL, 'fiong@smart.com', 15.00, 5, NULL);
INSERT INTO Employes VALUES (12, 'Secret12', 'Jones', 'James', 'H', 19, 967, 'Frenette', 'Laval', 'QC', 'H5H2B5', 4508732222, NULL, 'jj3434@hotmail.com', 12.65, 6, NULL);
INSERT INTO Employes VALUES (13, 'Secret13', 'Dumarquet', 'Ovide', 'H', 25, 887, 'Saint-Charles', 'Montréal', 'QC', 'H4E8T2', 5147365467, 4386664747, 'dumo@gmail.com', 12.65, 6, NULL);
INSERT INTO Employes VALUES (14, 'Secret14', 'Thompson', 'Daniel', 'H', 30, 651, 'Duquette', 'Longueuil', 'QC', 'J4W1M9',4507749930, NULL, 'danth@smart.com', 16.44, 6, NULL);
INSERT INTO Employes VALUES (15, 'Secret15', 'Macam', 'Thomas', 'H', 45, 33, '10e avenue', 'Rosemère', 'QC', 'H6F9Y7', 4508243555, 4386357746, 'macrame@gdi.com', 30.00, 7, NULL);

print 'Insertion des enregistrements dans la table Services...'
INSERT INTO Services VALUES (1, 'Magasin Pro Shop', 9, NULL);
INSERT INTO Services VALUES (2, 'Magasin Pro Shop', 10, NULL);
INSERT INTO Services VALUES (3, 'Magasin Pro Shop', 11, NULL);
INSERT INTO Services VALUES (4, 'Restaurant', 12, NULL);
INSERT INTO Services VALUES (5, 'Restaurant', 13, NULL);
INSERT INTO Services VALUES (6, 'Restaurant', 14, NULL);
INSERT INTO Services VALUES (7, 'Leçon de golf', 15, NULL);

print 'Insertion des enregistrements dans la table Abonnements...'
INSERT INTO Abonnements VALUES ('Tremblay1P', '2017-04-28', 'Tremblay', 'Hugo', 'H', '1990-02-23', 323, '32e avenue', 'Montréal', 'QC', 'H3V8T2', 5143039999, NULL, 'tremh@hotmail.com', 5, NULL);
INSERT INTO Abonnements VALUES ('Maori2P', '2018-03-03', 'Maori', 'Giona', 'F', '1972-04-22', 222, 'kirkland', 'Laval', 'QC', 'H7E2B5', 4509937262, NULL, 'maori543@gmail.com', 1, NULL);
INSERT INTO Abonnements VALUES ('Johnson3P', '2016-12-21', 'Johnson', 'Jeff', 'H', '1960-12-25', 45, 'Fenelon', 'Dorval', 'QC', 'H9T7A2', 5146337820, 4388399393, 'jefj@hotmail.com', 1, NULL);
INSERT INTO Abonnements VALUES ('Grandprix4P', '2017-06-01', 'Grandprix', 'Gédéon', 'H', '1985-08-04', 656, 'Saint-Laurent', 'Montréal', 'QC', 'H7Y8S9', 5145362727, NULL, 'ged77on@smart.com', 5, NULL);
INSERT INTO Abonnements VALUES ('Lajoie5P', '2018-05-04', 'Lajoie', 'Daphné', 'F', '1980-11-11', 987, 'Dumais', 'Rosemère', 'QC', 'H9S9J9', 4508396657, NULL, 'd.lajoie@videotron.ca', 6, NULL);
INSERT INTO Abonnements VALUES ('Fredette6P', '2016-11-23', 'Fredette', 'Guillaume', 'H', '1981-05-12', 765, 'Vandal', 'Brossard', 'QC', 'J4R1C9', 4507345262, 5143034545, 'gfre@gmail.com', 3, NULL);
INSERT INTO Abonnements VALUES ('Gagnon7P', '2018-08-02', 'Gagnon', 'Emile', 'H', '1982-09-24', 51, 'Dawson', 'Dorval', 'QC', 'H9S1A2', 5146351199, NULL, 'emile44@smart.com', 3, NULL);
INSERT INTO Abonnements VALUES ('Jeffes8P', '2017-01-27', 'Jeffes', 'Peter', 'H', '1979-01-30', 241, '23e avenue', 'Montréal', 'QC', 'H7B6T4', 5143738837, 4383992828, 'petjef@hotmail.com', 1, NULL);
INSERT INTO Abonnements VALUES ('Zhu9P', '2018-06-30', 'Zhu', 'Zao', 'H', '1982-12-21', 333, 'Lavalet', 'Laval', 'QC', 'H2S3T4', '4502228338', 4388976654, 'zaozhu@hotmail.com', 1, NULL);
INSERT INTO Abonnements VALUES ('Dion10P', '2017-02-28', 'Dion', 'Serge', 'H', '1958-06-28', 22, 'Finlandais', 'Candiac', 'QC', 'J4V2N9', 4508375555, NULL, 'serge.dion@videotron.ca', 2, NULL);

print 'Insertion des enregistrements dans la table Dependants...'
INSERT INTO Dependants VALUES ('Tremblay1F0', 'Gauthier', 'Alice', 'F', '1990-07-28', 'Tremblay1P', NULL);
INSERT INTO Dependants VALUES ('Tremblay1E1', 'Tremblay', 'Alexis', 'H', '2015-05-14', 'Tremblay1P', NULL);
INSERT INTO Dependants VALUES ('Tremblay1E2', 'Tremblay', 'Léa', 'F', '2017-03-19', 'Tremblay1P', NULL);
INSERT INTO Dependants VALUES ('Grandprix4F0', 'Poirier', 'Béatrice', 'F', '1986-09-09', 'Grandprix4P', NULL);
INSERT INTO Dependants VALUES ('Grandprix4E1', 'Grandprix', 'Jacob', 'H', '2006-04-25', 'Grandprix4P', NULL);
INSERT INTO Dependants VALUES ('Grandprix4E2', 'Grandprix', 'Olivia', 'F', '2008-06-29', 'Grandprix4P', NULL);
INSERT INTO Dependants VALUES ('Lajoie5H0', 'Beaulieu', 'Thomas', 'H', '1980-08-20', 'Lajoie5P', NULL);
INSERT INTO Dependants VALUES ('Lajoie5E1', 'Beaulieu', 'Léo', 'H', '2005-02-15', 'Lajoie5P', NULL);
INSERT INTO Dependants VALUES ('Lajoie5E2', 'Beaulieu', 'Raphaël', 'H', '2007-08-23', 'Lajoie5P', NULL);
INSERT INTO Dependants VALUES ('Lajoie5E3', 'Beaulieu', 'Zoé', 'F', '2009-06-16', 'Lajoie5P', NULL);
INSERT INTO Dependants VALUES ('Fredette6F0', 'Ménard', 'Charlotte', 'F', '1981-01-17', 'Fredette6P', NULL);
INSERT INTO Dependants VALUES ('Fredette6E1', 'Fredette', 'Nathan', 'H', '2004-12-25', 'Fredette6P', NULL);
INSERT INTO Dependants VALUES ('Gagnon7F0', 'Champagne', 'Florence', 'F', '1984-11-12', 'Gagnon7P', NULL);
INSERT INTO Dependants VALUES ('Gagnon7E1', 'Gagnon', 'Emma', 'F', '2002-09-14', 'Gagnon7P', NULL);

print 'Insertion des enregistrements dans la table PartiesJouees...'
INSERT INTO PartiesJouees VALUES ('Tremblay1P', 1, '2018-05-23', 50, NULL);
INSERT INTO PartiesJouees VALUES ('Maori2P', 2, '2017-07-22', 60, NULL);
INSERT INTO PartiesJouees VALUES ('Johnson3P', 3, '2017-08-12', 44, NULL);
INSERT INTO PartiesJouees VALUES ('Grandprix4P', 4, '2016-08-22', 88, NULL);
INSERT INTO PartiesJouees VALUES ('Lajoie5P', 6, '2018-06-01', 49, NULL);
INSERT INTO PartiesJouees VALUES ('Fredette6P', 5, '2018-09-24', 27, NULL);
INSERT INTO PartiesJouees VALUES ('Gagnon7P', 3, '2017-10-11', 38, NULL);
INSERT INTO PartiesJouees VALUES ('Jeffes8P', 4, '2016-07-07', 55, NULL);
INSERT INTO PartiesJouees VALUES ('Zhu9P', 1, '2017-07-17', 44, NULL);
INSERT INTO PartiesJouees VALUES ('Dion10P', 2, '2018-08-08', 75, NULL);
INSERT INTO PartiesJouees VALUES ('Grandprix4P', 5, '2016-09-30', 66, NULL);
INSERT INTO PartiesJouees VALUES ('Lajoie5P', 6, '2016-08-22', 90, NULL);
INSERT INTO PartiesJouees VALUES ('Fredette6P', 6, '2017-05-26', 90, NULL);
INSERT INTO PartiesJouees VALUES ('Gagnon7P', 3, '2018-06-30', 35, NULL);
INSERT INTO PartiesJouees VALUES ('Jeffes8P', 2, '2018-07-24', 58, NULL);
INSERT INTO PartiesJouees VALUES ('Zhu9P', 5, '2017-10-01', 88, NULL);
INSERT INTO PartiesJouees VALUES ('Dion10P', 4, '2016-06-27', 83, NULL);
INSERT INTO PartiesJouees VALUES ('Gagnon7P', 3, '2018-10-02', 62, NULL);
INSERT INTO PartiesJouees VALUES ('Jeffes8P', 4, '2017-04-11', 67, NULL);
INSERT INTO PartiesJouees VALUES ('Zhu9P', 1, '2016-07-28', 48, NULL);
INSERT INTO PartiesJouees VALUES ('Dion10P', 6, '2017-06-22', 97, NULL);

print 'Insertion des enregistrements dans la table Depenses...'
INSERT INTO Depenses VALUES (1, 'Tremblay1P', '2018-05-23', 345.99, 1, NULL);
INSERT INTO Depenses VALUES (2, 'Maori2P', '2017-07-22', 96.43, 1, NULL);
INSERT INTO Depenses VALUES (3, 'Johnson3P', '2017-08-12', 243.11, 3, NULL);
INSERT INTO Depenses VALUES (4, 'Grandprix4P', '2016-08-22', 120.33, 1, NULL);
INSERT INTO Depenses VALUES (5, 'Lajoie5P', '2018-06-01', 58.33, 2, NULL);
INSERT INTO Depenses VALUES (6, 'Fredette6P', '2018-09-24', 90.55, 3, NULL);
INSERT INTO Depenses VALUES (7, 'Gagnon7P', '2017-10-11', 21.45, 4, NULL);
INSERT INTO Depenses VALUES (8, 'Jeffes8P', '2016-07-07', 12.56, 5, NULL);
INSERT INTO Depenses VALUES (9, 'Zhu9P', '2017-07-17', 15.64, 6, NULL);
INSERT INTO Depenses VALUES (10, 'Maori2P', '2016-09-08', 350, 7, NULL);
INSERT INTO Depenses VALUES (11, 'Tremblay1P', '2018-07-07', 59.34, 1, NULL);
INSERT INTO Depenses VALUES (12, 'Maori2P', '2017-08-08', 258.22, 2, NULL);
INSERT INTO Depenses VALUES (13, 'Johnson3P', '2018-09-23', 402, 3, NULL);
INSERT INTO Depenses VALUES (14, 'Grandprix4P', '2016-09-30', 80, 1, NULL);
INSERT INTO Depenses VALUES (15, 'Lajoie5P', '2016-08-22', 46.98, 2, NULL);
INSERT INTO Depenses VALUES (16, 'Fredette6P', '2017-05-26', 69.54, 3, NULL);
INSERT INTO Depenses VALUES (17, 'Gagnon7P', '2018-06-30', 18.32, 4, NULL);
INSERT INTO Depenses VALUES (18, 'Jeffes8P', '2018-07-24', 23.54, 5, NULL);
INSERT INTO Depenses VALUES (19, 'Maori2P', '2017-10-01', 25.11, 6, NULL);
INSERT INTO Depenses VALUES (20, 'Zhu9P', '2016-08-30', 350, 7, NULL);