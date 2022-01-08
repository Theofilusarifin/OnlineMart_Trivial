-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2022 at 06:02 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `online_mart`
--

-- --------------------------------------------------------

--
-- Table structure for table `barangs`
--

CREATE TABLE `barangs` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `harga` varchar(45) DEFAULT NULL,
  `deskripsi` text DEFAULT NULL,
  `path_gambar` varchar(100) DEFAULT NULL,
  `kategori_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `barangs`
--

INSERT INTO `barangs` (`id`, `nama`, `harga`, `deskripsi`, `path_gambar`, `kategori_id`) VALUES
(1, 'Nasi Goreng Pedas', '7500', 'a', 'a', 2),
(2, 'masako', '2500', 'a', 'a', 5),
(4, 'Ayam Goreng', '16000', 'a', 'a', 2),
(6, 'Chikin Taro', '5000', 'a', 'aa', 2),
(7, 'Walls', '7000', 'a', 'a', 12),
(8, 'Indomie', '3500', 'a', 'a', 2),
(9, 'Steak', '25000', 'a', 'a', 2),
(10, 'Boba', '10000', 'a', 'a', 3),
(11, 'Vas', '15000', 'a', 'a', 5),
(12, 'Laptop', '3000000', 'a', 'a', 7),
(13, 'Kabel', '60000', 'a', 'a', 7),
(14, 'Your Name', '10000', 'a', 'a', 6),
(15, 'Your Lie In April', '10000', 'a', 'a', 8),
(16, 'My Hero Academia', '10000', 'a', 'a', 8),
(17, 'Weathering With You', '10000', 'a', 'a', 6);

-- --------------------------------------------------------

--
-- Table structure for table `barang_cabang`
--

CREATE TABLE `barang_cabang` (
  `cabang_id` int(10) UNSIGNED NOT NULL,
  `barang_id` int(10) UNSIGNED NOT NULL,
  `stok` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `barang_cabang`
--

INSERT INTO `barang_cabang` (`cabang_id`, `barang_id`, `stok`) VALUES
(1, 2, 9996),
(1, 11, 9998),
(7, 1, 9999),
(7, 4, 9999),
(7, 6, 8000),
(7, 8, 9999),
(7, 9, 9999),
(7, 10, 9999),
(8, 12, 9999),
(8, 13, 9999),
(8, 14, 9999),
(8, 15, 9999),
(8, 16, 9999),
(8, 17, 9999),
(13, 9, 500),
(14, 7, 9000);

-- --------------------------------------------------------

--
-- Table structure for table `barang_order`
--

CREATE TABLE `barang_order` (
  `jumlah` int(11) DEFAULT NULL,
  `harga` float DEFAULT NULL,
  `order_id` bigint(19) UNSIGNED NOT NULL,
  `barang_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `barang_order`
--

INSERT INTO `barang_order` (`jumlah`, `harga`, `order_id`, `barang_id`) VALUES
(1, 7500, 202111250001, 1),
(1, 7500, 202111280001, 1),
(1, 2500, 202111280001, 2),
(2, 5000, 202111280002, 2),
(1, 5000, 202111280002, 6),
(2, 5000, 202111280003, 2),
(6, 15000, 202111280004, 2),
(5, 12500, 202111280005, 2),
(1, 2500, 202111280006, 2),
(3, 7500, 202112010001, 2),
(1, 15000, 202112010001, 11);

-- --------------------------------------------------------

--
-- Table structure for table `barang_penjual`
--

