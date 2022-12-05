System.Console.WriteLine("Введите число");
string num = Convert.ToString(Console.ReadLine());
if (num.Length >= 3)
{
    System.Console.WriteLine(num[2]);
}
else{
    System.Console.WriteLine("Третьей цифры нет");
}

