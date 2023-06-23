// Задача 27: Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SlicingAndSum(int number)
{
    int slicedNum = 0;
    while (number != 0)
    {
        int reminder = number % 10;
        number /= 10;
        slicedNum += reminder;
    }
    return slicedNum;
}


int num = InputNum();
int sum = SlicingAndSum(num);
Console.WriteLine(sum);