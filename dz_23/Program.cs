//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число:");
var num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{                                //возводим в куб
    Console.WriteLine(Math.Pow(i,3));
}



//через вайл


Console.Write("Введите число ");
var number = Convert.ToInt32(Console.ReadLine());
int number2 = 1;

while (number2 <= number)
{
    Console.WriteLine(number2 * number2 * number2);
number2++;
}
