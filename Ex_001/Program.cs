/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int InputSumNums()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int InputGradeNum()
{
    Console.WriteLine("Введите степень числа: ");
    int gradeNum = int.Parse(Console.ReadLine()!);
    return gradeNum;
}

int Grading(int number, int gradeNum)
{
    int result = number;
    for (int i = 1; i < gradeNum; i++)
    {
        result *= number;
    }
    return result;
}

int num = InputSumNums();
int grade = InputGradeNum();
int result = Grading(num, grade);
Console.WriteLine(result);