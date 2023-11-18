// Найти максимальное число из 9-ти, используя Функции/Метод и массивы

int Max(int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if(Arg2 > result) result = Arg2;
    if(Arg3 > result) result = Arg3;
    return result;
}
            //  0   1   2       3     4    5    6   7    8
int[] array = {125, 20, 3000, 45896, -5, 6123, 71, 879, 999};
array [0] = 12;
Console.WriteLine(array[7]);

// int max = Max(              
   // Max(a1,b1,c1),
    // Max(a2,b2,c2),
    //Max(a3,b3,c3));
// Console.WriteLine(max);
