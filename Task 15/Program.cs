
/*
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num){
    case 1:
        Console.WriteLine("Нет");
        break;
    case 2:
        Console.WriteLine("Нет");
        break;
    case 3:
        Console.WriteLine("Нет");
        break;
    case 4:
        Console.WriteLine("Нет");
        break;
    case 5:
        Console.WriteLine("Нет");
        break;
    case 6:
        Console.WriteLine("Да");
        break;
    case 7:
        Console.WriteLine("Да");
        break;
    default:
        Console.WriteLine("Число не соответствует какому-либо дню недели");
        break;
} */

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = (num < 8 && (num == 6 || num == 7))? "Да" : "Число не соответствует какому-либо дню недели";
System.Console.WriteLine(result);
