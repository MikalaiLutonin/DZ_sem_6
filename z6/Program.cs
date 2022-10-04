//  // ==========Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  // 0, 7, 8, -2, -2 -> 2
//  // 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Сколько чисел вы будете вводить? ");
// int col = 0;                                        //количество чисел больше 0 по умолчанию присваиваем 0.
// int[] M = new int[int.Parse(Console.ReadLine()!)];  //создали новый массив и определили размер массива с клавиатуры

// for (int i = 0; i < M.Length; i++)                  // заполнение массива с клавиатуры
// {
//     M[i] = int.Parse(Console.ReadLine()!);
// }


// for (int i = 0; i < M.Length; i++)                  // счетчик количества чисел > 0
// {
//     if (M[i] > 0)
//     {
//         col++;
//     }
// }

// Console.WriteLine($"Вы ввели {col} чисел, которые больше 0");





// =========== Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Уравнение первой прямой y = k1 * x + b1");
Console.Write("Введите коэффициент k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b1: ");
double b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("\nУравнение второй прямой y = k2 * x + b2");
Console.Write("Введите коэффициент k2: ");
double k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b2: ");
double b2 = int.Parse(Console.ReadLine()!);


double delt = (k1 * (-1)) - (k2 * (-1));
double delt_x = ((-b1) * (-1)) - ((-b2) * (-1));
double delt_y = (k1 * (-b2)) - (k2 * (-b1));

double X = delt_x / delt;
double Y = delt_y / delt;

Console.Write($"\nТочка пересечения двух прямых: ({X:f1}; {Y:f1})");





