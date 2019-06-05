-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 05 juin 2019 à 23:39
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gsb_medic`
--

-- --------------------------------------------------------

--
-- Structure de la table `activites`
--

DROP TABLE IF EXISTS `activites`;
CREATE TABLE IF NOT EXISTS `activites` (
  `idActivite` varchar(10) NOT NULL,
  `bilan` text NOT NULL,
  PRIMARY KEY (`idActivite`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `activitescomp`
--

DROP TABLE IF EXISTS `activitescomp`;
CREATE TABLE IF NOT EXISTS `activitescomp` (
  `numOrdre` varchar(10) NOT NULL,
  `etat` varchar(25) NOT NULL,
  `budgetActivitesComp` double NOT NULL,
  `commentaires` text NOT NULL,
  `salle` varchar(20) NOT NULL,
  `date` varchar(10) NOT NULL,
  `idActivite` varchar(10) NOT NULL,
  `idResponsable` varchar(10) NOT NULL,
  KEY `idActivite` (`idActivite`),
  KEY `idResponsable` (`idResponsable`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `activitescomp`
--

INSERT INTO `activitescomp` (`numOrdre`, `etat`, `budgetActivitesComp`, `commentaires`, `salle`, `date`, `idActivite`, `idResponsable`) VALUES
('fezfez', 'gsfzg', 445, 'hbthe', 'greheh', 'hehrehe', 'fezfz', 'erhhe'),
('fefgg', 'gfdgdgd', 555, 'ghehhe', 'hhehr', 'hrhrh', 'zazaza', 'hrthr'),
('val123', 'en cours', 125, 'blablabla', '001', '18/12/2018', 'activite1', 'bla');

-- --------------------------------------------------------

--
-- Structure de la table `avoir`
--

DROP TABLE IF EXISTS `avoir`;
CREATE TABLE IF NOT EXISTS `avoir` (
  `idEffetA` varchar(10) NOT NULL,
  `idMedicamentA` varchar(10) NOT NULL,
  KEY `idEffet` (`idEffetA`),
  KEY `idMedicament` (`idMedicamentA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `avoir`
--

INSERT INTO `avoir` (`idEffetA`, `idMedicamentA`) VALUES
('1', '1'),
('2', '2'),
('3', '3');

-- --------------------------------------------------------

--
-- Structure de la table `composants`
--

