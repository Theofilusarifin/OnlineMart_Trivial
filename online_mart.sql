-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2022 at 05:19 PM
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
(15, 'Asus ROG Phone', '15000000', 'Handphone dengan spek tertinggi!', 'Asus ROG Phone_ukMy7mGA.png', 5),
(16, 'Ayam 100 Gram', '25000', 'Ayam lokal dengan kualitas Internasional', 'Ayam 100 Gram_xLmiivl2.png', 4),
(17, 'Boba Tea', '10000', 'Minum boba tea akan menghilangkan dahaga dan stress anda', 'Boba Tea_Xyf5uHVp.png', 2),
(18, 'Minyak Goreng Bimoli', '23000', 'Minyak goreng dengan warna kuning keemasan', 'Minyak Goreng Bimoli_FclXRrMV.png', 3),
(20, 'Mie Ayam', '23000', 'Mie Ayam', 'Mie Ayam_XGED86wh.png', 1),
(21, 'Daging Sapi 100 gr', '15000', 'Daging kualitas pilihan', 'Daging Sapi 100 gr_BLHcPZJD.png', 4),
(22, 'Rice Bowl', '15000', 'Makanan Rice Bowl', 'Rice Bowl_SZAh5e80.png', 1);

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
(1, 17, 149);

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
(1, 10000, 202201140001, 17),
(5, 115000, 202201140002, 18),
(3, 69000, 202201140003, 18),
(5, 115000, 202201140004, 18);

-- --------------------------------------------------------

--
-- Table structure for table `barang_penjual`
--

