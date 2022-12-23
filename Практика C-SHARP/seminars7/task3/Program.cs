// Дополнительная задача)https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=703)

int n = Convert.ToInt32(Console.ReadLine());
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
 
 
int countEven = 0, countOdd = 0;
foreach (int element in array)
{
    if (element % 2 == 1)
    {
        Console.Write($"{element} ");
        countEven++;
    }
}
Console.WriteLine();
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        Console.Write($"{element} ");
        countOdd++;
    }
}
Console.WriteLine();
if (countOdd >= countEven)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");