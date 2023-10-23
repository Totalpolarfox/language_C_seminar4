//
//  Cычeв B.B.
//
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.Write(message);      // Вывод {message} в console.
    string value = Console.ReadLine();  // Запрашиваем у пользователя ввод данных, записываем значение в {value}
    return int.Parse(value);            // Преобразовываем полученные данные в int, и возвращаем значение
}

int raiseDegree (int numA, int numB)
{
    int result = 1;                     // Начальное значение для вычислений
    for (int i = 0; i < numB; i++)
    {
        result = numA * result;         
    }
    return result;
}

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите положительное число B: ");

if (numberB > 0)                        // Условия для проверки натурального числа
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = {raiseDegree(numberA, numberB)}");
}
else Console.WriteLine ($"Число {numberB} введено неверно. Введите положительное число.");