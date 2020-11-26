-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 26, 2020 at 08:00 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kalbe`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE `tb_admin` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`username`, `password`) VALUES
('tes', 'tes'),
('coba', 'coba'),
('tes', 'tes'),
('coba', 'coba');

-- --------------------------------------------------------

--
-- Table structure for table `tb_document`
--

CREATE TABLE `tb_document` (
  `no_doc` int(20) NOT NULL,
  `main_proccess` varchar(20) NOT NULL,
  `core_proccess` varchar(20) NOT NULL,
  `proccess` varchar(20) NOT NULL,
  `lob` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_document`
--

INSERT INTO `tb_document` (`no_doc`, `main_proccess`, `core_proccess`, `proccess`, `lob`) VALUES
(1, '123', 'aaaaa', 'aaaaa', '34');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_document`
--
ALTER TABLE `tb_document`
  ADD PRIMARY KEY (`no_doc`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_document`
--
ALTER TABLE `tb_document`
  MODIFY `no_doc` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