DROP TABLE IF EXISTS `composants`;
CREATE TABLE IF NOT EXISTS `composants` (
  `idComposant` varchar(10) NOT NULL,
  `libelleComposant` varchar(100) NOT NULL,
  PRIMARY KEY (`idComposant`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `composer`
--

DROP TABLE IF EXISTS `composer`;
CREATE TABLE IF NOT EXISTS `composer` (
  `idMedicament` varchar(10) NOT NULL,
  `idComposant` varchar(10) NOT NULL,
  `quantite` double NOT NULL,
  KEY `idMedicament` (`idMedicament`),
  KEY `idComposant` (`idComposant`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `contreindications`
--

DROP TABLE IF EXISTS `contreindications`;
CREATE TABLE IF NOT EXISTS `contreindications` (
  `idContreIndication` varchar(10) NOT NULL,
  `libelleContreIndication` varchar(100) NOT NULL,
  `descriptionContreIndication` text NOT NULL,
  PRIMARY KEY (`idContreIndication`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `contreindications`
--

INSERT INTO `contreindications` (`idContreIndication`, `libelleContreIndication`, `descriptionContreIndication`) VALUES
('1', 'Paracétamol', 'Ce médicament est un antalgique et un antipyrétique qui contient du paracétamol.\r\n\r\nIl est utilisé pour faire baisser la fièvre et dans le traitement des affections douloureuses.'),
('2', 'Ibuprofène', 'Ce médicament est un anti-inflammatoire non stéroïdien (AINS). Il lutte contre la douleur et fait baisser la fièvre. Ses propriétés anti-inflammatoires se manifestent à forte dose.\r\n\r\nIl est utilisé dans le traitement de courte durée de la fièvre et de la douleur (maux de tête, douleurs dentaires, états grippaux, courbatures, règles douloureuses...).'),
('3', 'Phloroglucinol', 'Ce médicament est un antispasmodique. Il lutte contre les contractions anormales et douloureuses de l\'intestin, des voies biliaires, des voies urinaires et de l\'utérus.\r\n\r\nIl est utilisé dans le traitement des spasmes douloureux d\'origines digestive (colites spasmodiques), biliaire (coliques hépatiques), urologique (coliques néphrétiques) et gynécologique (règles douloureuses et contractions de l\'utérus pendant la grossesse).'),
('4', 'Diclofénac', 'Ce médicament est un anti-inflammatoire non stéroïdien (AINS). Il lutte contre l\'inflammation et la douleur, fait baisser la fièvre et fluidifie le sang.\r\n\r\nIl est utilisé chez l\'adulte dans :\r\nle traitement symptomatique des rhumatismes inflammatoires chroniques (notamment de la polyarthrite rhumatoïde et de la spondylarthrite ankylosante) et de certaines arthroses invalidantes ;\r\nle traitement de courte durée des douleurs aiguës d\'arthrose, des arthrites (dont la goutte), des tendinites, des bursites, des lombalgies, des sciatiques et des cruralgies ;\r\nles règles douloureuses.\r\nIl est utilisé chez l\'enfant de plus de 6 ans dans le traitement des rhumatismes inflammatoires.');

-- --------------------------------------------------------

--
-- Structure de la table `demande`
--

DROP TABLE IF EXISTS `demande`;
CREATE TABLE IF NOT EXISTS `demande` (
  `Id` int(11) NOT NULL,
  `MatConserne` int(11) NOT NULL,
  `Objet` varchar(50) NOT NULL,
  `Date` date NOT NULL,
  `NivUrg` int(20) NOT NULL,
  `Etat` varchar(50) DEFAULT NULL,
  `Technicien` varchar(11) DEFAULT '""',
  `Travail` varchar(50) NOT NULL DEFAULT '""',
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `demande`
--

INSERT INTO `demande` (`Id`, `MatConserne`, `Objet`, `Date`, `NivUrg`, `Etat`, `Technicien`, `Travail`) VALUES
(1, 69, 'panne', '2019-05-03', 5, 'Travail terminé', '2', 'fait'),
(2, 70, 'casse', '2019-05-28', 3, 'Travail terminé', '1', 'non reparable');

-- --------------------------------------------------------

--
-- Structure de la table `effets`
--

DROP TABLE IF EXISTS `effets`;
CREATE TABLE IF NOT EXISTS `effets` (
  `idEffet` varchar(10) NOT NULL,
  `libelleEffet` varchar(100) NOT NULL,
  `descriptionEffet` text NOT NULL,
  PRIMARY KEY (`idEffet`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `effets`
--

INSERT INTO `effets` (`idEffet`, `libelleEffet`, `descriptionEffet`) VALUES
('1', 'Antalgique', 'Irritation anale (suppositoire).\r\n\r\nExceptionnellement : réaction allergique cutanée, anomalie de la numération formule sanguine.'),
('2', 'Anti-inflammatoires', 'Nausées, vomissements, gastrite.\r\n\r\nRarement :\r\nulcère de l\'estomac ou du duodénum, hémorragie du tube digestif (vomissements sanglants, selles noires, ou le plus souvent pertes de sang imperceptibles, responsables de l\'apparition progressive d\'une anémie) le plus souvent lors d\'un traitement de longue durée ou à forte dose ;\r\nréaction allergique : éruption cutanée, démangeaisons, œdème, crise d\'asthme, malaise avec chute brutale de la tension artérielle ;\r\nvertiges, maux de tête ;\r\ntroubles de la vision nécessitant un examen ophtalmologique ;\r\nanomalie de la numération formule sanguine, augmentation des transaminases.'),
('3', 'Antispasmodique', 'Irritation anale (suppositoires).\r\n\r\nExceptionnellement : réaction allergique cutanée, anomalie de la numération formule sanguine.\r\n\r\nSachets :\r\n\r\nComme tous les médicaments et confiseries contenant des sucres non absorbables (sorbitol, maltitol...), possibilité de diarrhée en cas d\'apport important.'),
('4', 'Dermatologie', 'Peu fréquents (moins de 1 patient sur 100) : irritation, douleur, rougeur au site d\'application ; urticaire, eczéma, démangeaisons.\r\n\r\nFréquence indéterminée : sensation de brûlure.');

-- --------------------------------------------------------

--
-- Structure de la table `effettherapeutique`
--

DROP TABLE IF EXISTS `effettherapeutique`;
CREATE TABLE IF NOT EXISTS `effettherapeutique` (
  `idEffetT` varchar(10) NOT NULL,
  `libelleEffetT` varchar(25) NOT NULL,
  `descriptionEffetT` text NOT NULL,
  PRIMARY KEY (`idEffetT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `effettherapeutique`
--

INSERT INTO `effettherapeutique` (`idEffetT`, `libelleEffetT`, `descriptionEffetT`) VALUES
('1', 'Antalgique', 'Il est utilisé pour faire baisser la fièvre et dans le traitement des affections douloureuses.'),
('2', 'Anti-inflammatoires', 'Il est utilisé dans :\r\nle traitement de la fièvre et de la douleur (maux de tête, douleurs dentaires, courbatures, règles douloureuses...) ;\r\nle traitement de la crise de migraine chez l\'adulte, après au moins un avis médical.'),
('3', 'Antispasmodique', 'Il est utilisé pour faire baisser la fièvre et dans le traitement des affections douloureuses.\r\n'),
('4', 'Dermatologie', 'Elle est utilisée dans le traitement d\'appoint de la sécheresse de la peau (notamment en cas de dermatite atopique, d\'ichtyose ou de psoriasis) et des brûlures superficielles peu étendues.'),
('5', 'Anti-acides', 'Il est utilisé dans le traitement des symptômes du reflux gastro-œsophagien (brûlures d\'estomac, remontées acides).');

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

DROP TABLE IF EXISTS `famille`;
CREATE TABLE IF NOT EXISTS `famille` (
  `idFamille` varchar(10) NOT NULL,
  `libelleFamille` varchar(50) NOT NULL,
  PRIMARY KEY (`idFamille`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `famille`
--

INSERT INTO `famille` (`idFamille`, `libelleFamille`) VALUES
('1', 'Paracétamol'),
('2', 'Ibuprofène'),
('3', 'Phloroglucinol'),
('4', 'Diclofénac');

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `idM` int(11) NOT NULL,
  `processeur` varchar(20) NOT NULL,
  `disque` varchar(20) NOT NULL,
  `memoire` varchar(20) NOT NULL,
  `dateAchat` date NOT NULL,
  `garantie` varchar(10) NOT NULL,
  `prix` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`idM`, `processeur`, `disque`, `memoire`, `dateAchat`, `garantie`, `prix`) VALUES
(1, 'i9', 'SSD', '1T', '2019-03-11', 'OUI', 1500),
(2, 'i7', 'HDD', '2T', '2019-03-11', 'NON', 2000);

-- --------------------------------------------------------

--
-- Structure de la table `medicaments`
--

DROP TABLE IF EXISTS `medicaments`;
CREATE TABLE IF NOT EXISTS `medicaments` (
  `idMedicament` varchar(10) NOT NULL,
  `libelleMedicament` varchar(100) NOT NULL,
  `idFamilleM` varchar(10) NOT NULL,
  PRIMARY KEY (`idMedicament`),
  KEY `idFamille` (`idFamilleM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `medicaments`
--

INSERT INTO `medicaments` (`idMedicament`, `libelleMedicament`, `idFamilleM`) VALUES
('1', 'Doliprane', '1'),
('2', 'Advil', '2'),
('3', 'Spasfon', '3'),
('4', 'Voltarene', '4');

--
-- Déclencheurs `medicaments`
--
DROP TRIGGER IF EXISTS `MajusculeNomMedic`;
DELIMITER $$
CREATE TRIGGER `MajusculeNomMedic` BEFORE INSERT ON `medicaments` FOR EACH ROW BEGIN 
SET new.libelleMedicament = UPPER(new.libelleMedicament);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

DROP TABLE IF EXISTS `posseder`;
CREATE TABLE IF NOT EXISTS `posseder` (
  `idMedicamentP` int(11) NOT NULL,
  `idContreIndicationP` int(11) NOT NULL,
  PRIMARY KEY (`idMedicamentP`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `posseder`
--

INSERT INTO `posseder` (`idMedicamentP`, `idContreIndicationP`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4);

-- --------------------------------------------------------

--
-- Structure de la table `pratiquer`
--

DROP TABLE IF EXISTS `pratiquer`;
CREATE TABLE IF NOT EXISTS `pratiquer` (
  `idActivite` varchar(10) NOT NULL,
  `idPraticien` varchar(10) NOT NULL,
  KEY `idActivite` (`idActivite`),
  KEY `idPraticien` (`idPraticien`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `pratiquer`
--

INSERT INTO `pratiquer` (`idActivite`, `idPraticien`) VALUES
('bla', 'blabla'),
('bla', 'blabla'),
('activite1', 'blabla');

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `Nom` float NOT NULL,
  `Id` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `salarie`
--

DROP TABLE IF EXISTS `salarie`;
CREATE TABLE IF NOT EXISTS `salarie` (
  `Matricule` varchar(11) NOT NULL,
  `Nom` varchar(11) NOT NULL,
  `Prenom` varchar(11) NOT NULL,
  `DateEmbauche` varchar(11) NOT NULL,
  PRIMARY KEY (`Matricule`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `salarie`
--

INSERT INTO `salarie` (`Matricule`, `Nom`, `Prenom`, `DateEmbauche`) VALUES
('2', 'CAZALE', 'Thomas', '1998'),
('1', 'MOLIA', 'Axel', '1999'),
('3', 'CAUSSE', 'Arthur', '1999');

--
-- Déclencheurs `salarie`
--
DROP TRIGGER IF EXISTS `MajusculeNom`;
DELIMITER $$
CREATE TRIGGER `MajusculeNom` BEFORE INSERT ON `salarie` FOR EACH ROW BEGIN 
SET new.Nom = UPPER(new.Nom);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `technicien`
--

DROP TABLE IF EXISTS `technicien`;
CREATE TABLE IF NOT EXISTS `technicien` (
  `MatriculeT` int(11) NOT NULL,
  `Nom` varchar(25) NOT NULL,
  `Prenom` varchar(20) NOT NULL,
  `NivInterv` int(11) NOT NULL,
  `Formation` varchar(11) NOT NULL,
  `Competence` varchar(11) NOT NULL,
  PRIMARY KEY (`MatriculeT`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `technicien`
--

INSERT INTO `technicien` (`MatriculeT`, `Nom`, `Prenom`, `NivInterv`, `Formation`, `Competence`) VALUES
(1, 'CAUSSE', 'Arthur', 1, 'BAC', 'info'),
(2, 'MOLIA', 'Axel', 1, 'BAC', 'info');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `Identifiant` varchar(25) NOT NULL,
  `MotDePasse` varchar(25) NOT NULL,
  `TypeU` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`Identifiant`, `MotDePasse`, `TypeU`) VALUES
('Axel', 'axel', 'responsable'),
('Thomas', 'thomas', 'salarie'),
('Arthur', 'arthur', 'technicien');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `avoir`
--
ALTER TABLE `avoir`
  ADD CONSTRAINT `avoir_ibfk_1` FOREIGN KEY (`idEffetA`) REFERENCES `effettherapeutique` (`idEffetT`),
  ADD CONSTRAINT `avoir_ibfk_2` FOREIGN KEY (`idMedicamentA`) REFERENCES `medicaments` (`idMedicament`);

--
-- Contraintes pour la table `composer`
--
ALTER TABLE `composer`
  ADD CONSTRAINT `composer_ibfk_1` FOREIGN KEY (`idComposant`) REFERENCES `composants` (`idComposant`),
  ADD CONSTRAINT `composer_ibfk_2` FOREIGN KEY (`idMedicament`) REFERENCES `medicaments` (`idMedicament`);

--
-- Contraintes pour la table `medicaments`
--
ALTER TABLE `medicaments`
  ADD CONSTRAINT `medicaments_ibfk_1` FOREIGN KEY (`idFamilleM`) REFERENCES `famille` (`idFamille`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
