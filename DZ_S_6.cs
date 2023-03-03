//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
/*Console.WriteLine("Введите количество чисел, которое Вы будете вводить:");
int size = Convert.ToInt32(Console.ReadLine());//Определяем величину массива
int count = 0;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите число от -1000 до 1000");
    array[i] = Convert.ToInt32(Console.ReadLine());// ВВодим числа 
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($" Вы ввели {count} положительных числа");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*int size = 10;
Console.WriteLine("Введите два коэфицента для первой прямой");// Вводим коэфиценты для первой прямой
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите два коэфицента для второй прямой");// Вводим коэфициэнты для второй прямой
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

for (double x = 0; x < size; x = x + 0.1)
{
    if (k1 * x + b1 == k2 * x + b2)
    {
        Console.WriteLine($"Точка пересечения двух прямых имеет координаты: {x};{(k1 * x + b1)}");
    }
}
for (double x = 0; x < size; x = x - 0.1)
{
    if (k1 * x + b1 == k2 * x + b2)
    {
        Console.WriteLine($"Точка пересечения двух прямых имеет координаты: {x};{(k1 * x + b1)}");
    }
}
Console.WriteLine("Точки пересечения двух прямых не обнаружено");
*/