CREATE TABLE `barang_penjual` (
  `penjual_id` int(10) UNSIGNED NOT NULL,
  `barang_id` int(10) UNSIGNED NOT NULL,
  `stok` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `barang_penjual`
--

INSERT INTO `barang_penjual` (`penjual_id`, `barang_id`, `stok`) VALUES
(1, 18, 137),
(7, 20, 100),
(8, 22, 1000);

-- --------------------------------------------------------

--
-- Table structure for table `blacklists`
--

CREATE TABLE `blacklists` (
  `id` int(10) UNSIGNED NOT NULL,
  `jenis` varchar(45) NOT NULL,
  `alasan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `blacklists`
--

INSERT INTO `blacklists` (`id`, `jenis`, `alasan`) VALUES
(1, 'Test', 'Test');

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
(1, 'Gubeng', 'Jl. Gubeng Airlangga I No.2, Airlangga', 2),
(2, 'Manyar', 'Manyar Kartika Timur No.6 Surabaya', 3),
(3, 'Ngagel', 'Jl. Ngagel Jaya Selatan No. 104', 5),
(4, 'Wiyung', 'Jl. Raya Menganti Wiyung', 2),
(5, 'Wonokromo', 'Jl. Cisadane No.51', 3);

-- --------------------------------------------------------

--
-- Table structure for table `chats`
--

CREATE TABLE `chats` (
  `id` int(10) UNSIGNED NOT NULL,
  `isi` text DEFAULT NULL,
  `waktu` datetime DEFAULT NULL,
  `role_pengirim` enum('driver','konsumen','penjual') DEFAULT NULL,
  `role_tujuan` enum('driver','konsumen','penjual') DEFAULT NULL,
  `order_id` bigint(19) UNSIGNED NOT NULL,
  `driver_id` int(10) UNSIGNED DEFAULT NULL,
  `pelanggan_id` int(10) UNSIGNED NOT NULL,
  `penjual_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chats`
--

INSERT INTO `chats` (`id`, `isi`, `waktu`, `role_pengirim`, `role_tujuan`, `order_id`, `driver_id`, `pelanggan_id`, `penjual_id`) VALUES
(1, 'Halo', '2022-01-14 21:54:00', 'penjual', 'konsumen', 202201140002, NULL, 4, 1),
(2, 'Titik jemput sesuai lokasi aplikasi ya pak', '2022-01-14 22:03:35', 'konsumen', 'driver', 202201140002, 2, 4, NULL),
(3, 'Baik', '2022-01-14 23:10:58', 'driver', 'konsumen', 202201140002, 2, 4, NULL);

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
(6, '2021-12-01 22:34:48', 1000, 2),
(7, '2022-01-14 17:24:50', 1000, 2),
(8, '2022-01-14 23:14:14', 1000, 2);

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
(1, 'Makanan'),
(2, 'Minuman'),
(3, 'Bumbu Dapur'),
(4, 'Bahan Dapur'),
(5, 'Alat Elektronik');

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
  `role_user` enum('driver','konsumen','penjual','pegawai') NOT NULL,
  `pelanggan_id` int(10) UNSIGNED DEFAULT NULL,
  `driver_id` int(10) UNSIGNED DEFAULT NULL,
  `pegawai_id` int(10) UNSIGNED DEFAULT NULL,
  `penjual_id` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `notifikasis`
--

INSERT INTO `notifikasis` (`id`, `isi`, `tipe`, `waktu`, `role_user`, `pelanggan_id`, `driver_id`, `pegawai_id`, `penjual_id`) VALUES
(1, 'Order Masuk', 'order', '2022-01-14 17:17:59', 'driver', 4, 2, NULL, NULL),
(2, 'Order Masuk', 'order', '2022-01-14 17:24:45', 'driver', 4, 2, NULL, NULL),
(3, 'Order Cancelled', 'order', '2022-01-14 17:47:26', 'konsumen', 4, 2, NULL, NULL),
(4, 'Order Cancelled', 'order', '2022-01-14 17:48:49', 'konsumen', 4, 2, NULL, NULL),
(5, 'Titik jemput sesuai lokasi aplikasi ya pak', 'chat', '2022-01-14 22:03:35', 'driver', 4, 2, NULL, NULL),
(6, 'Order Masuk', 'order', '2022-01-14 22:22:18', 'driver', 4, 2, NULL, NULL),
(7, 'Order Cancelled', 'order', '2022-01-14 22:43:07', 'konsumen', 4, 2, NULL, NULL),
(8, 'Order Cancelled', 'order', '2022-01-14 23:10:20', 'konsumen', 4, 2, NULL, NULL),
(9, 'Baik', 'chat', '2022-01-14 23:10:58', 'konsumen', 4, 2, NULL, NULL),
(10, 'Order Masuk', 'order', '2022-01-14 23:13:57', 'driver', 4, 2, NULL, NULL);

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
  `status` enum('Menunggu Pembayaran','Pesanan Diproses','Order Selesai','Cancelled') DEFAULT NULL,
  `cabang_id` int(10) UNSIGNED DEFAULT NULL,
  `pelanggan_id` int(10) UNSIGNED NOT NULL,
  `driver_id` int(10) UNSIGNED NOT NULL,
  `metode_pembayaran_id` int(10) UNSIGNED NOT NULL,
  `promo_id` int(10) UNSIGNED DEFAULT NULL,
  `gift_redeem_id` int(10) UNSIGNED NOT NULL,
  `penjual_id` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `tanggal_waktu`, `alamat_tujuan`, `ongkos_kirim`, `total_bayar`, `cara_bayar`, `status`, `cabang_id`, `pelanggan_id`, `driver_id`, `metode_pembayaran_id`, `promo_id`, `gift_redeem_id`, `penjual_id`) VALUES
(202201140001, '2022-01-14 17:17:43', 'Jln Ngaggel jaya', 10000, 10000, 'Transfer', 'Cancelled', 1, 4, 2, 1, 1, 1, NULL),
(202201140002, '2022-01-14 17:22:38', 'Jln Dr Sutomo no 13', 10000, 115000, 'Transfer', 'Order Selesai', NULL, 4, 2, 2, 4, 1, 1),
(202201140003, '2022-01-14 22:19:31', 'Jln Ngangel', 10000, 69000, 'Transfer', 'Pesanan Diproses', NULL, 4, 2, 1, 1, 1, 1),
(202201140004, '2022-01-14 23:07:38', 'Jln Tenggilis Mejoyo', 10000, 115000, 'Transfer', 'Pesanan Diproses', NULL, 4, 2, 4, 3, 1, 1);

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
(4, 'arifin', 'arifin', 'arifin@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1932218310', 9638500, 11260),
(5, 'ivan', 'ivan', 'ivan@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '1932218', 1000000000, 0),
(6, 'brian', 'brian', 'brian@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '08128392173', 0, 0),
(8, 'maya', 'Maya', 'maya@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '08121902910', 0, 0),
(11, 'Akun', 'Akun', 'Akun@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', '013921830120', 0, 0);

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

--
-- Dumping data for table `penilaians`
--

INSERT INTO `penilaians` (`id`, `rating`, `review`, `barang_id`) VALUES
(1, 1, 'Barangnya bagus sesuai pesanan tapi saya kasih bintang 1 karena saya jahat', 17),
(2, 5, 'Barang jelek tidak sesuai pesanan, penjual babi tapi karena saya baik jadi saya kasih bintang 5', 17),
(3, 5, 'Penjual baik dan ramah, barang yang dikirim sesuai dengan pesanan', 17);

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
(1, 'arifin', 'arifin', 'arifin', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'OK', '901839218301', NULL),
(2, 'yaska', 'yaska', 'yaska', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'OK', '901839218301', NULL),
(3, 'henri', 'henri', 'henri', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Pending', '901839218301', NULL),
(4, 'ivan', 'ivan', 'ivan', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Pending', '124104210', NULL),
(5, 'akun', 'akun', 'akun@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Pending', '03204203420', NULL),
(6, 'crux', 'crux', 'crux@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'Pending', '92013821093', NULL),
(7, 'tom', 'tom', 'tom@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'OK', '938208420', NULL),
(8, 'tobey', 'tobey', 'tobey@gmail.com', 'b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86', 'OK', '892371780381', NULL);

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
  ADD KEY `fk_chats_orders1_idx` (`order_id`,`pelanggan_id`,`driver_id`);

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
  ADD KEY `fk_notifikasis_pelanggans1_idx` (`pelanggan_id`),
  ADD KEY `fk_notifikasis_drivers1_idx` (`driver_id`),
  ADD KEY `fk_notifikasis_pegawais1_idx` (`pegawai_id`),
  ADD KEY `fk_notifikasis_penjuals1_idx` (`penjual_id`);

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
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `blacklists`
--
ALTER TABLE `blacklists`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `cabangs`
--
ALTER TABLE `cabangs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `chats`
--
ALTER TABLE `chats`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `kategoris`
--
ALTER TABLE `kategoris`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `metode_pembayarans`
--
ALTER TABLE `metode_pembayarans`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `notifikasis`
--
ALTER TABLE `notifikasis`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `pegawais`
--
ALTER TABLE `pegawais`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `pelanggans`
--
ALTER TABLE `pelanggans`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `penjuals`
--
ALTER TABLE `penjuals`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

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
  ADD CONSTRAINT `fk_chats_orders1` FOREIGN KEY (`order_id`,`pelanggan_id`,`driver_id`) REFERENCES `orders` (`id`, `pelanggan_id`, `driver_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `gift_redeems`
--
ALTER TABLE `gift_redeems`
  ADD CONSTRAINT `fk_gift_redeems_gifts1` FOREIGN KEY (`gift_id`) REFERENCES `gifts` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `notifikasis`
--
ALTER TABLE `notifikasis`
  ADD CONSTRAINT `fk_notifikasis_drivers1` FOREIGN KEY (`driver_id`) REFERENCES `drivers` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_notifikasis_pegawais1` FOREIGN KEY (`pegawai_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_notifikasis_pelanggans1` FOREIGN KEY (`pelanggan_id`) REFERENCES `pelanggans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_notifikasis_penjuals1` FOREIGN KEY (`penjual_id`) REFERENCES `penjuals` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

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
