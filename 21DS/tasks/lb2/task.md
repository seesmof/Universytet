- Розроблюваний програмний проєкт має складатися з окремих класів, що реалізують структури даних геш-таблиця та бінарне дерево пошуку, а також має містити окремий модуль, що забезпечує інтерфейсну взаємодію з користувачем для роботи зі створеними класами.
- Клас, що реалізує геш-таблицю, має дозволяти виконувати наступні операції на основі окремих методів: вставлення елементу, видалення елементу, пошук елементу, відображення структури геш-таблиці на основі використання параметрів, обраних у відповідності з варіантом індивідуального завдання
- Клас, що реалізує B-дерево, має дозволяти виконувати наступні операції на основі окремих методів: створення порожнього дерева, відображення структури дерева, пошук у дереві, вставлення ключа, видалення ключа.
- Створити геш-таблицю, що використовує метод ланцюжків для розв’язання колізій та геш-функцію множення. Геш-таблицю заповнити на основі виділення інформації з текстового файлу, в якому містяться прізвища, ім’я і по батькові співробітників фірми та займані ними посади. Визначити посаду заданого співробітника.
- Мобільний оператор повинен мати інформацію про абонентів для забезпечення послуг. Кожний абонент характеризується номером, прізвищем, ім’ям, по батькові, тарифним планом. Сформувати дерево з відповідної інформації про абонентів, забезпечити пошук інформації про абонента за його телефонним номером та визначення кількості підключень за кожним з тарифів.

---

#### Що розуміють під гешуванням?

Гешування - це метод, який використовується в комп'ютерних науках для зіставлення даних довільного розміру зі значеннями фіксованого розміру. Він передбачає застосування геш-функції до вхідних даних, яка генерує унікальний геш-код або геш-значення. Геш-код використовується як індекс для зберігання або пошуку даних у структурі даних, яка називається геш-таблицею.

#### За яких умов слід використовувати геш-таблиці?

Геш-таблиці найчастіше використовуються, коли є потреба в ефективному пошуку та зберіганні даних. Вони особливо корисні в ситуаціях, коли набір даних великий і потрібно мінімізувати часову складність таких операцій, як пошук, вставка та видалення. Геш-таблиці також корисні, коли потрібно пов'язати пари ключ-значення, оскільки вони забезпечують швидкий доступ до значень на основі їхніх ключів.

#### Що таке геш-функція та які висуваються вимоги до геш-функцій?

Геш-функція - це математична функція, яка отримує вхідні дані (або ключ) і видає вихідні дані фіксованого розміру (або геш-код). Основне призначення геш-функції - генерувати унікальний геш-код для кожного унікального входу, гарантуючи, що різні вхідні дані створюють різні геш-коди. Вимоги до хорошої геш-функції включають

- Детермінованість: При однакових вхідних даних геш-функція повинна завжди генерувати однаковий результат.
- Рівномірний розподіл: Геш-функція повинна рівномірно розподіляти геш-коди по всьому діапазону можливих геш-значень, мінімізуючи колізії.
- Ефективність: Геш-функція повинна бути обчислювально ефективною для обчислення геш-коду.
- Мінімальна кількість колізій: Колізії виникають, коли два різних вхідних значення дають однаковий геш-код. Хоча повністю усунути колізії неможливо, хороша геш-функція повинна мінімізувати кількість колізій, щоб підтримувати ефективність геш-таблиці.

Ці вимоги гарантують, що геш-функція забезпечує хороший баланс між унікальністю геш-кодів і ефективним пошуком даних у геш-таблиці.