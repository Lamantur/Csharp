int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
// Используем метод из задачи 1 для поиска второго числа
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

int Number = Prompt("Введите число");

//десятки вычитаем, на их место ставим единицы
//156
//(156 - 50 + 60 - 6)/10

int Result = (Number - (Second(Number) * 10) + (Number % 10) * 10 - Number % 10) / 10;
System.Console.WriteLine(Result);
