-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 03 2021 г., 19:38
-- Версия сервера: 8.0.19
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `wine_map`
--

-- --------------------------------------------------------

--
-- Структура таблицы `pink`
--

CREATE TABLE `pink` (
  `id` int NOT NULL,
  `coutry` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `vol` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `pink`
--

INSERT INTO `pink` (`id`, `coutry`, `name`, `vol`, `price`) VALUES
(1, 'Италия, Тоскана\r\n', 'Rivera Castel Del Monte Rose 2018', '750 мл', '3000');

-- --------------------------------------------------------

--
-- Структура таблицы `red`
--

CREATE TABLE `red` (
  `id` int NOT NULL,
  `coutry` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `vol` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `red`
--

INSERT INTO `red` (`id`, `coutry`, `name`, `vol`, `price`) VALUES
(1, 'Франция, Бургундия', 'Domaine Antonin Guyon Gevrey-Chambertin La Justice AOC 2015', '750 мл', '12800'),
(2, 'Франция, Бургундия', 'Domaine Antonin Guyon Gevrey-Chambertin La Justice AOC 2015', '750 мл', '13200'),
(3, 'Франция, Бургундия', 'Marcel Lapierre Raisins Gaulois VdF 2017', '750 мл', '3200'),
(4, 'Франция, Долина Роны', 'Les Dauphins Reserve Cotes du Rhone AOC 2016', '750 мл', '2100'),
(5, 'Франция, Долина Роны', 'E. Guigal Saint-Joseph Rouge 2013', '750 мл', '6500'),
(6, 'Франция, Бордо', 'Chateau La Faviere Bordeaux Superieur 2016', '750 мл', '3200'),
(7, 'Франция, Бордо', 'Chateau Haut-Villet 2011', '750 мл', '4200'),
(8, 'Франция, Бордо', 'Chateau Malescot St. Exupery AOC 3-em Grand Cru Classe 2007', '750 мл', '16800'),
(9, 'Германия, Пфальц', 'Philipp Kuhn Spatburgunder Tradition 2014', '750 мл', '4100'),
(10, 'Германия, Баден', 'Burg Ravensburg Lochle GG Pinot Noir 2013', '750 мл', '6600'),
(11, 'Австрия, Нижняя Австрия', 'Schloss Gobelsburg St. Laurent Reserve Niederosterreich 2013', '750 мл', '6600'),
(12, 'Австрия, Бургенланд', 'Claus Preisinger Zweigelt Kieselstein 2018', '750 мл', '4000'),
(13, 'Испания, Пла-де-Бажес', 'Bodegas Abadal 3,9 2012', '750 мл', '3800'),
(14, 'Испания, Арагон', 'Bodegas San Alejandro Baltasar Gracian Vinas Viejas 2015', '750 мл', '4500'),
(15, 'Испания, Кастилия-Ла-Манча', 'Esencia Rural De Sol a Sol Natural Tempranillo VdM 2013', '750 мл', '4100'),
(16, 'Испания, Кастилия-Ла-Манча', 'Marques de Grinon Summa Varientalis 2014', '750 мл', '5800'),
(17, 'США, Калифорния', '1000 Stories Zinfandel 2016', '750 мл', '4200'),
(18, 'Чили, Долина Кольчагуа', 'Arboleda Carmenere Colchagua Valley DO 2015', '750 мл', '4000'),
(19, 'Аргентина, Мендоса', 'Pulenta Gran XV 2011', '750 мл', '5500'),
(20, 'Аргентина, Мендоса', 'Pulenta La Flor Malbec 2017', '750 мл', '2800'),
(21, 'Австралия, Долина Макларен', 'Red Baron Fox Creek Shiraz 2016', '750 мл', '3800'),
(22, 'Россия, Краснодарский край', 'Fanagoria Cabernet Franc Винодел&Сомелье', '750 мл', '3000');

-- --------------------------------------------------------

--
-- Структура таблицы `sparkling`
--

CREATE TABLE `sparkling` (
  `id` int NOT NULL,
  `coutry` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `vol` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `sparkling`
--

INSERT INTO `sparkling` (`id`, `coutry`, `name`, `vol`, `price`) VALUES
(1, 'Испания, Каталония', 'Moli Dels Capellans L’Atzar Brut Nature Reserva Cava DO NV', '750 мл', '3000'),
(2, 'Франция, Лангедок-Руссильон', 'Grande Cuvee de Aimery 1531 Cremant de Limoux NV', '750 мл', '3400'),
(3, 'Франция, Эльзас', 'Bestheim Cremant d’Alsace Brut AOC', '750 мл', '3200'),
(4, 'Италия, Эмилия-Романья', 'Podere Il Saliceto Bi Fri Bianco dell’Emilia IGP 2017', '750 мл', '3900'),
(5, 'Австрия, Кампталь\r\n', 'Christoph Hoch Kalkspitz Pét Nat NV', '750 мл', '4400'),
(6, 'ЮАР, Паарл', 'MAN Family Wines Methode Cape Classique NV', '750 мл', '3000'),
(7, 'Франция, Шампань', 'Tribaut Schloesser Brut Rose NV', '750 мл', '5900'),
(8, 'Франция, Шампань', 'Jacquart Brut Mosaique NV ', '750 мл', '5900'),
(9, 'Франция, Шампань', 'Laurent-Perrier La Cuvee Brut NV', '750 мл', '10000'),
(10, 'Франция, Шампань', 'Jacquesson Cuvee 741 Extra Brut', '750 мл', '13800');

-- --------------------------------------------------------

--
-- Структура таблицы `white`
--

CREATE TABLE `white` (
  `id` int NOT NULL,
  `coutry` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `vol` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `white`
--

INSERT INTO `white` (`id`, `coutry`, `name`, `vol`, `price`) VALUES
(1, 'Франция, Долина Луары', 'Domaine de la Garreliere Le Chenin de la Colline 2015', '750 мл', '3900'),
(2, 'Франция, Долина Луары', 'Henri Bourgeois Pouilly-Fume La Demoiselle de Bourgeois 2015', '750 мл', '6800'),
(3, 'Франция, Эльзас', 'Gustave Lorentz Riesling Reserve Alsace AOC 2016', '750 мл', '3600'),
(4, 'Франция, Шабли', 'Domaine Bernard Defaix Chablis Premier Cru Cote de Lechet Reserve 2016', '750 мл', '6400'),
(5, 'Франция, Бургундия', 'Antonin Rodet Puligny Montrachet AOC 2014', '750 мл', '10500'),
(6, 'Франция, Юра', 'Chardonnay Arbois Vins Rijckaert 2016', '750 мл', '4900'),
(7, 'Франция, Бордо', 'Chateau Carbonnieux Blanc Pessac-Leognan AOC\r\nGrand Cru Classe de Graves 2011 ', '750 мл', '8000'),
(8, 'Италия, Фриули — Венеция-Джулия', 'Antonutti Sauvignon Friuli Grave DOC 2016 ', '750 мл', '3200'),
(9, 'Австрия, Кремсталь', 'Rainer Wess Riesling KREMS Kremstal DAC 2015', '750 мл', '4300'),
(10, 'Австрия, Нижняя Австрия', 'Roschitz Gruner Veltliner Weinviertel DAC 2017', '750 мл', '3200'),
(11, 'Португалия, Минью', 'Casa Santos Lima Amoras Vinho Verde DOC', '750 мл', '2400'),
(12, 'ЮАР, Паарл', 'Fairview Darling Chenin Blanc 2018', '750 мл', '2800'),
(13, 'Новая Зеландия, Мальборо', 'Framingham Ribbonwood Riesling 2014', '750 мл', '3700');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `pink`
--
ALTER TABLE `pink`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `red`
--
ALTER TABLE `red`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `sparkling`
--
ALTER TABLE `sparkling`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `white`
--
ALTER TABLE `white`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `pink`
--
ALTER TABLE `pink`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `red`
--
ALTER TABLE `red`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT для таблицы `sparkling`
--
ALTER TABLE `sparkling`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `white`
--
ALTER TABLE `white`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
