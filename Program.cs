//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int Prompt(string ones1)
{

System.Console.WriteLine($"{ones1}");
return Convert.ToInt32(Console.ReadLine());
}
    int number = Prompt("Введите трехзначное число");
    if (number >=100 && number <1000)
{
    int ones1 = (number / 10)%10;
    
System.Console.WriteLine($"Вторая цифра числа {number} является {ones1}");
}
    else
System.Console.WriteLine("Это число не трехзначное");
*/

//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
/*
int Prompt(string ones1)
{

System.Console.WriteLine($"{ones1}");
return Convert.ToInt32(Console.ReadLine());
}
    int number = Prompt("Введите число ");
    int fnumber(int number)
{
while (number > 999)
{
    number /= 10;
}
    return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}
if (check(number) != true)
System.Console.WriteLine("третьего числа нет");
    else
System.Console.WriteLine($"Третья цифра числа {number} является {fnumber(number)}");
*/
    
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*
int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check(int number)
{
if (number >= 6 && number < 8) ss = "Это выходной";
if (number >= 1 && number < 7) ss = "Это будний день";
return ss;
}
System.Console.WriteLine(check(number));
*/      
    



