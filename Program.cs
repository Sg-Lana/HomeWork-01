/* напишите цикл, который принимает на вход два числа (А и В)
и выводит число А в натуральную степень В (и в нулевую степень).
2, 4 - 16*/

int Prompt(string massage)
{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberA = Prompt ("введите число А - ");
int numberB = Prompt ("введите число В - ");

if (numberB >=0)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    Console.WriteLine($"число {numberA} в {numberB} степени равно {result}");
}
else
{
    Console.WriteLine($"число {numberB} не натуральное");
}