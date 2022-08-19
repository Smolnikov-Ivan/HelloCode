Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("The first number is the largest.");
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine("The second number is the largest.");
    Console.WriteLine(number2);
}

//алгоритм работает полностью, хоть и на Console подчёркивание красное, ошибок нет.
//Терминал не понимает русские буквы поэтому всё на английском.

//string name = Console.RedLine();
//Console.ReadLine() ждём значение из терминала
//Convert.ToInt32() превращаем значение в число из терминала
//Создаём переменную и записываем значение туда 
// = присвоить
// == сравнить
// if() {}

