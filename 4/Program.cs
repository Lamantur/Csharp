int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
bool Weakend(int number)
{
    if (number == 6 || number == 7)
    {
        return true;
    }
    else if (number > 0 && number < 6)
    {
        return false;
    }
    else
    {
        System.Console.WriteLine("Введенные данные не соответствуют формату");
        return false;
    }
}
bool Result = Weakend(Prompt("Введите день недели цифрой от 1 до 7"));
if (Result)
{
    System.Console.WriteLine("Да");
}
else { System.Console.WriteLine("Нет"); }