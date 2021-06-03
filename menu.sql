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
-- База данных: `menu`
--

-- --------------------------------------------------------

--
-- Структура таблицы `bread`
--

CREATE TABLE `bread` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `bread`
--

INSERT INTO `bread` (`id`, `name`, `weight`, `price`) VALUES
(1, 'Хлебная корзина с домашним маслом', '460', '190');

-- --------------------------------------------------------

--
-- Структура таблицы `desserts classic`
--

CREATE TABLE `desserts classic` (
  `id` int NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `comment` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `desserts classic`
--

INSERT INTO `desserts classic` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Лаймовый мусс', 'Лаймовый мусс, песочная подложка, итальянская меренга, апельсиновый ликер', '150', 350),
(2, 'Фирменные эклеры', 'Выберите любимый вкус: черная смородина, фисташка, ваниль, карамель или манго', '160', 250),
(3, 'Пять эклеров с разной начинкой в специальной подарочной упаковке ', '', '500', 800),
(4, 'Фирменные мини-капкейки', 'Выбери свой вкус: черная смородина, малина, апельсин, фисташка, голубика или манго', '350', 300),
(5, 'Шесть мини-капкейков с разной начинкой в специальной подарочной упаковке', '', '340', 400),
(6, 'Шоколадный десерт с миндалем', 'Шоколадный мусс, миндаль в мягкой карамели, шоколадный бисквит', '300', 300),
(7, 'Домашнее мороженое и сорбеты в ассортименте', '', '100-300', 300);

-- --------------------------------------------------------

--
-- Структура таблицы `desserts modern`
--

CREATE TABLE `desserts modern` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `desserts modern`
--

INSERT INTO `desserts modern` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Композиция № 7. Супрематизм', 'Манговый чизкейк, мусс из маракуйи, клубника, кули из манго', '150', 350),
(2, 'Космос 2.0', 'Лимонный крем, кули из алоэ и щавеля', '135', 330),
(3, 'Композиция № 1', 'Ромовая баба, шоколадная сфера, ванильный крем, голубика, горячая карамель)', '170', 400);

-- --------------------------------------------------------

--
-- Структура таблицы `fish`
--

CREATE TABLE `fish` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `fish`
--

INSERT INTO `fish` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Тартар из лосося с дайконом', 'Белое полусухое Txomin Etxaniz Zuri 2017', '300', '660'),
(2, 'Татаки из тунца', 'Белое полусухое Txomin Etxaniz Zuri 2017', '330', '560'),
(3, 'Салат с маринованной макрелью и редисом', 'Оранжевое сухое Metamorphika Xarel-lo Brisat 2017', '340', '300'),
(4, 'Салат из семги с мандаринами', 'Белое сухое Pierre Chainier Cour de Pocé Muscadet 2018', '270', '400'),
(5, 'Осьминог с тремя формами картофеля', 'Жемчужный брют Podere II Saliceto Bi Fri Bianco dell’Emilia IGP 2018', '400', '560'),
(6, 'Жареная треска с рагу из мидий и шпината', 'Белое полусухое Txomin Etxaniz Zuri 2017\r\n', '400', '700'),
(7, 'Черный лосось с брусникой и яблочным пюре', 'Красное сухое Claus Preisinger Zweigelt Kieselstein 2018', '320', '900'),
(8, 'Сибас, запеченный с травами', 'Белое сухое Clearwater Cove Sauvignon Blanc 2019\r\n', '380', '940'),
(9, 'Осетрина гриль с мороженым из базилика', 'Белое полусухое Txomin Etxaniz Zuri 2017', '440', '1100');

-- --------------------------------------------------------

--
-- Структура таблицы `garnish`
--

CREATE TABLE `garnish` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `garnish`
--

INSERT INTO `garnish` (`id`, `name`, `weight`, `price`) VALUES
(1, 'Овощной рататуй', '200', '250'),
(2, 'Молодой картофель с розмарином', '230', '190');

-- --------------------------------------------------------

--
-- Структура таблицы `meat`
--

CREATE TABLE `meat` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `meat`
--

INSERT INTO `meat` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Тартар из говяжьей вырезки с кремом из черного чеснока \r\n', 'Красное сухое Travaglini Cinzia\r\n', '400', '600'),
(2, 'Картофельная вафля с беконом, сладкими томатами и муссом из пармезана', '', '360', '580'),
(3, 'Салат из утки с грушей и ягодами годжи', 'Оранжевое сухое Metamorphika Xarel-lo Brisat 2017', '340', '500'),
(4, 'Салат с ростбифом', 'Красное сухое Bodega Nodus En la Parra Tinto Joven Ecológico Valencia DO 2017', '340', '600'),
(5, 'Паштет из куриной печени с ревенем, клубникой и теплым луковым хлебом', '', '250', '400'),
(6, 'Томленый говяжий язык в соусе из сладкой горчицы с малосольным огурцом', 'Красное сухое Travaglini Cinzia', '400', '670'),
(7, 'Филе-миньон с лжекартофелем, лесными грибами и трюфельным соусом', 'Красное сухое Claus Preisinger Zweigelt Kieselstein 2018\r\n', '420', '780'),
(8, 'Строганов с грибами и картофельным кремом', 'Красное сухое Bodega Nodus En la Parra Tinto Joven Ecológico Valencia DO 2017', '360', '590'),
(9, 'Корейка ягненка с молодыми овощами', 'Красное сухое Claus Preisinger Zweigelt Kieselstein 2018', '430', '1100');

-- --------------------------------------------------------

--
-- Структура таблицы `pasta`
--

CREATE TABLE `pasta` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `pasta`
--

INSERT INTO `pasta` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Паста карбонара', 'Красное сухое Claus Preisinger Zweigelt Kieselstein 2018', '300', '480'),
(2, 'Паста с лососем', '', '380', '600'),
(3, 'Паста с вешенками и кедровыми орехами', '', '370', '340');

-- --------------------------------------------------------

--
-- Структура таблицы `snacks`
--

CREATE TABLE `snacks` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `snacks`
--

INSERT INTO `snacks` (`id`, `name`, `price`) VALUES
(1, 'Прошутто с грушей', '400'),
(2, 'Сыр, клубника, мед', '300'),
(3, 'Оливки, маслины', '280'),
(4, 'Буррата с апельсинами и свеклой', '400');

-- --------------------------------------------------------

--
-- Структура таблицы `soup`
--

CREATE TABLE `soup` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `soup`
--

INSERT INTO `soup` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Горячий борщ с ростбифом и салом', '', '300', '290'),
(2, 'Том ям с креветками и осьминогом на кокосовом молоке', 'Белое полусухое Txomin Etxaniz Zuri 2017', '400', '560'),
(3, 'Рыбный суп с осетриной и мидиями', '', '370', '400');

-- --------------------------------------------------------

--
-- Структура таблицы `vegetables`
--

CREATE TABLE `vegetables` (
  `id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `comment` varchar(255) NOT NULL,
  `weight` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `vegetables`
--

INSERT INTO `vegetables` (`id`, `name`, `comment`, `weight`, `price`) VALUES
(1, 'Печеная тыква с домашним йогуртом, кинзой и соусом из тайского манго', '', '400', '360'),
(2, 'Салат с печеными баклажанами и муссом из базилика', 'Белое полусухое Txomin Etxaniz Zuri 2017', '350', '430'),
(3, 'Маринованная груша с джемом из сладкого перца и домашним сыром', 'Игристый брют Cava Mas Fi Brut NV', '260', '490'),
(4, 'Стейк из капусты с копченым черносливом', 'Красное сухое Claus Preisinger Zweigelt Kieselstein 2018', '400', '560'),
(5, 'Спаржа на морковном пюре с яйцом пашот', 'Жемчужный брют Podere Il Saliceto Bi Fri Bianco dell’Emilia IGP 2018', '350', '650');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `bread`
--
ALTER TABLE `bread`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `desserts classic`
--
ALTER TABLE `desserts classic`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `desserts modern`
--
ALTER TABLE `desserts modern`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `fish`
--
ALTER TABLE `fish`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `garnish`
--
ALTER TABLE `garnish`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `meat`
--
ALTER TABLE `meat`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `pasta`
--
ALTER TABLE `pasta`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `snacks`
--
ALTER TABLE `snacks`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `soup`
--
ALTER TABLE `soup`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `vegetables`
--
ALTER TABLE `vegetables`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `bread`
--
ALTER TABLE `bread`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `desserts classic`
--
ALTER TABLE `desserts classic`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `desserts modern`
--
ALTER TABLE `desserts modern`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `fish`
--
ALTER TABLE `fish`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `garnish`
--
ALTER TABLE `garnish`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `pasta`
--
ALTER TABLE `pasta`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `snacks`
--
ALTER TABLE `snacks`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `soup`
--
ALTER TABLE `soup`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `vegetables`
--
ALTER TABLE `vegetables`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
