//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

//введите число
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a3 = number /10 % 10;
int a4 = number % 10;
int result = a4 * 10 + a3;
if (result == number / 1000)
{
  Console.WriteLine($"число {number} является палиндромом");
}
else Console.WriteLine($"число {number} не является палиндромом");
