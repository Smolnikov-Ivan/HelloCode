//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int a = 1;
Console.Write("Please enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
{
    for (int j = a; j <= N; j++)
    {
        Console.WriteLine($"{j * j * j}");
    }
    Console.WriteLine();
}