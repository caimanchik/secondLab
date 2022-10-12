# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #2 выполнил:
- Волков Кирилл Дмитриевич
- РИ210914
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Код реализации выполнения задания. Визуализация результатов выполнения.
- Задание 2.
- Код реализации выполнения задания. Визуализация результатов выполнения.
- Задание 3.
- Код реализации выполнения задания. Визуализация результатов выполнения.
- Выводы.

## Цель работы
Познакомиться с программными средствами для организции передачи данных между инструментами google, Python и Unity

## Задание 1

- Создание проекта в google.console
<img width="1904" alt="Снимок экрана 2022-10-12 в 01 16 28" src="https://user-images.githubusercontent.com/79734984/195210728-9b5128c0-8579-4c14-8631-46fdf9346bbb.png">

- Добавление google drive и google sheets api
<img width="1036" alt="Снимок экрана 2022-10-12 в 01 22 54" src="https://user-images.githubusercontent.com/79734984/195213588-7586bd78-ffe7-4771-86e6-037c563ff76e.png">
<img width="1036" alt="Снимок экрана 2022-10-12 в 01 23 44" src="https://user-images.githubusercontent.com/79734984/195213592-03a0ddfe-45dc-4f4b-b924-2626f61d7c48.png">


- Создание проекта python с виртуальным окружением и добавление JSON файла
![Снимок экрана 2022-10-12 в 01 14 35](https://user-images.githubusercontent.com/79734984/195211254-54aaca85-2baf-484b-9dac-98bd271a17b9.png)

- Предоставление доступа
<img width="1904" alt="Снимок экрана 2022-10-12 в 01 20 28" src="https://user-images.githubusercontent.com/79734984/195211375-ed806fc9-986c-46fa-b69f-efdf92e06f0f.png">

- Добавление numpy и gspread в проект
![Снимок экрана 2022-10-12 в 01 32 57](https://user-images.githubusercontent.com/79734984/195211425-ddd9e056-2a61-4ae2-8f73-9912cc4f3926.png)
<img width="1036" alt="Снимок экрана 2022-10-12 в 01 23 44" src="https://user-images.githubusercontent.com/79734984/195211420-939054e7-892c-4926-990b-045c29ef741d.png">

- Добавление данных в таблицу с помощью скрипта, [ссылка на скрипт](https://github.com/caimanchik/secondLab/blob/main/main.py)
![Снимок экрана 2022-10-12 в 01 34 01](https://user-images.githubusercontent.com/79734984/195211534-fc597003-aa45-446a-851a-c5ccccfea1ee.png)
<img width="1904" alt="Снимок экрана 2022-10-12 в 01 34 14" src="https://user-images.githubusercontent.com/79734984/195211576-8192815d-2b74-4f20-b5e0-63689dc33fc0.png">

- Получение API ключа
<img width="1904" alt="Снимок экрана 2022-10-12 в 01 37 00" src="https://user-images.githubusercontent.com/79734984/195211695-98a1f456-056e-44af-8833-2cc8238588d7.png">
<img width="1904" alt="Снимок экрана 2022-10-12 в 01 38 01" src="https://user-images.githubusercontent.com/79734984/195211697-890e71eb-0eff-4bbf-b089-541ff4962fe9.png">

- Предоставление прав редактирования таблицы
<img width="1904" alt="Снимок экрана 2022-10-12 в 01 39 04" src="https://user-images.githubusercontent.com/79734984/195211749-7eb1908a-f808-493b-a1da-4fe851511b84.png">

- Создание нового проекта Unity
<img width="1136" alt="Снимок экрана 2022-10-12 в 01 40 31" src="https://user-images.githubusercontent.com/79734984/195211797-78b5361a-dcc0-4ac0-b5b8-0303c504717c.png">

- Добавление звуков и скриптов в Unity
<img width="1792" alt="Снимок экрана 2022-10-12 в 01 45 44" src="https://user-images.githubusercontent.com/79734984/195212000-762474fa-02e1-4aa6-aec3-46d410e97328.png">
<img width="1792" alt="Снимок экрана 2022-10-12 в 01 46 56" src="https://user-images.githubusercontent.com/79734984/195212003-447bc1a7-6207-48cc-834a-cbaa5f3f0b55.png">

- Скрипт включения разных вариантов звука при определенных условиях, [ссылка на скрипт](https://github.com/caimanchik/secondLab/blob/main/NewBehaviourScript.cs)
<img width="1792" alt="Снимок экрана 2022-10-12 в 03 45 25" src="https://user-images.githubusercontent.com/79734984/195212191-b27b8b22-28b5-43f9-8a6e-770866d03564.png">
<img width="1792" alt="Снимок экрана 2022-10-12 в 03 45 46" src="https://user-images.githubusercontent.com/79734984/195212195-78736631-4109-42f1-a676-8f0337e4a1e6.png">
<img width="1792" alt="Снимок экрана 2022-10-12 в 03 45 53" src="https://user-images.githubusercontent.com/79734984/195212197-2f0c0943-2b4d-47de-a418-e8ebb4236bfc.png">

- Результат выполнения скрипта в консоли Unity(скрин без звука)
<img width="1792" alt="Снимок экрана 2022-10-12 в 03 27 01" src="https://user-images.githubusercontent.com/79734984/195212320-63afcaca-23f3-47ed-9182-8caefc4f7fe8.png">


## Задание 2
- Реализация скрипта по заполнению таблицы параметром loss через каждые 150 итераций, [ссылка на скрипт](https://github.com/caimanchik/secondLab/blob/main/loss_func.py)
<img width="1792" alt="Снимок экрана 2022-10-12 в 13 40 22" src="https://user-images.githubusercontent.com/79734984/195294591-c3dba69d-ac7c-4af2-9db9-ffb12e5b971a.png">
<img width="1792" alt="Снимок экрана 2022-10-12 в 13 40 41" src="https://user-images.githubusercontent.com/79734984/195294594-37a2073a-d006-4cd6-bdf3-494a18bfa8c4.png">
- Результат в таблице
<img width="338" alt="Снимок экрана 2022-10-12 в 13 41 40" src="https://user-images.githubusercontent.com/79734984/195294749-9fe06eba-369f-4bf7-ade2-8d68a8b3b122.png">


## Задание 3
- Изменение границ воспроизведения различных реплик в скрипте C#, изменение количества распарсившихся из JSON параметров, [ссылка на скрипт](https://github.com/caimanchik/secondLab/blob/main/NewBehaviourScript_loss.cs)
<img width="1792" alt="Снимок экрана 2022-10-12 в 13 45 12" src="https://user-images.githubusercontent.com/79734984/195295737-bd2384b3-5ba6-4d77-bd60-16c24c0ac279.png">
- Результат в Unity, опять скрин без звука(
<img width="1792" alt="Снимок экрана 2022-10-12 в 13 47 00" src="https://user-images.githubusercontent.com/79734984/195295974-7133be62-ac32-4dcd-9e15-5fdeec648042.png">


## Выводы

В данной лабораторной работе я научился создавать и записывать данные в google таблицы, а также получать и использовать их в Unity в разных сценариях

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
