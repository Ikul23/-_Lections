// Вывести сумму чисел от 1 до n, методом рекурсии

// int SumNumbers(int n)
// {
// int result = 0;
// for (int i =1; i<=n; i++) result+=i;
// return result;
// }

int SumNumbersRec(int n)
{
if(n==0) return 0; // выход из рекурсии
else return n + SumNumbersRec(n-1);
}

// Console.WriteLine(SumNumbers(10));
Console.WriteLine(SumNumbersRec(10));