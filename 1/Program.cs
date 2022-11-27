int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int Second(int number)
{
    if (number / 1000 == 0 && number / 100 > 0)
    {
        int Result;
        Result = (number - (number / 100) * 100 - number % 10) / 10;
        return Result;
    }
    else
    {
        System.Console.WriteLine("ERROR: Введите трехзначное число, согласно условию");
        return 0;
    }

}

System.Console.WriteLine(Second(Prompt("Введите число: ")));