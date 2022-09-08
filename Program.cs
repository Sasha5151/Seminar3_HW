﻿// Урок 3. Массивы и функции в программировании

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     return Convert.ToInt32 (value);
// }

// string N = Prompt ("Введите число : ");
// string S = N.ToString();
// char[] ar = S.ToCharArray();
// Array.Reverse(ar);
// S = new String(ar);
// N = Convert.ToInt32(S);
// if (S == N )
//     {
//     System.Console.WriteLine($"Число {N} являеться палиндромом");
//     }



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
