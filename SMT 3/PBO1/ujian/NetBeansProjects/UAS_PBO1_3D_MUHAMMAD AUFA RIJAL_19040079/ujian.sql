-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2021 at 02:35 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ujian`
--

-- --------------------------------------------------------

--
-- Table structure for table `client_management`
--

CREATE TABLE `client_management` (
  `id` int(3) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(200) NOT NULL,
  `brief` varchar(200) NOT NULL,
  `fee` int(20) NOT NULL,
  `deadline` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `client_management`
--

INSERT INTO `client_management` (`id`, `nama`, `alamat`, `brief`, `fee`, `deadline`) VALUES
(12220, 'Dimas', 'Balapulang', 'Buat Website Usaha', 1000000, '10 Januari 2021'),
(12345, 'Aufa', 'Tegal', 'Buat Website Perusahaan', 10000000, '17 Oktober 2020'),
(12366, 'Reszy', 'Tegal', 'Buat Website Dagang / Olshop', 9000000, '20 Oktober 2020');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client_management`
--
ALTER TABLE `client_management`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
