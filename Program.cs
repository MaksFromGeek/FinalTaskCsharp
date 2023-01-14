// Итоговая задача. Напишите программу, которая из имеющегося массива строк форvирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

string[] firstArray = {"goodbye", "last", "live", "hi", "app"};
string[] secondArray = new string [firstArray.Length];



void FindWords(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for(int i = 0; i < firstArray.Length; i++)
        if(firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
}


