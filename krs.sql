-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 23, 2016 at 09:32 AM
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
  `nim` varchar(9) NOT NULL,
  `kode_mata_kuliah` varchar(10) NOT NULL,
  `nama_matakuliah` varchar(50) NOT NULL,
  `sks` int(11) NOT NULL,
  `semester` int(1) NOT NULL,
  `dosen_pengampu` varchar(50) NOT NULL,
  `tahun_akademik` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_krs`
--

INSERT INTO `data_krs` (`no_krs`, `nim`, `kode_mata_kuliah`, `nama_matakuliah`, `sks`, `semester`, `dosen_pengampu`, `tahun_akademik`) VALUES
('KRS-201509070001', '222222222', 'mk-001', 'Matematika Diskrit', 4, 1, 'Buqento, S.Kom.', 2015),
('KRS-201509070001', '222222222', 'mk-002', 'Elektronika Dasar', 3, 1, 'King Richard, MT.', 2015),
('KRS-201509070001', '666666666', 'mk-002', 'Elektronika Dasar', 3, 1, 'King Richard, MT.', 2015),
('KRS-201509070001', '666666666', 'mk-003', 'Arsitektur Komputer', 4, 1, 'Franseska, M.Kom.', 2015),
('KRS-201509070001', '777777777', 'mk-003', 'Arsitektur Komputer', 4, 1, 'Franseska, M.Kom.', 2015),
('KRS-201509070001', '666666666', 'mk-001', 'Matematika Diskrit', 4, 1, 'Buqento, S.Kom.', 2015),
('KRS-201509070001', '111111111', 'mk-001', 'Matematika Diskrit', 4, 1, 'Buqento, S.Kom.', 2015);

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
('111111111', 'King Richard', 'L', 'Masohi', '2016-08-23', 'Kristen Protestan', 'Alamat Rumah', 'S1', 'Teknik Informatika'),
('222222222', 'Theresia', 'L', '', '2016-08-23', 'Kristen Protestan', 'Alamat Rumah', 'S1', 'Sistem Informasi'),
('333333333', 'Nama saya', 'L', '', '2016-08-21', 'Kristen Protestan', 'Alamat Rumah', 'SMU', 'Teknik Informatika'),
('444444444', 'Nama saya', 'L', '', '1990-10-25', 'Kristen Protestan', 'Alamat Rumah', 'S1', 'Teknik Informatika'),
('666666666', 'Nama saya', 'P', '', '2016-08-21', 'Kristen Protestan', 'Alamat Rumah', 'SMU', 'Teknik Informatika'),
('777777777', 'Britney', 'P', '', '1990-08-21', 'Katolik', 'Alamat Kantor', 'S2', 'Sistem Informasi');

-- --------------------------------------------------------

--
-- Table structure for table `data_mata_kuliah`
--

CREATE TABLE `data_mata_kuliah` (
  `kode_mata_kuliah` varchar(10) NOT NULL,
  `nama_mata_kuliah` varchar(50) NOT NULL,
  `sks` int(11) NOT NULL,
  `semester` int(2) NOT NULL,
  `tahun_ajaran` int(11) NOT NULL,
  `jenjang_pendidikan` varchar(10) NOT NULL,
  `program_studi` varchar(50) NOT NULL,
  `dosen_pengampu` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_mata_kuliah`
--

INSERT INTO `data_mata_kuliah` (`kode_mata_kuliah`, `nama_mata_kuliah`, `sks`, `semester`, `tahun_ajaran`, `jenjang_pendidikan`, `program_studi`, `dosen_pengampu`) VALUES
('mk-001', 'Matematika Diskrit', 4, 1, 2017, 'S1', 'Teknik Informatika', 'Buqento, S.Kom.'),
('mk-002', 'Elektronika Dasar', 3, 1, 2016, 'S1', 'Teknik Informatika', 'King Richard, MT.'),
('mk-003', 'Arsitektur Komputer', 4, 1, 2016, 'S1', 'Teknik Informatika', 'Franseska, M.Kom.');

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
