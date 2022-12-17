// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double CountingResult(double x1, double y1, double z1, double x2, double y2, double z2) {
     double res = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 3) + Math.Pow((y2 - y1), 3) + Math.Pow((z2 - z1), 3)),2);
     return(res);

}

double EnterData(string text) 
{
    Console.WriteLine(text);
    double num = double.Parse(Console.ReadLine());
    return(num);
 }

 string EnterName(string text) {
    Console.WriteLine(text);
    string name = Console.ReadLine();
    return(name);
 }
 Console.Clear();
string name1 = EnterName("Введите имя первой точки: ");
double x1 = EnterData("Введите координату X: ");
double y1 = EnterData("Введите координату Y: ");
double z1 = EnterData("Введите координату Z: ");

Console.WriteLine();

string name2 = EnterName("Введите имя второй точки: ");
double x2 = EnterData("Введите координату X: ");
double y2 = EnterData("Введите координату Y: ");
double z2 = EnterData("Введите координату Z: ");





double res = CountingResult(x1, y1, x2, y2, z1, z2);
Console.WriteLine("Расстояние между точками " + name1 + " и " + name2 + " в трехмерном пространстве равно: " + res);