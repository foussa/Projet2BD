use BD5B6TP2_BrodeurKouma;

print 'Cr�ation de la base de donn�es de gestion de clubs de golf'
print 'Derni�re modification, 8 novembre 2018.'
print ''
print 'Destruction des tables...'
DROP TABLE PartiesJouees;
DROP TABLE Terrains;
DROP TABLE Depenses;
DROP TABLE Reabonnements;
DROP TABLE Dependants;
DROP TABLE Abonnements;
DROP TABLE PrixDepensesAbonnements;
DROP TABLE TypesAbonnement;
DROP TABLE Services;
DROP TABLE Employes;
DROP TABLE TypesEmploye;
DROP TABLE Provinces;

print 'Cr�ation des tables ========================================================'
print ''
print  'Cr�ation de la table Provinces...' 
CREATE TABLE Provinces (
	Id varchar(2) PRIMARY KEY,
	Nom varchar(50) NOT NULL,
	Remarque varchar(500)
	);

print 'Cr�ation de la table TypesEmploye...'
CREATE TABLE TypesEmploye (
	No int PRIMARY KEY,
	Description varchar(100) NOT NULL,
	Remarque varchar(500)
	);

print 'Cr�ation de la table Employes...'
CREATE TABLE Employes (
	No int PRIMARY KEY,
	MotDePasse varchar(50) NOT NULL,
	Nom varchar(50) NOT NULL,
	Prenom varchar(50) NOT NULL,
	Sexe varchar(1) NOT NULL,
	Age int NOT NULL,
	NoCivique int NOT NULL,
	Rue varchar(50) NOT NULL,
	Ville varchar(50) NOT NULL,
	IdProvince varchar(2) NOT NULL FOREIGN KEY REFERENCES Provinces(Id),
	CodePostal varchar(6) NOT NULL,
	Telephone varchar(10) NOT NULL,
	Cellulaire varchar(10),
	Courriel varchar(100) NOT NULL,
	SalaireHoraire money NOT NULL,
	NoTypeEmploye int NOT NULL FOREIGN KEY REFERENCES TypesEmploye(No),
	Remarque varchar(500)
	);

print 'Cr�ation de la table Services...'
CREATE TABLE Services (
	No int PRIMARY KEY,
	TypeService varchar(100) NOT NULL,
	NoEmploye int NOT NULL FOREIGN KEY REFERENCES Employes(No),
	Remarque varchar(500)
	);

print 'Cr�ation de la table TypesAbonnement...'
CREATE TABLE TypesAbonnement (
	No int PRIMARY KEY,
	Description varchar(100) NOT NULL,
	Remarque varchar(500)
	);

print 'Cr�ation de la table PrixDepensesAbonnements...'
CREATE TABLE PrixDepensesAbonnements (
	NoTypeAbonnement int FOREIGN KEY REFERENCES TypesAbonnement(No),
	Annee int,
	Prix money NOT NULL,
	DepensesObligatoires money NOT NULL,
	Remarque varchar(500),
	PRIMARY KEY (NoTypeAbonnement, Annee)
	);

print 'Cr�ation de la table Abonnements...'
CREATE TABLE Abonnements (
	Id varchar(50) PRIMARY KEY,
	DateAbonnement date NOT NULL,
	Nom varchar(50) NOT NULL,
	Prenom varchar(50) NOT NULL,
	Sexe varchar(1) NOT NULL,
	DateNaissance date NOT NULL,
	NoCivique int NOT NULL,
	Rue varchar(50) NOT NULL,
	Ville varchar(50) NOT NULL,
	IdProvince varchar(2) NOT NULL FOREIGN KEY REFERENCES Provinces(Id),
	CodePostal varchar(6) NOT NULL,
	Telephone varchar(10) NOT NULL,
	Cellulaire varchar(10),
	Courriel varchar(100) NOT NULL,
	NoTypeAbonnement int  NOT NULL FOREIGN KEY REFERENCES TypesAbonnement(No),
	Remarque varchar(500)
	);

print 'Cr�ation de la table Dependants...'
CREATE TABLE Dependants (
	Id varchar(50) PRIMARY KEY,
	Nom varchar(50) NOT NULL,
	Prenom varchar(50) NOT NULL,
	Sexe varchar(1) NOT NULL,
	DateNaissance date NOT NULL,
	IdAbonnement varchar(50) NOT NULL FOREIGN KEY REFERENCES Abonnements(Id),
	Remarque varchar(500)
	);

print 'Cr�ation de la table Reabonnements...'
CREATE TABLE Reabonnements (
	IdAbonnement varchar(50) FOREIGN KEY REFERENCES Abonnements(Id),
	DateRenouvellement date,
	Remarque varchar(500),
	PRIMARY KEY (IdAbonnement, DateRenouvellement)
	);

print 'Cr�ation de la table Depenses...'
CREATE TABLE Depenses (
	No int PRIMARY KEY,
	IdAbonnement varchar(50) NOT NULL FOREIGN KEY REFERENCES Abonnements(Id),
	DateDepense date NOT NULL,
	Montant money NOT NULL,
	NoService int NOT NULL FOREIGN KEY REFERENCES Services(No),
	Remarque varchar(500)
	);

