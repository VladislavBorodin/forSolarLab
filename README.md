# Тестовое задание версия 1
 Данный проект соответствует следующему заданию:
 Создать приложение "Поздравлятор". Функциональность приложения - ведение списка дней рождения (далее ДР) друзей/знакомых/сотрудников, а именно:
• Отображение всего списка ДР (дополнительные возможности, такие как сортировка, выделение текущих и просроченных и т.п. - остаются на усмотрение реализующего)
• Отображение списка сегодняшних и ближайших ДР (дополнительные возможности, такие как сортировка, выделение текущих и просроченных и т.п. - остаются на усмотрение реализующего)
• Добавление записей в список ДР
• Удаление записей из списка ДР
• Редактирование записей в списке ДР
Его уровень "сложности" следующий:
Уровень 4: SPA веб-приложение, сервер предоставляет АПИ (ASP.NET Core Web API), информация хранится в объектах, персистентность которых реализуется с помощью использования БД. Корневая страница выводит список сегодняшних и ближайших ДР, остальная функциональность доступна на отдельных страницах, ссылки на которые ведут с корневой. Необходимо реализовать хранение и отображение фотографий именинников.
Однако! Хранение и отображение фотографий не реализовано.

От автора кода: Я долго бился над задачей хранения и отображения фото, но так и не смог добиться результата из-за недостаточного знания .NetCore и С#. В сущности задача сводится к 
следующему: создать в баазе данных поле типа картинка(image) для хранения и отображения её или же создать поле текстовое(string) где бы хранился адрес картинки, а саму её хранить в папке приложения. Для начала на форме Create следовало бы создать кнопку выбора файла и написать обработчик который бы сохранял файл и показывал бы его где надо но вот этого я ни найти ни написать не смог( Надеюсь в будущем исправить.
