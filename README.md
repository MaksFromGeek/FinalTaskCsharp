## Итоговая задача. 

Напишите программу, которая из имеющегося массива строк форvирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
обойтись исключительно массивами.
## Описание алгоритма решения задачи.

1) Создаются два массива строк, вносятся записи в первый массив, второй массив обозначается 
как длина всех записей первого массива
2) Для решения используется простая функция, с помощью оператора if производим проверку длин наших 
слов на соответствие условию <= 3
3) При выполнении условия, записываем соответствующие слова во второй массив с помощью счетчика
4) После добавления одного из слов во второй массив программа вновь проходит через цикл, 
проверяя следующее слово на соответствие условию, пока не проверит все элементы.