print 'Cr�ation de la table Terrains...'
CREATE TABLE Terrains (
	No int PRIMARY KEY,
	Nom varchar(50) NOT NULL,
	NombreTrous int NOT NULL,
	Description varchar(200) NOT NULL,
	Remarque varchar(500)
	);

print 'Cr�ation de la table PartiesJouees...'
CREATE TABLE PartiesJouees (
	IdAbonnement varchar(50) FOREIGN KEY REFERENCES Abonnements(Id),
	NoTerrain int FOREIGN KEY REFERENCES Terrains(No),
	DatePartie date,
	Pointage int NOT NULL,
	Remarque varchar(500),
	PRIMARY KEY (IdAbonnement, NoTerrain, DatePartie)
	);

print  'Insertion des donn�es ============================================='
print ''
print 'Insertion des enregistrements dans la table Provinces...'
INSERT INTO Provinces VALUES ('AB', 'Alberta', NULL);
INSERT INTO Provinces VALUES ('BC', 'Colombie-Britannique', NULL);
INSERT INTO Provinces VALUES ('MB', 'Manitoba', NULL);
INSERT INTO Provinces VALUES ('NL', 'Terre-Neuve et Labrador', NULL);
INSERT INTO Provinces VALUES ('NT', 'Territoires du Nord-Ouest', NULL);
INSERT INTO Provinces VALUES ('NS', 'Nouvelle-�cosse', NULL);
INSERT INTO Provinces VALUES ('NU', 'Nunavut', NULL);
INSERT INTO Provinces VALUES ('ON', 'Ontario', NULL);
INSERT INTO Provinces VALUES ('PE', '�le-du-Prince-�douard', NULL);
INSERT INTO Provinces VALUES ('QC', 'Qu�bec', NULL);
INSERT INTO Provinces VALUES ('SK', 'Saskatchewan', NULL);
INSERT INTO Provinces VALUES ('YT', 'Territoire du Yukon', NULL);

print 'Insertion des enregistrements dans la table TypesEmploye...'
INSERT INTO TypesEmploye VALUES (1, 'Administrateur', 'Il n�y en a qu�un et son num�ro est 1');
INSERT INTO TypesEmploye VALUES (2, 'Direction', NULL);
INSERT INTO TypesEmploye VALUES (3, 'Propri�taire d�un club', NULL);
INSERT INTO TypesEmploye VALUES (4, 'Employ� d�un club', NULL);
INSERT INTO TypesEmploye VALUES (5, 'Employ� Pro-Shop', NULL);
INSERT INTO TypesEmploye VALUES (6, 'Employ� d�un restaurant', NULL);
INSERT INTO TypesEmploye VALUES (7, 'Professeur de golf', NULL);

print 'Insertion des enregistrements dans la table TypesAbonnement...'
INSERT INTO TypesAbonnement VALUES (1, 'Personne seule', NULL);
INSERT INTO TypesAbonnement VALUES (2, '�ge d�or', NULL);
INSERT INTO TypesAbonnement VALUES (3, 'Couple', NULL);
INSERT INTO TypesAbonnement VALUES (4, 'Famille (couple + 1 enfant)', NULL);
INSERT INTO TypesAbonnement VALUES (5, 'Famille (couple + 2 enfants)', NULL);
INSERT INTO TypesAbonnement VALUES (6, 'Famille (couple + 3 enfants ou plus)', NULL);

print 'Insertion des enregistrements dans la table Terrains...'
INSERT INTO Terrains VALUES (1, 'Club de golf St-Rapha�l', 9, 'Situ� au coeur de la charmante �le Bizard, � quelques minutes seulement de la ville, le Golf Saint-Rapha�l vous fera vivre une exp�rience unique du d�but � la fin.', NULL);
INSERT INTO Terrains VALUES (2, 'Club de golf Le Cardinal', 9, 'Le Club de Golf Le Cardinal... le secret le mieux gard� � Laval.', NULL);
INSERT INTO Terrains VALUES (3, 'Golf Dorval', 18, 'Situ� � 20 minutes du centre-ville de Montr�al, Golf Dorval est un parcours public et a toutes les installations n�cessaires pour accueillir les golfeurs et golfeuses, ainsi que les tournois.', NULL);
INSERT INTO Terrains VALUES (4, 'Club de golf Royal Montr�al', 18, 'Fond� en 1873, le Royal Montr�al est le plus ancien club de golf en Am�rique du Nord.', NULL);
INSERT INTO Terrains VALUES (5, 'Golf UFO', 18, 'Situ� � quelques minutes du centre-ville de Montr�al, il est l''un des Clubs de golf publics des plus accessibles de la r�gion.', NULL);
INSERT INTO Terrains VALUES (6, 'Club de golf Rosemere', 9, 'Sur le chemin de son centenaire, le Club de golf de Rosem�re se donne un nouvel �lan et entend continuer sur sa lanc�e en mati�re d�innovations et d�investissements afin de demeurer un chef de file.', NULL);