// Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa
/*
Armstrong sonlar: 
Foydalanuvchidan son qabul qilib,
shu sonni Armstrong son ekanligini aniqlang.
Armstrong son, raqamlarining darajasiga mos keladigan sonlardir. Masalan: 
Input = 153; 
Output = "153 Armstrong son" 
153 raqamining raqamlarini darajaga olib,
o'lchamalarga ko'paytirib qo'ygan holda,
1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 bo'ladi. Bu sababli, 153 raqami Armstrong son hisoblanadi.
*/
// 1.Tub sonlar:

Console.Write(" Input = ");
string numberStr = Console.ReadLine();
int numberLength = numberStr.Length;

int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < numberLength; i++)
{
    sum2 = 1;
    if(Convert.ToInt32(numberStr[i].ToString()) == 1){
        sum1 = 1;
        continue;
    }
    for (int j = 0; j < numberLength; j++)
    {
        sum2 *= Convert.ToInt32(numberStr[i].ToString());
    }
    sum1 += sum2;
}
if (Convert.ToInt32(numberStr) == sum1){
    System.Console.WriteLine($"{numberStr} Armstrong son ");
}else{
    System.Console.WriteLine($"{numberStr} Armstrong son emas ");
}