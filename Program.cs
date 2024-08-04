using System;
// Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa
// 1.Tub sonlar:

Console.Write(" Output :");
string nStr = Console.ReadLine();
int n = Convert.ToInt32(nStr);

int x = 1;

for (int i = 2; i < n; i++)
{
    if (n%i == 0)
    {
        x++;
    }
}

if(x == 1){
    Console.WriteLine(" Output = \"TUB\"");
}else{
    Console.WriteLine(" Output = \"MURAKKAB\"");
}
