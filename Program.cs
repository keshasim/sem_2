// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//  Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >100 && number <1000)
// {
// int result = number / 10 % 10;
// Console.WriteLine( $"В числе {number} второе число {result}" );
// }
// else 
// {
//   Console.WriteLine( $"Вы ввели не трехзначное число, повторите ввод пожалуйста" );  
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int counter = 0;
//  while (number > 999)
// {
//   number /= 10;
//   counter++;
// }
// if (number >= 100 && number < 1000)
//   {
//     int result = number % 10;
//     Console.WriteLine($"Третья цифра: {result}");
//   }
// if (number <= 99)
//   {
//     Console.WriteLine("Третьей цифры нет");
//   }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine()); 
// if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("Этот день выходной");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это вообще не день недели");
//   }
//   else Console.WriteLine("Этот день рабочий");
