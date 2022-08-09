// Задача 11: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число = {number}");
int a = number / 100;
int b = number % 10;
int res = a * 10 + b;
Console.WriteLine($"Результат = {res}");