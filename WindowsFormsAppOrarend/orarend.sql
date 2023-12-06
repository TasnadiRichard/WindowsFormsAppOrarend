-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Dec 06. 10:36
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `orarend`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orak`
--

CREATE TABLE `orak` (
  `oraid` int(10) UNSIGNED NOT NULL,
  `tantargy` varchar(30) NOT NULL,
  `sorszam` int(11) NOT NULL COMMENT 'Az óra sorszáma a napon belül',
  `hetnapja` enum('hétfő','kedd','szerda','csütörtök','péntek') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `orak`
--

INSERT INTO `orak` (`oraid`, `tantargy`, `sorszam`, `hetnapja`) VALUES
(1, 'Aszt.mobil.alk.fejl.teszt', 1, 'hétfő'),
(2, 'Aszt.mobil.alk.fejl.teszt', 2, 'hétfő'),
(3, 'Aszt.mobil.alk.fejl.teszt', 3, 'hétfő'),
(4, 'Frontend', 4, 'hétfő'),
(5, 'Frontend', 5, 'hétfő'),
(6, 'Frontend', 6, 'hétfő'),
(7, 'Frontend', 7, 'hétfő'),
(8, 'Aszt.mobil.alk.fejl.teszt', 1, 'kedd'),
(9, 'Aszt.mobil.alk.fejl.teszt', 2, 'kedd'),
(10, 'Aszt.mobil.alk.fejl.teszt', 3, 'kedd'),
(11, 'Backend', 4, 'kedd'),
(12, 'Backend', 5, 'kedd'),
(13, 'Backend', 6, 'kedd'),
(14, 'Backend', 7, 'kedd'),
(15, 'Frontend', 1, 'szerda'),
(16, 'Frontend', 2, 'szerda'),
(17, 'Backend', 3, 'szerda'),
(18, 'Backend', 4, 'szerda'),
(19, 'Backend', 5, 'szerda'),
(20, 'Adatb.2.', 6, 'szerda'),
(21, 'Adatb.2.', 7, 'szerda'),
(22, 'IKT proj.2.', 1, 'csütörtök'),
(23, 'IKT proj.2.', 2, 'csütörtök'),
(24, 'IKT proj.2.', 3, 'csütörtök'),
(25, 'IKT proj.2.', 4, 'csütörtök'),
(26, 'IKT proj.2.', 5, 'csütörtök'),
(27, 'IKT proj.2.', 6, 'csütörtök'),
(28, 'IKT proj.2.', 7, 'csütörtök'),
(29, 'Konz.fogl.', 1, 'péntek'),
(30, 'Szakm.angol', 2, 'péntek'),
(31, 'Szakm.angol', 3, 'péntek'),
(32, 'Munk.id.nyelv', 4, 'péntek'),
(33, 'Munk.id.nyelv', 5, 'péntek'),
(34, 'Munk.id.nyelv', 6, 'péntek'),
(35, 'Munk.id.nyelv', 7, 'péntek');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tanarok`
--

CREATE TABLE `tanarok` (
  `tanarid` int(10) UNSIGNED NOT NULL,
  `tanarnev` varchar(30) NOT NULL,
  `jelszo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `tanarok`
--

INSERT INTO `tanarok` (`tanarid`, `tanarnev`, `jelszo`) VALUES
(1, 'Lajos', 1234);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `orak`
--
ALTER TABLE `orak`
  ADD PRIMARY KEY (`oraid`);

--
-- A tábla indexei `tanarok`
--
ALTER TABLE `tanarok`
  ADD PRIMARY KEY (`tanarid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `orak`
--
ALTER TABLE `orak`
  MODIFY `oraid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT a táblához `tanarok`
--
ALTER TABLE `tanarok`
  MODIFY `tanarid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
