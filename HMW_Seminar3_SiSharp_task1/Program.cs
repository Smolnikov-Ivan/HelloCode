// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Hello, please enter a five-digit number to check whether it is a palindrome: ");
string number = Console.ReadLine();
char[] obrnumber = number.ToCharArray();
Array.Reverse(obrnumber);
string newnumber = new string(obrnumber);
if (number == newnumber)
{
    Console.WriteLine("Yes. The number you entered is a palindrome.");
}
else
{
    Console.WriteLine("No. The number you entered is not a palindrome. ");
}
