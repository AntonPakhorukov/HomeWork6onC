/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Дополнительная задача (45): Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, 
или вправо на 1 позицию.
[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Дополнительная задача 2 (47): Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов 
с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.

[1,2,3,3] -> [1,2,3,4]
*/
Console.Clear();
int GetSizeArray()
{
    Console.Write("Введите размер массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(min, max);
    }
    return newArray;
}
int GetPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int[] GetNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
Console.Write("Введите номер задачи: ");
int task = int.Parse(Console.ReadLine());
switch (task)
{
    case 41:
        Task41();
        break;
    case 43:
        Task43();
        break;
    case 45:
        Task45();
        break;
    case 47:
        Task47();
        break;
}

void Task41()
{
    /*
    Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
    Console.Clear();
    Console.Write("Числа хотите задать в ручную(1) или рандомно(2)? ");
    int value = Convert.ToInt32(Console.ReadLine());
    switch (value)
    {
        case 1:
            Example1();
            break;
        case 2:
            Example2();
            break;
    }
    void Example1()
    {
        Console.Write("Какое количество чисел хотите ввести?: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        array = GetNumbers(array);
        Console.Clear();
        Console.WriteLine("[" + String.Join(", ", array) + "]");
        int result = GetPositiveNumber(array);
        Console.WriteLine(result);
    }
    void Example2()
    {
        Console.Write("Какое количество чисел хотите ввести?: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        int[] array = GetRandomArray(size, -10, 10);
        Console.WriteLine("[" + String.Join(", ", array) + "]");
        int result = GetPositiveNumber(array);
        Console.WriteLine(result);
    }
}
void Task43()
{
    /*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
    Console.Clear();
    Console.Write("Введите переменную b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите переменную k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите переменную b2: ");
    double b2 = double.Parse(Console.ReadLine());
    Console.Write("Введите переменную k2: ");
    double k2 = double.Parse(Console.ReadLine());
    if (k2 == k1)
    {
        Console.WriteLine("Точки пересечения нет, отрезки параллельны");
        return;
    }
    double x = GetNumberX(b1, b2, k1, k2);
    double GetNumberX(double b1, double b2, double k1, double k2)
    {
        double x = 0;
        x = (b2 - b1) / (k1 - k2);
        return x;
    }
    double y = k2 * x + b2;
    Console.WriteLine("(" + x + "; " + y + ")");
}
void Task45()
{
    /*
    Дополнительная задача (45): Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, 
или вправо на 1 позицию.
[8, 5, 1, 7, 0] - 
[5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - 
[0, 8, 5, 1, 7] - сдвиг вправо
*/
    int size = GetSizeArray();
    int[] array = GetRandomArray(size, 0, 10);
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    Console.Write("Массив сдвинуть вправо(1) или влево(2): ");
    int shift = Convert.ToInt32(Console.ReadLine());
    switch (shift)
    {
        case 1:
            Shift1();
            break;
        case 2:
            Shift2();
            break;
    }
    void Shift1()
    {
        int[] GetRightShift(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i + 1] = array[i];
            }
            newArray[0] = array[array.Length - 1];
            return newArray;
        }
        array = GetRightShift(array);
        Console.WriteLine("[" + String.Join(", ", array) + "]");
    }
    void Shift2()
    {
        int[] GetLeftShift(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }
            newArray[newArray.Length - 1] = array[0];
            return newArray;
        }
        array = GetLeftShift(array);
        Console.WriteLine("[" + String.Join(", ", array) + "]");
    }
}
void Task47()
{
    /*
    Дополнительная задача 2 (47): Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов 
с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.

[1,2,3,3] -> [1,2,3,4]
*/
    Console.Clear();
    int size = GetSizeArray();
    Console.Write("Хотите массив задаять рандомно(1) или в ручную(2)");
    int example = int.Parse(Console.ReadLine());
    switch (example)
    {
        case 1:
            Example1();
            break;
        case 2:
            Example2();
            break;
    }
    void Example1()
    {
        int[] array = GetRandomArray(size, 0, 10);
        Console.WriteLine("[" + String.Join(", ", array) + "]");
        int[] GetResult(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1]) array[i + 1] = array[i + 1] + 1;
            }
            return array;
        }
        array = GetResult(array);
        Console.WriteLine("[" + String.Join(", ", array) + "]");
    }
    void Example2() {
        int[] array = new int[size];
        array = GetNumbers(array); 
        Console.WriteLine("[" + String.Join(", ", array) + "]");
        int[] GetResult(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1]) array[i + 1] = array[i + 1] + 1;
            }
            return array;
        }
        array = GetResult(array);
        Console.WriteLine("[" + String.Join(", ", array) + "]");
    }
}