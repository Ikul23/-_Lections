// Найти максимальное число из 9-ти, используя Функции и массивы
int a1 = 340000;
int b1 = 258;
int c1 = -29;
int a2 = 58;
int b2 = 312;
int c2 = -1000;
int a3 = 358;
int b3 = 23312;
int c3 = 0;

int Max(int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if(Arg2 > result) result = Arg2;
    if(Arg3 > result) result = Arg3;
    return result;
}
//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
// int max = Max(max1, max2, max3);
int max = Max(                   // различные варианты записи кода
     Max(a1,b1,c1),
     Max(a2,b2,c2),
     Max(a3,b3,c3));

 Console.WriteLine(max);