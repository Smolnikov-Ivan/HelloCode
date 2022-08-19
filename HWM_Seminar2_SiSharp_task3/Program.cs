//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
Console.Write("Hello, please enter the day number to determine if this day is a weekend: ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(thirdnumber[2]);
if (number > 6 && number < 8)
{
    Console.WriteLine("YES. The day under the number you have chosen is a weekend. Thank you for contacting us.");
}
else
{

    Console.WriteLine("NO. You have chosen the day under the number: " + number + ". It is not a weekend. Thank you for contacting us.");
}
