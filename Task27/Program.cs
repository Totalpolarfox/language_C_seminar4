//
//  Cычeв B.B.
//
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.Write(message);      // Вывод {message} в console.
    string value = Console.ReadLine();  // Запрашиваем у пользователя ввод данных, записываем значение в {value}
    return int.Parse(value);            // Преобразовываем полученные данные в int, и возвращаем значение
}

int summNumber(int numberA)            // метод подсчета суммы цифр в числе
{
    int summ = 0;
    while (numberA > 0)
    {
        summ = summ + numberA % 10;
        numberA = numberA / 10;
    }
    return summ;
}

int number = ReadInt("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {number} = {summNumber(number)}");
