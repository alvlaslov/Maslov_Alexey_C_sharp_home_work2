/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.*/

 Console. WriteLine("Insert number: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if(number == 6 || number == 7)
 {
     Console. WriteLine($"{number} is a weekend");
 }
 else if (number < 1 || number > 7)
 {
    Console. WriteLine($"{number} isnot a day of week");
 }
else 
{
Console. WriteLine($"{number} is a workday");
}