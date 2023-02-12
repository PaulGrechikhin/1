Console.Clear();
int a1 = 4;
int a2 = 2;
int a3 = 98;
int b1 = 44;
int b2 = 3;
int b3 = 9;
int c1 = 12;
int c2 = 33;
int c3 = 20;

// Пример создания метода (функции)

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.Write(max);