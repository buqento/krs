-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 26, 2016 at 07:49 AM
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
  `no_krs` varchar(50) NOT NULL,
  `no_induk_mahasiswa` varchar(9) NOT NULL,
  `kode_mata_kuliah` varchar(10) NOT NULL,
  `dosen_pengajar` varchar(50) NOT NULL,
  `tahun_akademik` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_krs`
--

INSERT INTO `data_krs` (`no_krs`, `no_induk_mahasiswa`, `kode_mata_kuliah`, `dosen_pengajar`, `tahun_akademik`) VALUES
('KRS-001', '150101001', '14111', 'Lukman Saleh,BSB.,M.Sc /Amran Suatkab,S.Kom/Asiste', '2015'),
('krs-009', '150101001', '10720', 'Lukman Saleh., BSB., M.Sc/David Leimena,S.Pd', '2015'),
('krs-009', '150101001', '14111', 'Lukman Saleh,BSB.,M.Sc /Amran Suatkab,S.Kom/Asiste', '2015'),
('krs-008', '150101002', '10330', 'Lukman Saleh.,BSB.,M.Sc/Subhan Ramdhani, S.Kom/Asi', '2015'),
('krs-003', '150101001', '11330', 'R. D Syaranamual,.S.Si.,M.Si', '2015');

-- --------------------------------------------------------

--
-- Table structure for table `data_mahasiswa`
--

CREATE TABLE `data_mahasiswa` (
  `nim` varchar(9) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(1) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `agama` varchar(35) NOT NULL,
  `alamat` text NOT NULL,
  `jenjang_pendidikan` varchar(10) NOT NULL,
  `program_studi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_mahasiswa`
--

INSERT INTO `data_mahasiswa` (`nim`, `nama_lengkap`, `jenis_kelamin`, `tempat_lahir`, `tanggal`, `agama`, `alamat`, `jenjang_pendidikan`, `program_studi`) VALUES
('150101001', 'Abdul Jaiz Djokdja', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101002', 'Abdul Jalil Duila', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101003', 'Abdul Malik Drakel', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101004', 'Abdur Rosyid Ridwan', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101005', 'Adi Aru Saputra', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101006', 'Adi Rahman Pelupessy', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101007', 'Afrila Syahriany Mahulauw', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101008', 'Ahmad Agung R. Pelupessy', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101009', 'Al Yusri Faldi', 'L', 'Ambon', '1990-08-23', 'Islam', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101010', 'Alberth Van Basten Wakim', 'L', 'Ambon', '1990-08-23', 'Kristen Protestan', 'Jl. Jalan', 'S1', 'Teknik Informatika'),
('150101012', 'Aldi Wahab Mukandar', 'L', 'Masohi', '1995-08-25', 'Islam', 'Galunggung', 'S1', 'Teknik Informatika');

-- --------------------------------------------------------

--
-- Table structure for table `data_mata_kuliah`
--

CREATE TABLE `data_mata_kuliah` (
  `kode_mk` varchar(10) NOT NULL,
  `nama_mata_kuliah` varchar(50) NOT NULL,
  `sks` int(11) NOT NULL,
  `semester` int(2) NOT NULL,
  `tahun_ajaran` int(11) NOT NULL,
  `jenjang_pendidikan` varchar(10) NOT NULL,
  `program_studi` varchar(50) NOT NULL,
  `dosen_pengajar` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_mata_kuliah`
--

INSERT INTO `data_mata_kuliah` (`kode_mk`, `nama_mata_kuliah`, `sks`, `semester`, `tahun_ajaran`, `jenjang_pendidikan`, `program_studi`, `dosen_pengajar`) VALUES
('10330', 'Pengantar Teknologi Informasi', 2, 1, 2016, 'S1', 'Teknik Informatika', 'Lukman Saleh.,BSB.,M.Sc/Subhan Ramdhani, S.Kom/Asi'),
('10521', 'Bahasa Inggris 1', 2, 1, 2016, 'S1', 'Teknik Informatika', 'Sepsi Caroline T.S.S.,M.Hum'),
('10631', 'Matematika Dasar', 3, 1, 2016, 'S1', 'Teknik Informatika', 'Mursaid Dahlan, S.Si, M.Pd'),
('10720', 'Bahasa Indonesia', 2, 1, 2016, 'S1', 'Teknik Informatika', 'Lukman Saleh., BSB., M.Sc/David Leimena,S.Pd'),
('11330', 'Organisasi & Arsitektur Komputer', 3, 1, 2016, 'S1', 'Teknik Informatika', 'R. D Syaranamual,.S.Si.,M.Si'),
('14036', 'Logika Informatika', 3, 1, 2016, 'S1', 'Teknik Informatika', 'Dr. Darmin David.,M.Si'),
('14111', 'Prak. Algoritma & Pemrograman (C++)', 1, 1, 2016, 'S1', 'Teknik Informatika', 'Lukman Saleh,BSB.,M.Sc /Amran Suatkab,S.Kom/Asiste');

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
-- Indexes for table `data_mahasiswa`
--
ALTER TABLE `data_mahasiswa`
  ADD PRIMARY KEY (`nim`);

--
-- Indexes for table `data_mata_kuliah`
--
ALTER TABLE `data_mata_kuliah`
  ADD PRIMARY KEY (`kode_mk`);

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
