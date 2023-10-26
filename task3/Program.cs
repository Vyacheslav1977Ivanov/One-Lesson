// See https://aka.ms/new-console-template for more information
Console.Write("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
if(num!=0)
{
    int result=num%2;
    if (result>0)
    {
        Console.Write("Нет");
    }
    else
    {
        Console.Write("Да");
    }
}