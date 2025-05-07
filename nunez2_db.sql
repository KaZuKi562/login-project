-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2025 at 12:41 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nunez2_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE `student_info` (
  `ID` int(11) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `student no.` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`ID`, `firstname`, `student no.`, `username`, `password`, `role`) VALUES
(1, 'John Paulo', '05-8953', '05-8953', 'nunez', 'admin'),
(2, 'Harold', '05-001', '05-001', 'harold', 'student');

-- --------------------------------------------------------

--
-- Table structure for table `userinfotbl`
--

CREATE TABLE `userinfotbl` (
  `ID` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `middlename` varchar(255) NOT NULL,
  `studentNo` varchar(255) NOT NULL,
  `birthday` date NOT NULL,
  `course` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userinfotbl`
--

INSERT INTO `userinfotbl` (`ID`, `name`, `firstname`, `lastname`, `middlename`, `studentNo`, `birthday`, `course`, `section`, `username`, `password`, `role`) VALUES
(1, 'Nunez John Paulo', 'John Paulo', 'Nunez', 'D.J', '05-8953', '2003-09-29', 'Associate in Computer Technology', 'ACT-1F', '05-8953', 'Nunez', 'Admin'),
(6, 'Charmaine Ramos', 'Charmaine', 'Ramos', 'R', '05-0001', '2006-08-16', 'Associate in Computer Technology', 'ACT1-A', '05-0001', 'cha', 'Student'),
(7, 'Justin Manganti', 'Justin', 'Manganti', 'M', '05-0002', '2025-05-07', 'Associate in Computer Technology', 'ACT1-F', '05-0002', 'justin', 'Student'),
(8, 'Maryjoy Caber', 'Maryjoy', 'Caber', 'F', '05-0003', '2025-05-07', 'Hospitality Management', 'HM1-A', '05-0003', 'joy', 'Student');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `userinfotbl`
--
ALTER TABLE `userinfotbl`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `student_info`
--
ALTER TABLE `student_info`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `userinfotbl`
--
ALTER TABLE `userinfotbl`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
