// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число:");
// string number = Console.ReadLine(); 
// int length = number.Length;
// if (length == 5)
// {
// if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"да, число {number} - полином");
//     }
//     else
//     {
//      Console.WriteLine($"да, число {number} - НЕ полином");   
//     }
// }
//  else
// {
// Console.WriteLine($"Число {number} - НЕ пятизначное");     
// }


// else Console.Write("нет, данное число - НЕполином");
// && (number%100 == number / 1000)
// number.%10 == number / 10000
// else if ((number%10 != number / 10000) && (number%100 != number / 1000))
// {
// 
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату х1: "); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату y1: "); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату z1: "); 
// int z1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату x2: "); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату y2: "); 
// int y2 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату z2: "); 
// int z2 = Convert.ToInt32(Console.ReadLine()); 
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); 
// Console.WriteLine($"Расстояние между 2 точками: {x1},{y1},{z1} {x2},{y2},{z1} = {Math.Round(d,2)}");




// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N:"); 
// int finish = Convert.ToInt32(Console.ReadLine()); // Идем от 1 до N: [1;N]  
// int start = 1; // start -> finish  
// while (start <= finish) 
// {     
//     Console.Write(Math.Pow(start,3) + " ");     
//     start++; // start++ => start = start + 1 // start += 1
// }
