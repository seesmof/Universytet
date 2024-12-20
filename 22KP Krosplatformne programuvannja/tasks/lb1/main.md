## Контрольні питання

### Що таке HTCondor?

HTCondor - це система високопропускних обчислень (HTC), яка дозволяє розподілено обробляти завдання через мережу комп'ютерів. Вона призначена для обробки великомасштабних, паралельних і розподілених обчислювальних завдань, що робить її корисною для наукових досліджень та інших застосувань, які вимагають значних обчислювальних ресурсів.

### Мета використання проміжного програмного забезпечення

Метою використання проміжного програмного забезпечення в HTCondor є полегшення комунікації між різними компонентами системи. Проміжне програмне забезпечення виконує роль сполучної ланки, дозволяючи виконувати завдання, планувати їх виконання та розподіляти роботу по мережі. Воно керує ресурсами, визначає пріоритетність завдань і гарантує, що завдання виконуються ефективно.

### Які необхідно запустити команди для роботи HTCondor?

Щоб запустити HTCondor, зазвичай потрібно встановити програмне забезпечення HTCondor на локальній машині і на всіх віддалених машинах, які будуть використовуватися для обчислень. Після цього слід запустити служби HTCondor, які є фоновими процесами, що керують системою. Конкретні команди для запуску HTCondor можуть відрізнятися залежно від операційної системи і конкретних налаштувань, але, як правило, слід використовувати такі команди, як condor_startup для запуску сервісів і condor_submit для створення завдань.

### Які існують аналоги HTCondor?

Аналогами HTCondor є інші обчислювальні системи з високою пропускною здатністю, такі як Sun Grid Engine (SGE), LSF та PBS Pro. Ці системи також надають можливості розподілених обчислень і використовуються для подібних цілей, таких як запуск великомасштабних симуляцій або обробка великих наборів даних.

## Додаткові нотатки

- pool name - `main`
- before installing HTCondor on VM install [Microsoft Visual C++](https://aka.ms/vs/17/release/vc_redist.x64.exe) and [Java](https://www.java.com/en/download/)
- for installing gcc use this [site](http://www.equation.com/servlet/equation.cmd?fa=fortran) and this link for [direct download](http://www.equation.com/ftpdir/gcc/gcc-13.2.0-64.exe)

## Виконання роботи

- server
  - installing vm
    - name server
    - iso - C:\Users\seesm\Downloads\Windows.iso
    - user - qe
    - pass - 1313
    - guest addition yes
    - memory - 4096
    - cpu - 4
