//
//  Cычeв B.B.
//
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string message)
{
    System.Console.Write(message);      // Вывод {message} в console.
    string value = Console.ReadLine();  // Запрашиваем у пользователя ввод данных, записываем значение в {value}
    return int.Parse(value);            // Преобразовываем полученные данные в int, и возвращаем значение
}

int[] createArray(int length, int minValue, int maxValue)   // метод для создания массива размером {length} и значениями от {minValue} до {maxValue}
{
    int[] array = new int [length];                         // создаем пустой массив {array} 
    Random random = new Random();                           // создание генератора случайных числел
    for (int i = 0; i < array.Length; i++)                  // заполнение массива  случайными числами
    {
        array[i] = random.Next(minValue, maxValue);         // заполнение текущего элемента массива случайными числом в диапазоне (minValue, maxValue)
    }
    return array;
}

void printArray(int[] array)                // метод вывода массива
{
    foreach (var item in array)             // способ вывода массива (все ячейки внутри массива - item) (удобно при работе с коллекциями и массивами)
    {
        Console.Write(item + " ");
    }
}

int minValue = ReadInt("Введите минимальное значение чисел в массиве: ");
int maxValue = ReadInt("Введите максимальное значение чисел в массиве: ");
int length = ReadInt("Укажите длину массива: ");
int[] array = createArray(length, minValue, maxValue);
printArray(array);

