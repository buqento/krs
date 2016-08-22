-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2016 at 07:57 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `krs`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_krs`
--

CREATE TABLE `data_krs` (
  `kode_mata_kuliah` varchar(10) NOT NULL,
  `nim` varchar(9) NOT NULL,
  `nama_mata_kuliah` varchar(50) NOT NULL,
  `nama_mahasiswa` varchar(50) NOT NULL,
  `jurusan` varchar(35) NOT NULL,
  `semester` varchar(5) NOT NULL,
  `tahun_akademik` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `data_mahasiswa`
--

CREATE TABLE `data_mahasiswa` (
  `nim` varchar(9) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(1) NOT NULL,
  `tanggal` date NOT NULL,
  `agama` varchar(35) NOT NULL,
  `alamat` text NOT NULL,
  `jenjang_pendidikan` varchar(10) NOT NULL,
  `program_studi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_mahasiswa`
--

INSERT INTO `data_mahasiswa` (`nim`, `nama_lengkap`, `jenis_kelamin`, `tanggal`, `agama`, `alamat`, `jenjang_pendidikan`, `program_studi`) VALUES
('111111112', 'nn', 'P', '1980-08-21', 'Islam', 'Alamat Rumah', 'D4', 'Sistem Informasi'),
('333333333', 'Nama saya', 'L', '2016-08-21', 'Kristen Protestan', 'Alamat Rumah', 'SMU', 'Teknik Informatika'),
('444444444', 'Nama saya', 'L', '1990-10-25', 'Kristen Protestan', 'Alamat Rumah', 'S1', 'Teknik Informatika'),
('666666666', 'Nama saya', 'P', '2016-08-21', 'Kristen Protestan', 'Alamat Rumah', 'SMU', 'Teknik Informatika');

-- --------------------------------------------------------

--
-- Table structure for table `data_mata_kuliah`
--

CREATE TABLE `data_mata_kuliah` (
  `kode_mata_kuliah` varchar(10) NOT NULL,
  `dosen_pengajar` varchar(50) NOT NULL,
  `jenjang_pendidikan` varchar(10) NOT NULL,
  `program_studi` varchar(50) NOT NULL,
  `semester_ganjil_genap` varchar(5) NOT NULL,
  `nama_mata_kuliah` varchar(50) NOT NULL,
  `sks` int(11) NOT NULL,
  `tahun_ajaran` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `data_user`
--

CREATE TABLE `data_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_user`
--

INSERT INTO `data_user` (`id_user`, `username`, `password`) VALUES
(1, 'adm', 'password'),
(2, 'admin', 'sandi'),
(3, 'admin', 'password');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_krs`
--
ALTER TABLE `data_krs`
  ADD PRIMARY KEY (`kode_mata_kuliah`);

--
-- Indexes for table `data_mahasiswa`
--
ALTER TABLE `data_mahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- Indexes for table `data_mata_kuliah`
--
ALTER TABLE `data_mata_kuliah`
  ADD PRIMARY KEY (`kode_mata_kuliah`);

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data_user`
--
ALTER TABLE `data_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
