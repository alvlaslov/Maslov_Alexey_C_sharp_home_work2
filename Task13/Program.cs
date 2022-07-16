/* Задача 13: Напишите программу, которая с помощью деления выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Insert number: ");
int number = Convert.ToInt32(Console.ReadLine());
int modulnumber = Math.Abs(number);
if (modulnumber < 100)
{
    Console.WriteLine("Third digital is absent");
}

else
{
while (modulnumber > 999)
{
    modulnumber = modulnumber / 10;
}
int thirddigital = 0;
thirddigital += modulnumber % 10;
Console.WriteLine($"Thrid digital is {thirddigital}");
}