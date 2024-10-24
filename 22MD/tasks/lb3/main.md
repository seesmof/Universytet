# Поліноміальна апроксимація та методи точкового оцінювання

## Мета роботи

Вивчити методи пошуку оптимуму з використанням квадратичної апроксимації й точкового оцінювання; навчитися застосовувати метод Пауела для оптимізації об'єктів керування.

## Постановка задачі

$\displaystyle (x-2)^2 \space in \space [-1,3]$

## Результати виконання

## Висновки

Таким чином, ми вивчили методи пошуку оптимуму з використанням квадратичної апроксимації й точкового оцінювання; а також навчилися застосовувати метод Пауела для оптимізації об'єктів керування.

## Контрольні питання

### У чому полягає основна ідея методів поліноміальної апроксимації й точкового оцінювання?

Основна ідея методів поліноміальної апроксимації полягає в тому, щоб представити складну функцію у вигляді полінома, з яким легше працювати. Це робиться шляхом знаходження полінома, який якомога ближче підходить до функції на інтервалі, що нас цікавить. Точкові методи оцінки, з іншого боку, використовуються для отримання єдиного "найкращого" прогнозу деякої величини, що нас цікавить. Наприклад, метод найменших квадратів, який мінімізує суму квадратів залишків, може бути використаний для оцінки параметрів поліноміальної апроксимації.

### Сформулюйте необхідні умови ефективної реалізації методу пошуку, заснованого на поліноміальній апроксимації.

Для того, щоб метод пошуку, заснований на поліноміальній апроксимації, був ефективним, зазвичай потрібно виконати декілька умов:

- Функція, що апроксимується, повинна бути добре керованою, тобто гладкою і неперервною на інтервалі, що нас цікавить.
- Степінь полінома повинен бути обраний належним чином. Занадто низький степінь полінома може погано відображати поведінку функції, в той час як занадто високий степінь полінома може надмірно підганяти дані.
- Точки, в яких оцінюється функція (для побудови полінома), слід вибирати з розумом. Вони повинні покривати інтервал, що нас цікавить, але водночас не бути надто близько одна до одної, щоб уникнути числової нестабільності.

### По заданих точках і відповідних значеннях функції виведіть формули для оцінки параметрів апроксимуючого квадратичного полінома й оцінки координати точки оптимуму.

За заданими точками $(x_1, y_1), (x_2, y_2), (x_3, y_3)$ та відповідними значеннями функції можна оцінити параметри $a$, $b$ та $c$ апроксимуючого квадратичного полінома $y = ax^2 + bx + c$ за допомогою системи рівнянь:

$$
\begin{align*}
a{x_1}^2 + b{x_1} + c &= y_1, \\
a{x_2}^2 + b{x_2} + c &= y_2, \\
a{x_3}^2 + b{x_3} + c &= y_3.
\end{align*}
$$

Цю систему можна розв'язати за допомогою таких методів, як виключення Гауса або правило Крамера.

Маючи параметри $a$, $b$ і $c$, ми можемо знайти координати точки оптимуму (тобто мінімум або максимум полінома), прирівнявши похідну полінома до нуля і розв'язавши для $x$, що дає $x_{\text{opt}} = -\frac{b}{2a}$.
