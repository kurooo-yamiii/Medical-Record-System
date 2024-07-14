-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 21. Feb 2020 um 08:20
-- Server Version: 5.5.16
-- PHP-Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `medical`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `archive`
--

CREATE TABLE IF NOT EXISTS `archive` (
  `Name` text,
  `Age` int(11) DEFAULT NULL,
  `Sex` text,
  `CivilStatus` text,
  `Address` text,
  `GrYearSec` text,
  `RoomBuilding` text,
  `SchoolID` text,
  `Guardian` text,
  `GuardianNum` text,
  `ChiefComplaints` text NOT NULL,
  `PhoneNum` int(11) NOT NULL,
  `Religion` text NOT NULL,
  `Nationality` text NOT NULL,
  `BirthDate` text NOT NULL,
  `NameAdviser` text NOT NULL,
  `MotherName` text NOT NULL,
  `MotherNameNum` int(11) NOT NULL,
  `FatherName` text NOT NULL,
  `FatherNameNum` int(11) NOT NULL,
  `HealthHx` text NOT NULL,
  `MedsTaken` text NOT NULL,
  `Allergies` text NOT NULL,
  `Medicine` text NOT NULL,
  `Food` text NOT NULL,
  `BP` text NOT NULL,
  `RR` text NOT NULL,
  `PR` text NOT NULL,
  `Temperature` text NOT NULL,
  `O2Sat` text NOT NULL,
  `LMP` text NOT NULL,
  `Remarks` text NOT NULL,
  `BMI` text NOT NULL,
  `Ht` text NOT NULL,
  `Wt` text NOT NULL,
  `NameOfIncident` text NOT NULL,
  `PlaceOfIncident` text NOT NULL,
  `DateOfIncident` text NOT NULL,
  `DateOfDisabilityBegan` text NOT NULL,
  `PartOfBodyAffected` text NOT NULL,
  `TimeOfIncident` text NOT NULL,
  `TypeOfIncident` text NOT NULL,
  `DescriptionOfAccident` text NOT NULL,
  `Witness` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `employee`
--

CREATE TABLE IF NOT EXISTS `employee` (
  `Establishment` text,
  `NameOfBusiness` text,
  `AddressWork` text,
  `NumOfEmploymentMale` text,
  `NumOfEmploymentFemale` text,
  `TotalEmployee` text,
  `Manager` text,
  `Name` text,
  `Age` int(11) DEFAULT NULL,
  `Sex` text,
  `CivilStatus` text,
  `Address` text,
  `Position` text,
  `PhoneNum` int(11) DEFAULT NULL,
  `Religion` text,
  `Nationality` text,
  `ExperienceOfOccupation` text,
  `NumOfDependents` int(11) DEFAULT NULL,
  `BirthDate` text,
  `MonthlyWage` text,
  `WorkshiftAM` text,
  `WorkshiftPM` text,
  `HoursOfWorkDay` text,
  `Week` text,
  `EmergencyNum` int(11) DEFAULT NULL,
  `Relationship` text,
  `Phone` text,
  `Agency` text,
  `AgencyAddress` text,
  `ChiefComplaints` text,
  `HealthHx` text,
  `MedsTaken` text,
  `Allergies` text,
  `Medicine` text,
  `Food` text,
  `BP` text,
  `RR` text,
  `PR` text,
  `Temperature` text,
  `O2Sat` text,
  `Wt` text,
  `Ht` text,
  `BMI` text,
  `Remarks` text,
  `LMP` text,
  `NameOfIncident` text,
  `PlaceOfIncident` text,
  `DateOfIncident` text,
  `DisabilityDateBegan` text,
  `PartsOfBodyAffected` text,
  `TimeOfIncident` text,
  `TypeOfIncident` text,
  `PropertyDamage` text,
  `PersonalInjury` text,
  `DateOfReturnedToWork` text,
  `DayLost` text,
  `UnsafeAct` text,
  `UnsafeMechanics` text,
  `ContributingFactor` text,
  `ExtentOfDisability` text,
  `DamageOfProperty` text,
  `DescriptionOfAccident` text,
  `Witness` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `employee`
--

INSERT INTO `employee` (`Establishment`, `NameOfBusiness`, `AddressWork`, `NumOfEmploymentMale`, `NumOfEmploymentFemale`, `TotalEmployee`, `Manager`, `Name`, `Age`, `Sex`, `CivilStatus`, `Address`, `Position`, `PhoneNum`, `Religion`, `Nationality`, `ExperienceOfOccupation`, `NumOfDependents`, `BirthDate`, `MonthlyWage`, `WorkshiftAM`, `WorkshiftPM`, `HoursOfWorkDay`, `Week`, `EmergencyNum`, `Relationship`, `Phone`, `Agency`, `AgencyAddress`, `ChiefComplaints`, `HealthHx`, `MedsTaken`, `Allergies`, `Medicine`, `Food`, `BP`, `RR`, `PR`, `Temperature`, `O2Sat`, `Wt`, `Ht`, `BMI`, `Remarks`, `LMP`, `NameOfIncident`, `PlaceOfIncident`, `DateOfIncident`, `DisabilityDateBegan`, `PartsOfBodyAffected`, `TimeOfIncident`, `TypeOfIncident`, `PropertyDamage`, `PersonalInjury`, `DateOfReturnedToWork`, `DayLost`, `UnsafeAct`, `UnsafeMechanics`, `ContributingFactor`, `ExtentOfDisability`, `DamageOfProperty`, `DescriptionOfAccident`, `Witness`) VALUES
('kenneth', '17', 'b', 'bb', 'b', 'b', 'b', 'b', 0, 'b', 'b', 'b', 'b', 0, 'b', 'b', 'b', 0, 'b', 'b', 'b', 'b', 'b', 'b', 0, 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'bb', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'),
('BarberShop', 'Educational', 'C.LawisExtension', '12', '12', '24', 'Leomord', 'Kimmy', 22, 'Male', 'Taken', 'Alarcon', 'Teacher', 2147483647, 'Roman Catholic', 'Filipino', 'Smooth', 2, 'July 11, 2009', '15,000', '6-12', '12-6', '12hrs', '5 days a week', 2147483647, 'Future Wife', '09314543324', 'SCAS', 'C.LawisExtension', 'Nambabatok ng estudyante', 'Healthy', 'None', 'Asthma', 'Biogesic', 'Chicken', '12', '13', '14', '36', 'None', '15', '16', '124', 'Normal', '29', 'Kaltukan', 'SCAS', 'January 6, 2020', 'Since Birth', 'Brain', '12:00', 'Child Abuse', 'Arm Chair is broken', 'Knuckles', 'Junuary 12, 2020', '4', 'Emotional', 'Heavy Hands', 'Donation', 'Full extent', 'Done', 'Nangaltok biglaan', 'Estudyante nya sa English subject');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `employeearch`
--

CREATE TABLE IF NOT EXISTS `employeearch` (
  `Establishment` text,
  `NameOfBusiness` text,
  `AddressWork` text,
  `NumOfEmploymentMale` text,
  `NumOfEmploymentFemale` text,
  `TotalEmployee` text,
  `Manager` text,
  `Name` text,
  `Age` int(11) DEFAULT NULL,
  `Sex` text,
  `CivilStatis` text,
  `Address` text,
  `Position` text,
  `PhoneNum` int(11) DEFAULT NULL,
  `Religion` text,
  `Nationality` text,
  `ExperienceOfOccupation` text,
  `NumOfDependents` int(11) DEFAULT NULL,
  `BirthDate` text,
  `MonthlyWage` text,
  `WorkshiftAM` text,
  `WorkshiftPM` text,
  `HoursOfWorkDay` text,
  `Week` text,
  `EmergencyNum` int(11) DEFAULT NULL,
  `Relationship` text,
  `Phone` text,
  `Agency` text,
  `AgencyAddress` text,
  `ChiefComplaints` text,
  `HealthHx` text,
  `MedsTaken` text,
  `Allergies` text,
  `Medicine` text,
  `Food` text,
  `BP` text,
  `RR` text,
  `PR` text,
  `Temperature` text,
  `O2Sat` text,
  `Wt` text,
  `Ht` text,
  `BMI` text,
  `Remarks` text,
  `LMP` text,
  `NameOfIncident` text,
  `PlaceOfIncident` text,
  `DateOfIncident` text,
  `DisabilityDateBegan` text,
  `PartsOfBodyAffected` text,
  `TimeOfIncident` text,
  `TypeOfIncident` text,
  `PropertyDamage` text,
  `PersonalInjury` text,
  `DateOfReturnedToWork` text,
  `DayLost` text,
  `UnsafeAct` text,
  `UnsafeMechanics` text,
  `ContributingFactor` text,
  `ExtentOfDisability` text,
  `DamageOfProperty` text,
  `DescriptionOfAccident` text,
  `Witness` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `enrollment`
--

CREATE TABLE IF NOT EXISTS `enrollment` (
  `Name` text,
  `CourseStrand` text,
  `YearGrade` text,
  `Religion` text,
  `Address` text,
  `DateOfBirth` text,
  `Age` int(11) DEFAULT NULL,
  `PhoneNum` int(11) DEFAULT NULL,
  `Father` text,
  `FatherNum` int(11) DEFAULT NULL,
  `Mother` text,
  `MotherNum` int(11) DEFAULT NULL,
  `Guardian` text,
  `GuardianNum` int(11) DEFAULT NULL,
  `ChickenPox` text,
  `Measles` text,
  `Mumps` text,
  `Poliomyelitis` text,
  `Diphteria` text,
  `TyphoidFever` text,
  `DengueFever` text,
  `KidneyInfection` text,
  `Malaria` text,
  `Asthma` text,
  `Pheumonia` text,
  `Tubercolosis` text,
  `Anemia` text,
  `Hemophilia` text,
  `HeartDisease` text,
  `Epilepsy` text,
  `Diabetes` text,
  `Hypertension` text,
  `Allergies` text,
  `AnyOther` text,
  `Hospitalized` text,
  `Hearing` text,
  `Vision` text,
  `Q1` text,
  `Q2` text,
  `Q3` text,
  `Q4` text,
  `Q5` text,
  `Q6` text,
  `Q7` text,
  `Q8` text,
  `Q9` text,
  `Q10` text,
  `Q11` text,
  `Q12` text,
  `Q13` text,
  `BP` text,
  `BodyMarks` text,
  `Vision2` text,
  `Height` text,
  `Weight` text,
  `BMI` text,
  `DentalHealth` text,
  `LMP` text,
  `BP2` text,
  `DPTOPV1` text,
  `DPTOPV2` text,
  `DPTOPV3` text,
  `Hepatitis` text,
  `Measles2` text,
  `Other` text,
  `CommentRecommendation` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `enrollment`
--

INSERT INTO `enrollment` (`Name`, `CourseStrand`, `YearGrade`, `Religion`, `Address`, `DateOfBirth`, `Age`, `PhoneNum`, `Father`, `FatherNum`, `Mother`, `MotherNum`, `Guardian`, `GuardianNum`, `ChickenPox`, `Measles`, `Mumps`, `Poliomyelitis`, `Diphteria`, `TyphoidFever`, `DengueFever`, `KidneyInfection`, `Malaria`, `Asthma`, `Pheumonia`, `Tubercolosis`, `Anemia`, `Hemophilia`, `HeartDisease`, `Epilepsy`, `Diabetes`, `Hypertension`, `Allergies`, `AnyOther`, `Hospitalized`, `Hearing`, `Vision`, `Q1`, `Q2`, `Q3`, `Q4`, `Q5`, `Q6`, `Q7`, `Q8`, `Q9`, `Q10`, `Q11`, `Q12`, `Q13`, `BP`, `BodyMarks`, `Vision2`, `Height`, `Weight`, `BMI`, `DentalHealth`, `LMP`, `BP2`, `DPTOPV1`, `DPTOPV2`, `DPTOPV3`, `Hepatitis`, `Measles2`, `Other`, `CommentRecommendation`) VALUES
('Kenthjhun', 'ICT', 'Grade 11', 'Catholic', 'Villa Guido', 'May 8 2002', 17, 93451567, 'Walter', 956137567, 'Alma', 1238748579, 'Walter', 957135766, 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Positive', 'Negative', 'Negative', 'Negative', 'N/A', 'No', 'No', '', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Several Days (2)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'Not at all (1)', 'N/A', 'N/A', 'N/A', '150', '50', '1.45', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 'Bumisita ka sa doctor pa check up');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `enrollmentarch`
--

CREATE TABLE IF NOT EXISTS `enrollmentarch` (
  `Name` text,
  `CourseStrand` text,
  `YearGrade` text,
  `Religion` text,
  `Address` text,
  `DateOfBirth` text,
  `Age` int(11) DEFAULT NULL,
  `PhoneNum` int(11) DEFAULT NULL,
  `Father` text,
  `FatherNum` int(11) DEFAULT NULL,
  `Mother` text,
  `MotherNum` int(11) DEFAULT NULL,
  `Guardian` text,
  `GuardianNum` int(11) DEFAULT NULL,
  `ChickenPox` text,
  `Measles` text,
  `Mumps` text,
  `Poliomyelitis` text,
  `Diphteria` text,
  `TyphoidFever` text,
  `DengueFever` text,
  `KidneyInfection` text,
  `Malaria` text,
  `Asthma` text,
  `Pheumonia` text,
  `Tubercolosis` text,
  `Anemia` text,
  `Hemophilia` text,
  `HeartDisease` text,
  `Epilepsy` text,
  `Diabetes` text,
  `Hypertension` text,
  `Allergies` text,
  `AnyOther` text,
  `Hospitalized` text,
  `Hearing` text,
  `Vision` text,
  `Q1` text,
  `Q2` text,
  `Q3` text,
  `Q4` text,
  `Q5` text,
  `Q6` text,
  `Q7` text,
  `Q8` text,
  `Q9` text,
  `Q10` text,
  `Q11` text,
  `Q12` text,
  `Q13` text,
  `BP` text,
  `BodyMarks` text,
  `Vision2` text,
  `Height` text,
  `Weight` text,
  `BMI` text,
  `DentalHealth` text,
  `LMP` text,
  `BP2` text,
  `DPTOPV1` text,
  `DPTOPV2` text,
  `DPTOPV3` text,
  `Hepatitis` text,
  `Measles2` text,
  `Other` text,
  `CommentRecommendation` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `enrollmentarch`
--

INSERT INTO `enrollmentarch` (`Name`, `CourseStrand`, `YearGrade`, `Religion`, `Address`, `DateOfBirth`, `Age`, `PhoneNum`, `Father`, `FatherNum`, `Mother`, `MotherNum`, `Guardian`, `GuardianNum`, `ChickenPox`, `Measles`, `Mumps`, `Poliomyelitis`, `Diphteria`, `TyphoidFever`, `DengueFever`, `KidneyInfection`, `Malaria`, `Asthma`, `Pheumonia`, `Tubercolosis`, `Anemia`, `Hemophilia`, `HeartDisease`, `Epilepsy`, `Diabetes`, `Hypertension`, `Allergies`, `AnyOther`, `Hospitalized`, `Hearing`, `Vision`, `Q1`, `Q2`, `Q3`, `Q4`, `Q5`, `Q6`, `Q7`, `Q8`, `Q9`, `Q10`, `Q11`, `Q12`, `Q13`, `BP`, `BodyMarks`, `Vision2`, `Height`, `Weight`, `BMI`, `DentalHealth`, `LMP`, `BP2`, `DPTOPV1`, `DPTOPV2`, `DPTOPV3`, `Hepatitis`, `Measles2`, `Other`, `CommentRecommendation`) VALUES
('Kenneth', 'ICT-2A', 'G12', 'Catholic', 'Alarcon', 'February 12, 2002', 17, 941234124, 'Denis', 943847477, 'Marilyn', 943014134, 'Mother', 941412341, 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'None', 'No', 'No', '', 'Nearly even days (4)', 'Several Days (2)', 'Several Days (2)', 'More than half the days (3)', 'More than half the days (3)', 'Not at all (1)', 'Several Days (2)', 'Several Days (2)', 'More than half the days (3)', 'More than half the days (3)', 'More than half the days (3)', 'More than half the days (3)', 'More than half the days (3)', 'g', 'g', 'g', 'g', 'g', 'gg', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g'),
('gg', 'gg', 'gg', 'gg', 'gg', 'gg', 0, 0, 'g', 0, 'g', 0, 'g', 0, 'Positive', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'Negative', 'g', 'g', 'g', '', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `history`
--

CREATE TABLE IF NOT EXISTS `history` (
  `Keynum` int(11) DEFAULT NULL,
  `OldPassword` text,
  `NewPassword` text,
  `Date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `history`
--

INSERT INTO `history` (`Keynum`, `OldPassword`, `NewPassword`, `Date`) VALUES
(1, 'kenneth', 'kenneth', 'Jan 17, 2020 09:04:06 AM'),
(1, 'iloveyou', 'iloveyou', 'Jan 17, 2020 09:04:36 AM');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `marchive`
--

CREATE TABLE IF NOT EXISTS `marchive` (
  `Keynum` int(11) DEFAULT NULL,
  `Medicine` text,
  `Quantity` int(11) DEFAULT NULL,
  `Datee` text,
  `Transactionn` text,
  `MedicineUse` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mrecord`
--

CREATE TABLE IF NOT EXISTS `mrecord` (
  `Keynum` int(11) DEFAULT NULL,
  `Medicine` text,
  `Quantity` int(11) DEFAULT NULL,
  `Datee` text,
  `Transactionn` text,
  `MedicineUse` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `mrecord`
--

INSERT INTO `mrecord` (`Keynum`, `Medicine`, `Quantity`, `Datee`, `Transactionn`, `MedicineUse`) VALUES
(3, 'Biogesic', 84, '11/12/19', 'None', 'Pain Killer'),
(2, 'Medicol ', 26, '11/12/19', 'Nahilo', 'Flu'),
(4, 'Celine', 90, '12/12/12', 'None', 'Vitamins');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `passwordd`
--

CREATE TABLE IF NOT EXISTS `passwordd` (
  `Keynum` int(11) DEFAULT NULL,
  `OldPassword` text,
  `NewPassword` text,
  `Date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `passwordd`
--

INSERT INTO `passwordd` (`Keynum`, `OldPassword`, `NewPassword`, `Date`) VALUES
(1, 'admin', 'admin', 'Jan 17, 2020 09:04:36 AM');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `record`
--

CREATE TABLE IF NOT EXISTS `record` (
  `Name` text,
  `Age` int(11) DEFAULT NULL,
  `Sex` text,
  `CivilStatus` text,
  `Address` text,
  `GrYearSec` text,
  `RoomBuilding` text,
  `SchoolID` text,
  `Guardian` text,
  `GuardianNum` text,
  `ChiefComplaints` text NOT NULL,
  `PhoneNum` int(11) NOT NULL,
  `Religion` text NOT NULL,
  `Nationality` text NOT NULL,
  `BirthDate` text NOT NULL,
  `NameAdviser` text NOT NULL,
  `MotherName` text NOT NULL,
  `MotherNameNum` int(11) NOT NULL,
  `FatherName` text NOT NULL,
  `FatherNameNum` int(11) NOT NULL,
  `HealthHx` text NOT NULL,
  `MedsTaken` text NOT NULL,
  `Allergies` text NOT NULL,
  `Medicine` text NOT NULL,
  `Food` text NOT NULL,
  `BP` text NOT NULL,
  `RR` text NOT NULL,
  `PR` text NOT NULL,
  `Temperature` text NOT NULL,
  `O2Sat` text NOT NULL,
  `LMP` text NOT NULL,
  `Remarks` text NOT NULL,
  `BMI` text NOT NULL,
  `Ht` text NOT NULL,
  `Wt` text NOT NULL,
  `NameOfIncident` text NOT NULL,
  `PlaceOfIncident` text NOT NULL,
  `DateOfIncident` text NOT NULL,
  `DateOfDisabilityBegan` text NOT NULL,
  `PartOfBodyAffected` text NOT NULL,
  `TimeOfIncident` text NOT NULL,
  `TypeOfIncident` text NOT NULL,
  `DescriptionOfAccident` text NOT NULL,
  `Witness` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `record`
--

INSERT INTO `record` (`Name`, `Age`, `Sex`, `CivilStatus`, `Address`, `GrYearSec`, `RoomBuilding`, `SchoolID`, `Guardian`, `GuardianNum`, `ChiefComplaints`, `PhoneNum`, `Religion`, `Nationality`, `BirthDate`, `NameAdviser`, `MotherName`, `MotherNameNum`, `FatherName`, `FatherNameNum`, `HealthHx`, `MedsTaken`, `Allergies`, `Medicine`, `Food`, `BP`, `RR`, `PR`, `Temperature`, `O2Sat`, `LMP`, `Remarks`, `BMI`, `Ht`, `Wt`, `NameOfIncident`, `PlaceOfIncident`, `DateOfIncident`, `DateOfDisabilityBegan`, `PartOfBodyAffected`, `TimeOfIncident`, `TypeOfIncident`, `DescriptionOfAccident`, `Witness`) VALUES
('Kimmy', 10, 'Male', 'Akisha', 'Alarcon', 'Grade 3', 'Room/Building', '1237812378', '2018-4123', 'Budang', 'Nasira', 94627467, 'Catholic', 'Japanese', '12/12/12', 'MaryAnne', 'Arlene', 2147483647, 'Glen', 2147483647, 'Dunno', 'NotToday', 'Asthma', 'Biogesuc', 'Chuckie', '123', '123', '213', '1233123', '3123', '123', 'Tulog Lang', '3123', '3123', '3123', 'Nauntog', 'School', '12/12/12', 'Nabubu', 'Brain', '1212', 'Concussion', 'Bubu nadulas', 'si kenneth'),
('gg', 0, 'g', 'g', 'gg', 'gg', 'g', 'g', 'g', '0', 'gg', 0, 'gg', 'g', '', 'g', 'g', 0, 'g', 0, 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g'),
('Kenthjhun', 17, 'Male', 'Single', 'Villa Guido', 'Grade 11', 'Prudence', '2018-1234', 'Walter', '957135766', 'N/A', 93451567, 'Catholic', 'Filipino', '', 'Sir Valderoso', 'Alma', 1238748579, 'Walter', 956137567, 'N/A', 'N/A', 'Asthma', 'Biogesic', 'Bread', 'N/A', 'M/A', 'N/A', '40', 'N/A', 'N/A', 'Sick', '1.45', '150', '50', 'Head Shot', 'School', '12/12/12', '12/12/12', 'Head', '12:50', 'Bloody', 'Headshot sa ulo', 'Classmates'),
('Kenthjhun', 17, 'g', 'g', 'Villa Guido', 'Grade 11', 'g', 'g', 'Walter', '957135766', 'g', 93451567, 'Catholic', 'g', 'May 8 2002', 'gg', 'Alma', 1238748579, 'Walter', 956137567, 'g', 'g', 'g', 'gg', 'g', 'N/A', 'g', 'g', 'g', 'g', 'N/A', 'g', '1.45', '150', '50', 'gg', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g'),
('Kenthjhun', 17, 'g', 'g', 'Villa Guido', 'Grade 11', 'g', 'g', 'Walter', '957135766', 'gg', 93451567, 'Catholic', 'g', 'May 8 2002', 'gg', 'Alma', 1238748579, 'Walter', 956137567, 'g', 'g', 'g', 'g', 'g', 'N/A', 'g', 'g', 'g', 'g', 'N/A', 'g', '1.45', '150', '50', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g', 'g');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `teacher`
--

CREATE TABLE IF NOT EXISTS `teacher` (
  `SchoolID` text NOT NULL,
  `Name` text,
  `Department` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `teacher`
--

INSERT INTO `teacher` (`SchoolID`, `Name`, `Department`) VALUES
('20180-3124', 'Take', 'ICT'),
('20180-3453', 'Genisis', 'ICT');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `teacher2`
--

CREATE TABLE IF NOT EXISTS `teacher2` (
  `SchoolID` text,
  `Name` text,
  `Datee` text,
  `Remarks` text,
  `Num` int(11) DEFAULT NULL,
  `Medicine` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `teacher2`
--

INSERT INTO `teacher2` (`SchoolID`, `Name`, `Datee`, `Remarks`, `Num`, `Medicine`) VALUES
('20180-3124', 'Take', 'Feb 21, 2020 03:16:38 PM', 'Tae', 2, 'Biogesic');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `transactionn`
--

CREATE TABLE IF NOT EXISTS `transactionn` (
  `SchoolID` text NOT NULL,
  `Name` text,
  `GrYearSec` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `transactionn`
--

INSERT INTO `transactionn` (`SchoolID`, `Name`, `GrYearSec`) VALUES
('', 'Kenthjhun', 'ICT 2A'),
('', 'Nicky', 'ICT 2A');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `transactionn2`
--

CREATE TABLE IF NOT EXISTS `transactionn2` (
  `SchoolID` text,
  `Name` text,
  `Datee` text,
  `Remarks` text,
  `Num` int(11) NOT NULL,
  `Medicine` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `transactionn2`
--

INSERT INTO `transactionn2` (`SchoolID`, `Name`, `Datee`, `Remarks`, `Num`, `Medicine`) VALUES
('2018', 'Kenthjhun', 'Feb 21, 2020 02:20:32 PM', 'Hakdog', 1, 'Medicol');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
