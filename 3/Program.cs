int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Thirth(int number)
{
    if (number >= 100)
    {
        while (number / 10 >= 100)
        {
            number = number / 10;
        }
        return number % 10;
    }

    else
    {

        return 12;
    }
}

int Result = Thirth(Prompt("Введите число"));

if (Result != 12)
{
    System.Console.WriteLine(Result);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}
