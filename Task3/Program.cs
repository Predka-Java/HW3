// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int x) {
    double res = 0;
    for (int i = 1; i < x + 1; i++)
    {
        res = Math.Pow(i, 3);
        Console.Write(res + " ");
    }
}

int EnterData(string text) 
{
    Console.WriteLine(text);
    int n = int.Parse(Console.ReadLine());
    return(n);
 }



int x = EnterData("Введите число: ");
Console.WriteLine("Таблица квадратов чисел от 1 до " + x + ": ");
Cube(x);