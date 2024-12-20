# Використання функціонального програмування для побудови програмної системи

## Мета

Ознайомитися з основними особливостями функціональної парадигми програмування та особливостями її реалізації в мові програмування Python.

Навчитися розробляти програми мовою програмування Python на основі використання парадигми функціонального програмування.

## Завдання

- Вивести всі коректні комбінації пар круглих дужок, які можна сформувати з n дужок, що закриваються і відкриваються. Наприклад, коректна комбінація (()()), некоректна (()))(. Кількість дужок задається користувачем
  - function calls
  - lambda functions
  - recursion, no loops, no ifs, no assignments, no flow control operators except `return`
  - ALSO, solve second time using imperative programming
- Визначити кількість слів у тексті, що зберігається у файлі, та довжину найкоротшого слова. Слова відділяються одне від одного не тільки пробілами, але й будь-якими знаками пунктуації
  - same as first but prioritize `map`, `reduce`, `filter`, etc

## Контрольні питання

### Яким чином виконати форматування рядка?

Форматувати рядок у Python можна за допомогою методу format() або f-рядків (форматованих рядкових літералів). Наприклад, з допомогою f-рядка:

```python
ймення = "Микола"
вік = 30
форматований_рядок = f"Мене звати {ймення} і мені {вік} років"
```

### Які дії можна виконувати над переліками?

Списки в Python є змінюваними, що означає, що над ними можна виконувати різні дії, такі як:

- Додавання елементів (append(), extend(), insert())
- Видалення елементів (remove(), pop(), clear())
- Пошук елементів (index(), ключове слово in)
- Підрахунок елементів (count())
- Сортування (sort())
- Реверсування (reverse())

### Що таке множина та яким чином її визначити?

Множина - це невпорядкована колекція унікальних елементів. Визначити множину в Python можна за допомогою фігурних дужок {} або функції set(). Наприклад:

```python
довільна_множина = {1, 2, 3}
# або з допомогою функції set()
довільна_множина = set([1, 2, 3])
```
