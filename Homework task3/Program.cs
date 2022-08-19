// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)


Console.WriteLine("Determining the parity of the entered number");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1 % 2) == 0)
{
    Console.WriteLine("The entered number is even.");
}
else
{
    Console.WriteLine("The entered number is not even.");
}
