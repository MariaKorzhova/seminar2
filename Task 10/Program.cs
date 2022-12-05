System.Console.WriteLine("Введите трёхзначное число");
string num = Convert.ToString(Console.ReadLine());
if (num.Length == 3)
{
    System.Console.WriteLine(num[1]);
}
else{
    System.Console.WriteLine("Нужно ввести трёхзначное число");
}

