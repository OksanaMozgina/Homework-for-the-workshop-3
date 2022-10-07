/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


void AnswerToTask(int number)
{
    if (number >= 10000 && number < 100000)
    {
        string numericAsString = number.ToString();


        if (numericAsString[0] == numericAsString[4] && numericAsString[1] == numericAsString[3])
        {
            Console.WriteLine($"{number} - Палиндром");
        }
        else
        {
            Console.WriteLine($"{number} - НЕ палиндром");
        }
    }
    else
        Console.WriteLine($"{number} - не является пятизначным");

}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
AnswerToTask(number);




