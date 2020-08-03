-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2019 at 05:06 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_rental`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_penyewa`
--

CREATE TABLE `tb_penyewa` (
  `id` int(5) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_tlp` varchar(20) NOT NULL,
  `tgl_mulai` date NOT NULL,
  `tgl_selesai` date NOT NULL,
  `total_hari` int(4) NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'PROSES',
  `code` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_penyewa`
--

INSERT INTO `tb_penyewa` (`id`, `nama`, `alamat`, `no_tlp`, `tgl_mulai`, `tgl_selesai`, `total_hari`, `status`, `code`) VALUES
(20, 'si cantik', 'pulo gadung', '08147483647', '2019-02-02', '2019-02-04', 2, 'PROSES', 1233),
(21, 'Adel', 'Depok Mania', '0821474836', '2019-01-09', '2019-01-11', 2, 'PROSES', 9042),
(22, 'yeye', 'yeye', '08657222223', '2019-01-03', '2019-01-06', 3, 'PROSES', 689),
(23, 'truuuu', 'depok', '0852136478', '2019-01-08', '2019-01-09', 1, 'PROSES', 3060),
(24, 'wewe', 'wewe', '0839088998', '2019-01-05', '2019-01-07', 2, 'PROSES', 1275),
(25, 'coba', 'cobi', '085352615577', '2019-01-01', '2019-01-05', 4, 'PROSES', 2267),
(26, 'Subhan Zaki', 'Bekasi', '089672543786', '2019-01-01', '2019-01-06', 4, 'PROSES', 3649),
(27, 'aaa', 'aaa', '0863672893', '2019-01-02', '2019-01-09', 7, 'Selesai', 3232),
(34, 'Arinatul', 'Jakarta', '083494839', '2019-02-01', '2019-02-02', 1, 'PROSES', 0),
(35, '', '', '', '0000-00-00', '0000-00-00', 0, 'PROSES', 1414),
(36, 'Arinatul', 'JAgakarsa', '02938938', '2019-01-04', '2019-01-06', 2, 'PROSES', 0),
(37, 'Nadia Ela', 'Tangerang', '02839726778', '2019-03-03', '2019-03-05', 2, 'PROSES', 0),
(38, 'Nelnol', 'Beji', '03938293883', '2019-04-01', '2019-04-02', 1, 'PROSES', 5398),
(39, 'Fawwaz', 'Jombang', '08276578997', '2019-01-08', '2019-01-10', 2, 'PROSES', 1003),
(40, 'Fariza', 'Jakarta Selatan', '085352615577', '2019-02-03', '2019-02-06', 3, 'Selesai', 3330);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_penyewa`
--
ALTER TABLE `tb_penyewa`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_penyewa`
--
ALTER TABLE `tb_penyewa`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