CREATE TABLE `barang_penjual` (
  `penjual_id` int(10) UNSIGNED NOT NULL,
  `barang_id` int(10) UNSIGNED NOT NULL,
  `stok` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `blacklists`
--

CREATE TABLE `blacklists` (
  `id` int(10) UNSIGNED NOT NULL,
  `jenis` varchar(45) NOT NULL,
  `alasan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `cabangs`
--

CREATE TABLE `cabangs` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `alamat` varchar(45) DEFAULT NULL,
  `pegawai_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cabangs`
--

INSERT INTO `cabangs` (`id`, `nama`, `alamat`, `pegawai_id`) VALUES
(1, 'UpNormal', 'Raya Timur no 6', 1),
(7, 'Rungkut', 'Jln medokan asri raya III no 21 B, Surabaya', 5),
(8, 'Tenggilis', 'tengilis jaya\r\n', 5),
(13, 'Gubeng', 'guben intan timur XXX', 1),
(14, 'Rungkut', 'Rungkut Asri Tirta Agug', 6),
(16, 'default', 'default', 1);

-- --------------------------------------------------------

--
-- Table structure for table `chats`
--

CREATE TABLE `chats` (
  `id` int(11) NOT NULL,
  `isi` text DEFAULT NULL,
  `waktu` datetime DEFAULT NULL,
  `role_pengirim` enum('driver','konsumen','penjual') DEFAULT NULL,
  `role_tujuan` enum('driver','konsumen','penjual') DEFAULT NULL,
  `order_id` bigint(19) UNSIGNED NOT NULL,
  `driver_id` int(10) UNSIGNED DEFAULT NULL,
  `pelanggan_id` int(10) UNSIGNED NOT NULL,
  `penjual_id` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chats`
--

INSERT INTO `chats` (`id`, `isi`, `waktu`, `role_pengirim`, `role_tujuan`, `order_id`, `driver_id`, `pelanggan_id`, `penjual_id`) VALUES
(5, 'a', '2021-11-23 05:45:23', 'konsumen', 'driver', 202112010008, 2, 4, NULL),
(6, 'aaa', '2021-11-23 05:45:26', 'driver', 'konsumen', 202111280005, 2, 1, NULL),
(7, 'yo', '2021-11-23 05:47:47', 'konsumen', 'driver', 202111280004, 2, 4, NULL),
(8, 'aa', '2021-11-23 17:47:37', 'konsumen', 'driver', 202111280004, 2, 4, NULL),
(9, 'yesy', '2021-11-23 17:47:42', 'konsumen', 'driver', 202111280004, 2, 4, NULL),
(10, 'test', '2021-11-27 00:26:05', 'konsumen', 'driver', 202111280004, 2, 4, NULL),
(11, 'woke', '2021-11-27 00:28:59', 'driver', 'konsumen', 202111280004, 2, 4, NULL),
(12, 'siap', '2021-11-27 00:29:04', 'driver', 'konsumen', 202111280004, 2, 4, NULL),
(13, 'Test', '2021-11-27 00:29:29', 'konsumen', 'driver', 202111280004, 2, 4, NULL),
(14, 'Halo', '2021-11-28 16:55:37', 'konsumen', 'driver', 202111280004, 2, 4, NULL),
(15, 'Halo  Juga', '2021-11-28 16:55:58', 'driver', 'konsumen', 202111280004, 2, 4, NULL),
(16, 'Yoi men', '2021-11-28 16:56:32', 'konsumen', 'driver', 202111280004, 2, 4, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `drivers`
--

CREATE TABLE `drivers` (
  `id` int(10) UNSIGNED NOT NULL,
  `username` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `telepon` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `drivers`
--

INSERT INTO `drivers` (`id`, `username`, `nama`, `email`, `password`, `telepon`) VALUES
(1, 'driver', 'driver', 'driver@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '901832108'),
(2, 'arifin', 'arifin', 'arifin@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '2013013'),
(3, 'brian', 'brian', 'brian@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '9013902183'),
(4, 'henri', 'henri', 'henri@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '90183018'),
(5, 'ivan', 'ivan', 'ivan@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1234567'),
(6, 'yaska', 'yaska', 'brian@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1982301830'),
(14, 'pass', 'arifin', 'pass', '5b722b307fce6c944905d132691d5e4a2214b7fe92b738920eb3fce3a90420a19511c3010a0e7712b054daef5b57bad59ecbd93b3280f210578f547f4aed4d25', 'pass');

-- --------------------------------------------------------

--
-- Table structure for table `gifts`
--

CREATE TABLE `gifts` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `jumlah_poin` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gifts`
--

INSERT INTO `gifts` (`id`, `nama`, `jumlah_poin`) VALUES
(1, 'Mainan', 1000),
(2, 'Boneka', 1000),
(3, 'Piring Cantik', 5000),
(4, 'Nintendo Switch', 1000000),
(5, 'Laptop ROG RTX 3060', 9999990);

-- --------------------------------------------------------

--
-- Table structure for table `gift_redeems`
--

CREATE TABLE `gift_redeems` (
  `id` int(10) UNSIGNED NOT NULL,
  `waktu` datetime DEFAULT NULL,
  `poin_redeem` int(11) DEFAULT NULL,
  `gift_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gift_redeems`
--

INSERT INTO `gift_redeems` (`id`, `waktu`, `poin_redeem`, `gift_id`) VALUES
(1, '2021-11-15 11:24:51', 1000, 1),
(3, '2021-11-28 23:23:18', 1000, 2),
(4, '2021-11-28 23:47:08', 1000, 2),
(5, '2021-11-28 23:52:03', 1000, 2),
(6, '2021-12-01 22:34:48', 1000, 2);

-- --------------------------------------------------------

--
-- Table structure for table `kategoris`
--

CREATE TABLE `kategoris` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kategoris`
--

INSERT INTO `kategoris` (`id`, `nama`) VALUES
(2, 'Makanan Pedas Banget'),
(3, 'Minuman'),
(5, 'Rapuh'),
(6, 'Movie'),
(7, 'Alat Elektronik'),
(8, 'Film'),
(12, 'Es Krim');

-- --------------------------------------------------------

--
-- Table structure for table `metode_pembayarans`
--

CREATE TABLE `metode_pembayarans` (
  `id` int(10) UNSIGNED NOT NULL,
  `nama` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `metode_pembayarans`
--

INSERT INTO `metode_pembayarans` (`id`, `nama`) VALUES
(1, 'Ovo'),
(2, 'Gopay'),
(4, 'Shopee Pay');

-- --------------------------------------------------------

--
-- Table structure for table `notifikasis`
--

CREATE TABLE `notifikasis` (
  `id` int(10) UNSIGNED NOT NULL,
  `isi` text NOT NULL,
  `tipe` varchar(45) NOT NULL,
  `waktu` datetime NOT NULL,
  `pelanggan_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` bigint(19) UNSIGNED NOT NULL,
  `tanggal_waktu` datetime DEFAULT NULL,
  `alamat_tujuan` varchar(45) DEFAULT NULL,
  `ongkos_kirim` float DEFAULT NULL,
  `total_bayar` float DEFAULT NULL,
  `cara_bayar` varchar(45) DEFAULT NULL,
  `status` enum('Menunggu Pembayaran','Pesanan Diproses','Order Selesai') DEFAULT NULL,
  `cabang_id` int(10) UNSIGNED DEFAULT 0,
  `pelanggan_id` int(10) UNSIGNED NOT NULL,
  `driver_id` int(10) UNSIGNED NOT NULL,
  `metode_pembayaran_id` int(10) UNSIGNED NOT NULL,
  `promo_id` int(10) UNSIGNED DEFAULT NULL,
  `gift_redeem_id` int(10) UNSIGNED NOT NULL,
  `penjual_id` int(10) UNSIGNED DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `tanggal_waktu`, `alamat_tujuan`, `ongkos_kirim`, `total_bayar`, `cara_bayar`, `status`, `cabang_id`, `pelanggan_id`, `driver_id`, `metode_pembayaran_id`, `promo_id`, `gift_redeem_id`, `penjual_id`) VALUES
(202111250001, '2021-11-25 18:26:14', 'Medokan Asri', 10000, 7500, 'Transfer', 'Order Selesai', 1, 4, 1, 1, 1, 1, 0),
(202111280001, '2021-11-28 16:54:25', 'Rungkut Kalibata', 10000, 10000, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 1, 1, 1, 0),
(202111280002, '2021-11-28 23:19:40', 'Jln Tenggilis Jaya Utara Selatan', 10000, 10000, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 4, 5, 1, 0),
(202111280003, '2021-11-28 23:20:41', 'Ngangel', 10000, 5000, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 1, 3, 1, 0),
(202111280004, '2021-11-28 23:45:28', 'Jln Mawar 13', 10000, 15000, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 1, 1, 1, 0),
(202111280005, '2021-11-28 23:45:39', 'Jln Melati 13', 10000, 12500, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 1, 1, 1, 0),
(202111280006, '2021-11-28 23:51:40', 'Jln Anggrek 13', 10000, 2500, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 2, 2, 1, 0),
(202112010001, '2021-12-01 22:16:45', '', 10000, 22500, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 1, 1, 1, 0),
(202112010002, '2021-12-01 22:34:23', '', 10000, 165000, 'Transfer', 'Pesanan Diproses', 1, 4, 1, 1, 1, 1, 0),
(202112010008, '2021-12-01 22:34:23', 'Jln Anggrek 13', 10000, 165000, 'Transfer', 'Pesanan Diproses', 1, 1, 1, 1, 1, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `pegawais`
--

CREATE TABLE `pegawais` (
  `id` int(10) UNSIGNED NOT NULL,
  `username` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `telepon` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pegawais`
--

INSERT INTO `pegawais` (`id`, `username`, `nama`, `email`, `password`, `telepon`) VALUES
(1, 'admin', 'admin', 'admin@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '0819321231'),
(2, 'arifin', 'arifin', 'arifin@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '0811234567'),
(3, 'henri', 'henri', 'henri@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '0123456763'),
(4, 'ivan', 'ivan', 'ivan@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '123456789'),
(5, 'yaska', 'yaska', 'yaska@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '09876543'),
(6, 'brian', 'brian', 'brian@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '129321983');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggans`
--

CREATE TABLE `pelanggans` (
  `id` int(10) UNSIGNED NOT NULL,
  `username` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `telepon` varchar(45) DEFAULT NULL,
  `saldo` float DEFAULT 0,
  `poin` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pelanggans`
--

INSERT INTO `pelanggans` (`id`, `username`, `nama`, `email`, `password`, `telepon`, `saldo`, `poin`) VALUES
(1, 'konsumen', 'konsumen', 'konsumen@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '01283013810', 0, 0),
(2, 'yaska', 'yaska', 'yaska@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1083103810', 936000, 81500),
(3, 'henri', 'henri', 'henri@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '9021832108301', 0, 0),
(4, 'arifin', 'arifin', 'arifin@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1932218310', 9947500, 10000),
(5, 'ivan', 'ivan', 'ivan@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1932218', 1000000000, 0),
(6, 'brian', 'brian', 'brian@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '08128392173', 0, 0),
(8, 'maya', 'Maya', 'maya@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '08121902910', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `pemasukkan`
--

CREATE TABLE `pemasukkan` (
  `id` int(11) NOT NULL,
  `tanggal` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `penilaians`
--

CREATE TABLE `penilaians` (
  `id` int(11) NOT NULL,
  `rating` double DEFAULT NULL,
  `review` text DEFAULT NULL,
  `barang_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `penjuals`
--

CREATE TABLE `penjuals` (
  `id` int(10) UNSIGNED NOT NULL,
  `username` varchar(45) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `status` varchar(45) DEFAULT NULL,
  `telepon` varchar(45) DEFAULT NULL,
  `blacklist_id` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `penjuals`
--

INSERT INTO `penjuals` (`id`, `username`, `nama`, `email`, `password`, `status`, `telepon`, `blacklist_id`) VALUES
(0, 'arifin', 'arifin', 'arifin', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'OK', '901839218301', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `promos`
--

CREATE TABLE `promos` (
  `id` int(10) UNSIGNED NOT NULL,
  `tipe` varchar(45) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `diskon` int(11) DEFAULT NULL,
  `diskon_max` int(11) DEFAULT NULL,
  `minimal_belanja` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `promos`
--

INSERT INTO `promos` (`id`, `tipe`, `nama`, `diskon`, `diskon_max`, `minimal_belanja`) VALUES
(1, 'Harian', 'Daily Deals', 5, 10000, 20000),
(2, 'Akhir tahun', 'New Year Eve', 30, 50000, 30000),
(3, 'Akhir bulan', 'Tanggal Tua', 20, 25000, 40000),
(4, 'Random', 'Flash Sale', 80, 10000, 100000),
(5, 'Lebaran', 'Berkah Ramadhan', 40, 40000, 60000);

-- --------------------------------------------------------

--
-- Table structure for table `riwayat_isi_saldos`
--

CREATE TABLE `riwayat_isi_saldos` (
  `id` int(10) UNSIGNED NOT NULL,
  `waktu` datetime DEFAULT NULL,
  `isi_saldo` int(11) DEFAULT NULL,
  `pelanggan_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `riwayat_isi_saldos`
--

INSERT INTO `riwayat_isi_saldos` (`id`, `waktu`, `isi_saldo`, `pelanggan_id`) VALUES
(1, '2021-11-14 10:01:34', 10000, 4),
(2, '2021-11-14 10:01:34', 2000, 4),
(3, '2021-11-14 10:01:34', 1000, 4),
(4, '2021-11-14 10:02:44', 2000, 4),
(5, '2021-11-14 10:03:22', 3000, 4),
(6, '2021-12-01 22:28:26', 1000000000, 5),
(7, '2021-12-01 22:30:23', 1, 5),
(8, '2021-12-01 22:30:30', 1, 5),
(9, '2021-12-01 22:31:00', 1000, 2),
(10, '2021-12-01 22:31:06', 100000, 2),
(11, '2021-12-01 22:34:37', 1000000, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barangs`
--
ALTER TABLE `barangs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_barangs_kategoris1_idx` (`kategori_id`);

--
-- Indexes for table `barang_cabang`
--
ALTER TABLE `barang_cabang`
  ADD PRIMARY KEY (`cabang_id`,`barang_id`),
  ADD KEY `fk_cabangs_has_barangs_barangs1_idx` (`barang_id`),
  ADD KEY `fk_cabangs_has_barangs_cabangs1_idx` (`cabang_id`);

--
-- Indexes for table `barang_order`
--
ALTER TABLE `barang_order`
  ADD PRIMARY KEY (`order_id`,`barang_id`),
  ADD KEY `fk_orders_has_barangs_barangs1_idx` (`barang_id`),
  ADD KEY `fk_orders_has_barangs_orders1_idx` (`order_id`);

--
-- Indexes for table `barang_penjual`
--
ALTER TABLE `barang_penjual`
  ADD PRIMARY KEY (`penjual_id`,`barang_id`),
  ADD KEY `fk_penjuals_has_barangs_barangs1_idx` (`barang_id`),
  ADD KEY `fk_penjuals_has_barangs_penjuals1_idx` (`penjual_id`);

--
-- Indexes for table `blacklists`
--
ALTER TABLE `blacklists`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cabangs`
--
ALTER TABLE `cabangs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_cabangs_pegawais1_idx` (`pegawai_id`);

--
-- Indexes for table `chats`
--
ALTER TABLE `chats`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_chats_orders1_idx` (`order_id`,`driver_id`,`pelanggan_id`,`penjual_id`);

--
-- Indexes for table `drivers`
--
ALTER TABLE `drivers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `gifts`
--
ALTER TABLE `gifts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `gift_redeems`
--
ALTER TABLE `gift_redeems`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_gift_redeems_gifts1_idx` (`gift_id`);

--
-- Indexes for table `kategoris`
--
ALTER TABLE `kategoris`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `metode_pembayarans`
--
ALTER TABLE `metode_pembayarans`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `notifikasis`
--
ALTER TABLE `notifikasis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_notifikasis_pelanggans1_idx` (`pelanggan_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`,`pelanggan_id`,`driver_id`),
  ADD KEY `fk_orders_promos1_idx` (`promo_id`),
  ADD KEY `fk_orders_cabangs1_idx` (`cabang_id`),
  ADD KEY `fk_orders_gift_redeems1_idx` (`gift_redeem_id`),
  ADD KEY `fk_orders_metode_pembayarans1_idx` (`metode_pembayaran_id`),
  ADD KEY `fk_orders_penjuals1_idx` (`penjual_id`),
  ADD KEY `fk_orders_drivers1_idx` (`driver_id`),
  ADD KEY `fk_orders_pelanggans1_idx` (`pelanggan_id`);

--
-- Indexes for table `pegawais`
--
ALTER TABLE `pegawais`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pelanggans`
--
ALTER TABLE `pelanggans`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pemasukkan`
--
ALTER TABLE `pemasukkan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penilaians`
--
ALTER TABLE `penilaians`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_penilaians_barangs1_idx` (`barang_id`);

--
-- Indexes for table `penjuals`
--
ALTER TABLE `penjuals`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_penjuals_blacklists1_idx` (`blacklist_id`);

--
-- Indexes for table `promos`
--
ALTER TABLE `promos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `riwayat_isi_saldos`
--
ALTER TABLE `riwayat_isi_saldos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_riwayat_isi_saldos_pelanggans1_idx` (`pelanggan_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barangs`
--
ALTER TABLE `barangs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `blacklists`
--
ALTER TABLE `blacklists`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cabangs`
--
ALTER TABLE `cabangs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `drivers`
--
ALTER TABLE `drivers`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `gifts`
--
ALTER TABLE `gifts`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `gift_redeems`
--
ALTER TABLE `gift_redeems`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `kategoris`
--
ALTER TABLE `kategoris`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `metode_pembayarans`
--
ALTER TABLE `metode_pembayarans`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `notifikasis`
--
ALTER TABLE `notifikasis`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pegawais`
--
ALTER TABLE `pegawais`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `pelanggans`
--
ALTER TABLE `pelanggans`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `promos`
--
ALTER TABLE `promos`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `riwayat_isi_saldos`
--
ALTER TABLE `riwayat_isi_saldos`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barangs`
--
ALTER TABLE `barangs`
  ADD CONSTRAINT `fk_barangs_kategoris1` FOREIGN KEY (`kategori_id`) REFERENCES `kategoris` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `barang_cabang`
--
ALTER TABLE `barang_cabang`
  ADD CONSTRAINT `fk_cabangs_has_barangs_barangs1` FOREIGN KEY (`barang_id`) REFERENCES `barangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_cabangs_has_barangs_cabangs1` FOREIGN KEY (`cabang_id`) REFERENCES `cabangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `barang_order`
--
ALTER TABLE `barang_order`
  ADD CONSTRAINT `fk_orders_has_barangs_barangs1` FOREIGN KEY (`barang_id`) REFERENCES `barangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_has_barangs_orders1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `barang_penjual`
--
ALTER TABLE `barang_penjual`
  ADD CONSTRAINT `fk_penjuals_has_barangs_barangs1` FOREIGN KEY (`barang_id`) REFERENCES `barangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_penjuals_has_barangs_penjuals1` FOREIGN KEY (`penjual_id`) REFERENCES `penjuals` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `cabangs`
--
ALTER TABLE `cabangs`
  ADD CONSTRAINT `fk_cabangs_pegawais1` FOREIGN KEY (`pegawai_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `chats`
--
ALTER TABLE `chats`
  ADD CONSTRAINT `fk_chats_orders1` FOREIGN KEY (`order_id`,`driver_id`,`pelanggan_id`,`penjual_id`) REFERENCES `orders` (`id`, `driver_id`, `pelanggan_id`, `penjual_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `gift_redeems`
--
ALTER TABLE `gift_redeems`
  ADD CONSTRAINT `fk_gift_redeems_gifts1` FOREIGN KEY (`gift_id`) REFERENCES `gifts` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `notifikasis`
--
ALTER TABLE `notifikasis`
  ADD CONSTRAINT `fk_notifikasis_pelanggans1` FOREIGN KEY (`pelanggan_id`) REFERENCES `pelanggans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `fk_orders_cabangs1` FOREIGN KEY (`cabang_id`) REFERENCES `cabangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_drivers1` FOREIGN KEY (`driver_id`) REFERENCES `drivers` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_gift_redeems1` FOREIGN KEY (`gift_redeem_id`) REFERENCES `gift_redeems` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_metode_pembayarans1` FOREIGN KEY (`metode_pembayaran_id`) REFERENCES `metode_pembayarans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_pelanggans1` FOREIGN KEY (`pelanggan_id`) REFERENCES `pelanggans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_penjuals1` FOREIGN KEY (`penjual_id`) REFERENCES `penjuals` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_orders_promos1` FOREIGN KEY (`promo_id`) REFERENCES `promos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `penilaians`
--
ALTER TABLE `penilaians`
  ADD CONSTRAINT `fk_penilaians_barangs1` FOREIGN KEY (`barang_id`) REFERENCES `barangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `penjuals`
--
ALTER TABLE `penjuals`
  ADD CONSTRAINT `fk_penjuals_blacklists1` FOREIGN KEY (`blacklist_id`) REFERENCES `blacklists` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `riwayat_isi_saldos`
--
ALTER TABLE `riwayat_isi_saldos`
  ADD CONSTRAINT `fk_riwayat_isi_saldos_pelanggans1` FOREIGN KEY (`pelanggan_id`) REFERENCES `pelanggans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
