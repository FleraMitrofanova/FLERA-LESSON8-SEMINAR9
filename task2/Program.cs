int sum =0;

void PrintNum(int n, int m)
{
    if(n < m+1) 
    {
        sum += n;
        PrintNum(n+1, m);
    }
}

Console.WriteLine(" Введте числа в диапазоне от ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введте числа в диапазоне от ");
int m = Convert.ToInt32(Console.ReadLine());
PrintNum(n,m);
Console.WriteLine("Сумма элементов между n и m равна: "+sum);