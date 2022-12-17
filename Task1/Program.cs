// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Palindrome(string n) {
    if(n[0] == n[4]&& n[1] == n[3]) Console.WriteLine("Да");
    else Console.WriteLine("нет");
}
string EnterData(string text) 
{
    Console.WriteLine(text);
    string n = Console.ReadLine();
    return(n);
 }

 string x = EnterData("Введите пятизначное число: ");
 Palindrome(x);
 
