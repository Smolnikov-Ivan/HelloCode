//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter the number N to which you want to select even starting with the number one: ");
int numberN = int.Parse(Console.ReadLine() );
for (int i = 1; i <= numberN; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}

//Интересное выравнивание делает Alt+Shift+F