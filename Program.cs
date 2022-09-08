// Урок 3. Массивы и функции в программировании

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckN(string number)
{
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number.Length == 5)
{
  CheckN(number);
}
else Console.WriteLine($"Введи правильное число");



//End
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     return Convert.ToInt32(value);
// }
// int[] InputCoords(int n)
// {
//     int[] Coord = new int[3];
//     Coord[0] = Prompt($"Введите координаты {n} точки Х : ");
//     Coord[1] = Prompt($"Введите координаты {n} точки Y : ");
//     Coord[2] = Prompt($"Введите координаты {n} точки Z : ");
//     return Coord;
// }
// int Sqr(int n)
// {
//     return n * n;
// }
// int[] Coord1 = InputCoords(1);
// int[] Coord2 = InputCoords(2);

// double result = Math.Sqrt(Sqr(Coord2[0] - Coord1[0]) + Sqr(Coord2[1] - Coord1[1]) + Sqr(Coord2[2] - Coord1[2]));
// System.Console.WriteLine(result);

//End

// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     return Convert.ToInt32(value);
// }

// int N = Prompt("Введите число :");
// for (int count = 1 ; count <= N ; count++)
// {
//     int result = count*count*count;
//     System.Console.Write($"{result} , ");
// }

//End