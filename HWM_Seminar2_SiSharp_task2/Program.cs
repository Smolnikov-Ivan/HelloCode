//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.Write("Hello, please enter a multivalued number: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(thirdnumber[2]);
if (thirdnumber > -100 && thirdnumber < 100)
{
    Console.WriteLine("Sorry, there is no third number in the number you entered.");
}
else
{
    if (thirdnumber < 0)
    {
        thirdnumber = -1 * thirdnumber;
    }
    string Thirdnumber = Convert.ToString(thirdnumber);
    Console.WriteLine("The third number in the argument you entered is: " + Thirdnumber[2] + ". Thank you for contacting us.");
}