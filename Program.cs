/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равно 3. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
*/

Console.Clear();

string[] initialArray = { "123", "test", "London", "Q", ":-)" };

string[] resultArray = new string[initialArray.Length];

printArray(NewArray(initialArray));

void printArray(string[] array) // Выводим массив на экран
{
    System.Console.WriteLine(string.Join(" ", array));
}

string[] NewArray(string[] array) // Создаем новый массив, в котором длинна строк меньши или равна 3 в исходном массиве
{
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];

        if (temp.Length <= 3)
        {
            resultArray[j] = temp;
            j++;
        }
    }
    return resultArray;
}