//Console.Write("Введи N: ");
//int N = Convert.ToInt16(Console.ReadLine());
//Console.Write("Введи M: ");
//int M = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine($"N={N}, M={M}");
//if (M>N)
//for (int i = N; i <= M; i++)
   // Console.Write($" {i}");
//else
    //for (int i = M; i <= N; i++)
        //Console.Write($" {i}");

        //Console.Write("Введите число M: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите число N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
//void SumFromMToN(int m, int n)
//{
// Console.Write(SumMN(m - 1, n));
//}

// функция сумма чисел от M до N
//int SumMN(int m, int n)
//{
  //  int res = m;
    //if (m == n)
     //   return 0;
    //else
    //{
       // m++;
       // res = m + SumMN(m, n);
      //  return res;
    //}
//}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
 Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n      ==0&&m>0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}