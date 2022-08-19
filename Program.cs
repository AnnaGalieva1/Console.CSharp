// 
Console.WriteLine("Введите число 1: ");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int usernumber2 = Convert.ToInt32(Console.ReadLine());
int max = usernumber1;
int min = usernumber2;
if (usernumber1 > usernumber2)
{
    Console.WriteLine("Большее число: " + usernumber1);
    Console.WriteLine("Меньшее число: " + usernumber2);
}
else
{
    Console.WriteLine("Большее число: " + usernumber2);
    Console.WriteLine("Меньшее число: " + usernumber1);
}