// See https://aka.ms/new-console-template for more information
Console.Write("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<num+1;i++)
{
    int result=i%2;
    if(result==0)
    {
        Console.Write(i+" ");
    }
}