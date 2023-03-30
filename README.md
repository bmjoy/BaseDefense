<h1 align="center">
Base Defense
</h1>

<h2 align="center">

![](Documentation/images/basedefence_icon.png)

[Base Defense (Demo)](https://play.unity.com/mg/other/base-defense-demo)

</h2>

# Содержание

* [Описание](#описание)
  * [Враги в игре](#враги-в-игре)
    * [Красные](#красные)
    * [Жёлтые](#жёлтые)
    * [Фиолетовые](#фиолетовые)
  * [Вражеские станции](#вражеские-станции)
    * [Малая станция](#малая-станция)
    * [Средняя станция](#средняя-станция)
    * [Большая станция](#большая-станция)
  * [Кристаллы](#кристаллы)
  * [Игровые уровни](#игровые-уровни)
    * [1 уровень](#1-уровень)
    * [2 уровень](#2-уровень)
    * [3 уровень](#3-уровень)
    * [4 уровень](#4-уровень)
    * [5 уровень](#5-уровень)
  * [Оружие](#оружие)
    * [Огнестрельное оружие](#огнестрельное-оружие)
    * [Арбалеты](#арбалеты)
    * [Гранатомёты](#гранатомёты)
  * [Прокачка игрока](#прокачка-игрока)
  * [Немного об игровом персонаже](#немного-об-игровом-персонаже)
  * [Система сохранения](#система-сохранения)
* [Использованные ассеты](#использованные-ассеты)
* [Документация](#документация)

# Описание
Base Defense - игра, реализованная на основе движка Unity 2021.3.15f1.
В ней Вам предстоит защитить свою базу от нападения врагов.

![](Documentation/images/Screenshot_1.png)

Уничтожайте врагов и собирайте с них деньги

![](Documentation/images/Screenshot_6.png)

За накопленные деньги Вы можете купить себе новое оружие, чтобы более эффективно расправляться с врагами!

![](Documentation/images/Screenshot_2.png) ![](Documentation/images/Screenshot_3.png)

Также Вы можете добывать кристаллы, разбивая их своим оружием

![](Documentation/images/Screenshot_7.png) ![](Documentation/images/Screenshot_8.png)

За добытые кристаллы можно прокачать игрока

![](Documentation/images/Screenshot_4.png) ![](Documentation/images/Screenshot_5.png)

Уничтожайте вражеские станции, получайте за это награду и защищайте остальные базы!

> <b> Правило: </b> чтобы перейти на следующий уровень, 
> необходимо на текущем уровне уничтожить все станции и 
> всех врагов

![](Documentation/images/Screenshot_9.png) ![](Documentation/images/Screenshot_10.png)

## Враги в игре

Всего в игре 3 вида врагов, они отличаются по количеству здоровья, 
скорости бега, наносимому урону и количеству награды за их уничтожение.
Как только игрок заходит на их территорию, они
сразу начинают его преследовать и затем атаковать. В ином случае они просто патрулируют 
территорию. Во время патруля их здоровье восстанавливается - полное восстановление здоровья
происходит за 1 минуту

### Красные

Самый слабый вид врагов. У них немного здоровья (100 HP), они достаточно
медленные (скорость бега 5 м\сек) и наносят мало урона (10-25 HP).
Награды за них даётся меньше всего.

![](Documentation/images/Screenshot_11.png)

### Жёлтые

От них уже не так просто избавиться. Их максимальное здоровье составляет 150 HP.
Также они достаточно быстрые (скорость бега 5.5 м\сек)
и могут заметно Вас повредить (урон 15-33 HP). За их уничтожение Вы получите 
больше награды.

![](Documentation/images/Screenshot_12.png)

### Фиолетовые

Самый сильный вид врагов. Здоровья у них много (200 HP). Если вы не 
прокачаетесь, у Вас не получится от них скрыться, ведь они бегают со 
скоростью 6 м\сек (скорость игрока без прокачки). Они наносят много урона (20-50 HP), так что лучше
не стоять на месте. За них вы получите больше всего награды.

![](Documentation/images/Screenshot_14.png)

## Вражеские станции

Вражеские станции также бывают 3 видов. Станции нужны для порождения 
новых врагов, так что при их уничтожении новые враги не будут появляться.

### Малая станция

Порождает красных врагов и имеет максимальное здоровье 300 HP. 
Встречается на 1, 2 и 4 уровнях

![](Documentation/images/Screenshot_9.png)

### Средняя станция

Порождает жёлтых врагов и имеет прочность в 1000 HP.
Встречается на 3 и 4 уровнях

![](Documentation/images/Screenshot_13.png)

### Большая станция

Порождает фиолетовых врагов и практически непробиваема - её 
прочность составляет 3000 HP. Встречается только на 5 уровне

![](Documentation/images/Screenshot_15.png)

## Кристаллы

Кристаллы добываются на уровнях, для этого их нужно разбить любым
видом оружия и собрать выпавшие осколки. Главным образом они отличаются
размерами, прочностью и количеством маленьких кристаллов, которые можно из
них добыть.

![](Documentation/images/Screenshot_17.png)

## Игровые уровни

Всего в игре 5 уровней. На них можно встретить разные виды кристаллов, вражеских станций
и порождаемых ими врагов. При прохождении последнего уровня игра начинается заного с сохранением
всех денег, кристаллов и купленных предметов

### 1 уровень

На первом уровне находится всего одна малая вражеская станция и 7 малых кристаллов

![](Documentation/images/Screenshot_16.png)

### 2 уровень

На втором уровне уже 2 малых станций, 4 малых кристалла и 3 кристалла
средних размеров

![](Documentation/images/Screenshot_18.png)

### 3 уровень

На третьем уровне находится 1 средняя вражеская станция и 7 средних
кристаллов

![](Documentation/images/Screenshot_19.png)

### 4 уровень

На четвёртом уровне находятся 2 малых вражеских станций, 1 средняя 
станция, 3 больших кристалла и 4 средних

![](Documentation/images/Screenshot_20.png)

### 5 уровень

На последнем, пятом уровне находится 1 большая станция и 7 больших 
кристаллов

![](Documentation/images/Screenshot_21.png)

## Оружие

В игре есть 3 вида оружия - обычное огнестрельное, арбалеты и 
гранатомёты

### Огнестрельное оружие

Данный вид оружия стреляет обычными патронами, его урон зависит от
силы выстрела. Также у каждого оружия данного типа есть разброс выстрела.
Более точное оружие (пистолеты) подойдёт для атаки на одиночных врагов, 
оружие с большим разбросом (AR) - для атаки на толпу врагов. 

![](Documentation/images/Screenshot_22.png) ![](Documentation/images/Screenshot_23.png)

Различные виды огнестрельных орудий также стреляют разным количеством
патронов за выстрел (от одного до трёх) и имеют разную скорость выстрела

### Арбалеты

Они наносят малый урон стрелами, но их особенность в том, что стрелы
после попадания "застревают" во враге и продолжают наносить ему
существенный урон в течение определённого времени. Не подходят для добычи кристаллов и уничтожения
станций

![](Documentation/images/Screenshot_24.png)

### Гранатомёты

Наносят колоссальный урон в радиусе своего взрыва, так что это идеальное оружие для
уничтожения целой толпы врагов, однако взрыв от гранаты также наносит урон игроку, поэтому
игровой персонаж не стреляет из гранатомёта до тех пор, пока он не отойдёт
на безопасное расстояние

![](Documentation/images/Screenshot_25.png)

## Прокачка игрока

За кристаллы можно прокачивать своего игрового персонажа. Максимальные
характеристики персонажа после полной прокачки:

![](Documentation/images/Screenshot_26.png)

## Немного об игровом персонаже

Управлять персонажем можно с помощью игрового джойстика.

![](Documentation/images/Screenshot_27.png)

Управление персонажем плавное, т.е. вы можете полностью контролировать
скорость его перемещения. Анимация также подстраивается под его скорость.

У игрового персонажа есть приоритет в атаке на другие игровые сущности.
В первую очередь он атакует врагов, остальные сущности (кристаллы и станции)
атакуются, только если в радиусе атаки нет врагов.

Радиус атаки игрового персонажа составляет 12.5 метров - это его поле зрения.
Врагов он может "видеть" на все 360 градусов в пределах этого радиуса

## Система сохранения

В игре сохраняется почти всё её состояние:
* Накопленные деньги и кристаллы
* Прокаченные характеристики
* Купленное игроком оружие
* Выбранное оружие
* Текущий уровень
* Расположение врагов, игрока
* Количество здоровья кристаллов, врагов, игрока, станций

# Использованные ассеты

* [Вражеские станции](https://quaternius.com/packs/ultimatefantasyrts.html)
* [Оружие](https://quaternius.com/packs/scifimodularguns.html)
* [Игровой персонаж](https://assetstore.unity.com/packages/3d/characters/low-character-pack-free-sample-192954)
* [Gems](https://assetstore.unity.com/packages/3d/props/simple-gems-ultimate-animated-customizable-pack-73764)
* [Кристаллы](https://assetstore.unity.com/packages/3d/props/stylized-crystal-77275)

# Документация

Чтобы посмотреть документацию к проекту Base Defense см.
[Документация Base Defense](https://didenis.github.io/BaseDefense/)