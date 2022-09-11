int funcAcerman(int m, int n)
{
    if (m==0)
        return (n+1);
    else
        if ((m != 0) && ( n == 0 ))
            return funcAcerman(m-1,1);
        else
            return funcAcerman(m-1,funcAcerman(m,n-1));

}

Console.WriteLine(" Введте первый параметр для функции Аккермана ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введте второй параметр для функции Аккермана ");
int n = Convert.ToInt32(Console.ReadLine());
int res = funcAcerman(m,n);
Console.WriteLine(res);