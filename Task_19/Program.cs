// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string len = Convert.ToString(number);
int len1 = len.Length;
if (len1 == 5)
{
    if (len[0] == len[4] && len[1] == len[3])
    {
        System.Console.WriteLine(+number+ " - Палиндром");
    }
    else
    {
        System.Console.WriteLine(+number+ " - Не палиндром");
    }
}
else
{
 System.Console.WriteLine(+number+ " - Не является пятизначным числом");
}
