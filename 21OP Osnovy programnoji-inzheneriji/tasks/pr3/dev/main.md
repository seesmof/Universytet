# Архіватори та пакувальники

## Мета роботи

Вивчити принципи безивтратного архівування та пакування бінарних даних та дослідити функції роботи з найпопулярнішими застосунками для стиснення даних, навчитися їх практичному використанню.

## Завдання до роботи

- Використовуючи всесвітню мережу Інтернет, знайти розгорнуту інформацію щодо методів архівування, стиснення, підрахунку контрольної суми, шифрування вмісту архіву, тощо.
- Знайти та встановити актуальні версії наведених нижче архіваторів
  - 7-zip
  - WinRAR
- Дослідити процеси додавання файлів до архіву та вилучення з нього, відтворити та деталізувати алгоритми цих процесів
- Провести практичну апробацію тестового архівування та розархівування даних у режимі командного рядку для обидвох архіваторів.
- Вивчити найпоширеніші параметри (ключі або опції) для роботи з архівами

## Результати виконання роботи

### Визначення термінів

**Методи архівування**: Архівація - це процес збору та зберігання даних або файлів в архівному файлі. Архівний файл може бути одним файлом, який містить кілька файлів і папок всередині. Існують різні формати архівів, такі як GZ (GZip) і Zip. GZip використовує алгоритм стиснення Deflate для стиснення заархівованих файлів, а також підтримує передачу файлів, що складаються з кількох частин. Zip, з іншого боку, використовує алгоритм Deflate і підтримує стиснення без втрат. Він також підтримує шифрування AES і DES.

**Стиснення**: Стиснення - це метод, який використовується для зменшення розміру файлів або даних без втрати вихідної інформації. Існують різні алгоритми стиснення, такі як LZMA/LZMA2 і PPM. LZMA (алгоритм ланцюга Лемпеля-Зіва-Маркова) - це алгоритм стиснення даних без втрат, який використовує алгоритм словникового стиснення для кодування даних. PPM (Prediction by partial matching) - це статистичний метод стиснення даних, який використовує набір попередніх символів у нестисненому потоці символів для передбачення наступного символу в потоці.

**Обчислення контрольних сум**: Контрольні суми - це математичні значення, які обчислюються на основі вмісту файлу для виявлення будь-яких змін або помилок. Коли файл створюється і створюються його копії, файл завжди має однаковий хеш-код. Якщо змінюється хоча б один біт інформації у файлі, генерується інший хеш-код/контрольна сума. Типовими алгоритмами контрольних сум є MD5, SHA-1, SHA-256 і SHA-512.

**Шифрування вмісту архіву**: Шифрування перетворює вміст файлу в нечитабельну форму для захисту його конфіденційності. Існують різні алгоритми шифрування, такі як DES (Data Encryption Standard), AES (Advanced Encryption Standard) і Blowfish. DES використовує приватні секретні ключі для шифрування та розшифрування даних. AES - це алгоритм шифрування, який використовується американськими агентствами для захисту конфіденційних даних. Алгоритм шифрування Blowfish шифрує архіви з 64-бітним розміром блоку і змінною довжиною ключа від 32 до 448 біт.

### Робота з архіваторами

> Images of me completing the task

#### Алгоритм архівації 7-Zip

7-Zip використовує LZMA (алгоритм ланцюга Лемпеля-Зіва-Маркова) і LZMA2, які є алгоритмами стиснення даних без втрат. Ці алгоритми використовують схему стиснення за допомогою словника, який кодує вхідні дані. Розмір словника в 7-Zip можна змінювати для отримання оптимальних результатів. Формат LZMA2 підтримує багатопотоковість, що означає, що він може використовувати кілька ядер/процесорів для стиснення і розпакування.

Процес створення архіву в 7-Zip складається з наступних кроків:

1. Вибрані файли або папки зчитуються 7-Zip.
2. Далі дані кодуються за допомогою алгоритму LZMA або LZMA2.
3. Стиснуті дані записуються у файл .7z.

Процес розпакування архіву в 7-Zip складається з таких кроків:

1. Файл .7z зчитується програмою 7-Zip.
2. Далі стиснуті дані розпаковуються за допомогою алгоритму LZMA або LZMA2.
3. Розпаковані дані записуються у файли або папки.

#### Алгоритм архівації WinRAR

