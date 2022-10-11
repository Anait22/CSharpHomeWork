// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondDigit(int num)
{
    int result;

    if(num < 100 || num > 1000)
        return 0;

    else
    {
        int dec = num / 10;
        int ed = dec % 10; 
        result = ed;
    }
    return result;
    
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} это {secondDigit}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FindThirdDigit(int num)
{
    int result = 0;
    
    if (num <= 99)
    {
        return -1;
    }          
   
    while (num >= 1000) 
    {
        int digit = num / 10;
        int thirdDig = digit % 10;
        return thirdDig;
    }  
        
    if (num > 99 && num <1000)
    {
        int ed = num % 10;
        result = ed;     
    }

    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = FindThirdDigit(number);
if (thirdDigit == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} это {thirdDigit}");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool CheckingDayOfWeek(int dayNumber)
{
    if(dayNumber == 6 || dayNumber == 7)
        return true;
    else
        return false;
}

Console.WriteLine("Введите число, обозначающее день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

bool checkingDay = CheckingDayOfWeek(num);
Console.WriteLine($"{checkingDay}");
*/