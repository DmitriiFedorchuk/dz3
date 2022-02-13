///Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine();
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int x = a;
int y = b;
bool XY = x != a || y == b;
bool noXY = XY != true;
bool noXnoY = x != a | y != b;
Console.WriteLine(noXnoY);
Console.WriteLine(noXY);
if (noXY == noXnoY) Console.WriteLine("Истина");
else Console.WriteLine("Ложь");
Console.WriteLine();



///Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4");
int numQuarter = int.Parse(Console.ReadLine());
string range = "";
string num = "";

if (numQuarter == 1) range = "x > 0, y > 0";
else if (numQuarter == 2) range = "x < 0, y > ";
else if (numQuarter == 3) range = "x < 0, y < 0";
else range = "x > 0, y < 0";

Console.WriteLine($"Для {numQuarter}-й четверти координаты точки должны быть заданы в диапазоне ( {range} )");
Console.WriteLine();


// 24. Найти кубы чисел от 1 до N

int n = new Random().Next(0,12);
int[] cubDigit (int n)
{
    int[] cubs = new int[n];
    int number = 1;
    for (int i = 0; i < n; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}
void cubDigit1(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}
int[] table = cubDigit(n);
cubDigit1 (table);