WinRAR використовує власний алгоритм стиснення, оптимізований для мультимедійних даних. Він підтримує різні формати стиснення, зокрема RAR, ZIP, CAB, ARJ, LZH, ACE, TAR, GZip, UUE, ISO, BZIP2, Z і 7-Zip.

Процес створення архіву у WinRAR складається з таких кроків:

1. Вибрані файли або папки зчитуються WinRAR.
2. Далі дані стискаються за допомогою власного алгоритму.
3. Стиснуті дані записуються у файл .rar або .zip.

Процес розпакування архіву в WinRAR складається з таких кроків:

1. Файл .rar або .zip зчитується програмою WinRAR.
2. Далі стиснуті дані розпаковуються за допомогою власного алгоритму.
3. Розпаковані дані записуються у файли або папки.

### Тестове архівування та розархівування в командному рядку

> Images of me completing the task

### Найпоширеніші параметри для роботи з архівами

#### Параметри 7-Zip

7-Zip використовує ключі командного рядка для визначення параметрів процесу архівації. Нижче наведено деякі з найбільш поширених:

- -t вказує тип архіву. Наприклад, -tzip для ZIP-архівів, -t7z для 7z-архівів.
- -m задає метод стиснення. Наприклад, -m0=lzma для використання методу LZMA.
- -mx задає рівень стиснення, від 0 (без стиснення) до 9 (ультра-стиснення). Наприклад, -mx=9 для максимального стиснення.
- -mfb задає кількість швидких байт для LZMA. Наприклад, -mfb=64.
- -md задає розмір словника. Наприклад, -md=32m для словника розміром 32 мегабайти.
- -ms вмикає або вимикає опцію створення цілісного архіву. Наприклад, -ms=увімкнути, щоб увімкнути створення цілісних архівів.

Наприклад, для створення 7z-архіву з максимальним стисненням методом LZMA вам слід скористатися такою командою: `7z a -t7z -m0=lzma -mx=9 -mfb=64 -md=32m -ms=on archive.7z dir1`

#### Параметри WinRAR

WinRAR також використовує ключі командного рядка для визначення параметрів. Ось деякі з найбільш поширених опцій:

- -af вказує формат архіву. Наприклад, -afzip для ZIP-архівів.
- -m задає рівень стиснення, від 0 ( збереження) до 5 (найкраще). Наприклад, -m5 для максимального стиснення.
- -s створює цілісні архіви.
- -ma задає версію алгоритму RAR для використання. Наприклад, -ma5 для використання RAR5.
- -p встановлює пароль до архіву. Наприклад, -pMyPassword, щоб встановити пароль "MyPassword".

Наприклад, для створення архіву RAR5 з максимальним стисненням і захистом паролем можна скористатися наступною командою: `WinRAR a -afzip -m5 -s -ma5 -pMyPassword archive.rar dir1`

Важливо зазначити, що це лише деякі з найпоширеніших параметрів. Як 7-Zip, так і WinRAR пропонують широкий спектр можливостей для тонкого налаштування процесу архівації, і більш детальну інформацію можна знайти у відповідній документації.

## Висновки

Таким чином, ми вивчили принципи безивтратного архівування та пакування бінарних даних та дослідили функції роботи з найпопулярнішими застосунками для стиснення даних, а також навчилися їх практичному використанню.

### Контрольні питання

#### Що таке Архіватор?

Архіватор - це тип комп'ютерного програмного забезпечення, який об'єднує кілька файлів в один архівний файл або серію архівних файлів для полегшення транспортування або зберігання. Архіватори також можуть надавати опції шифрування, розбиття файлів на частини, контрольні суми, саморозпакування та самоінсталяції.

#### Деталізація понять Архівування, Пакування, Стиснення

Архівація - це процес збору та зберігання даних або файлів в архівному файлі. З іншого боку, пакування - це процес збору декількох файлів або каталогів в один файл. Стиснення - це метод, який використовується для зменшення розміру файлів або даних без втрати вихідної інформації, що особливо корисно для економії місця на диску і прискорення передачі файлів.

#### Призначення програм-архіваторів

Програми-архіватори служать для різних цілей. Насамперед їх використовують для зменшення розміру файлів або груп файлів, щоб заощадити місце на диску - процес, відомий як стиснення. Вони також дозволяють легко транспортувати кілька файлів, оскільки можуть упаковувати численні файли в один архів. Крім того, вони можуть надавати функції безпеки, такі як захист паролем або шифрування для захисту конфіденційних даних.
