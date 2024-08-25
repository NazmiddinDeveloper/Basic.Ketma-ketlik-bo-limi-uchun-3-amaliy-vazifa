// -- Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa
/* 
HAMMA VAZIFALAR JAMLANMASI USHUBU MASTER BRANCHGA PR QILINGAN 
VA ALOHIDA ALOHIDA USHBU REPO BRANCHLARIDAHAM TOPISH MUMKIN 
*/

// 1.Tub sonlar:
/*
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
*/

// 2.Bo'luvchisiz sonlar:

/*
System.Console.Write(" Son kiriting : ");
string sonStr = Console.ReadLine();
int son = Convert.ToInt32(sonStr);

string result = "Bo'luvchilari: ";

for (int i = 2; i <= 10; i++)
{
    if(son % i == 0){
        result += $" {i}," ;
    }
}

System.Console.WriteLine(result);
*/

// 3.Daraja hisoblash:
/*

// 3.Daraja hisoblash:
Console.Write($" Son kiriting : ");
string sonStr = Console.ReadLine();
int son = Convert.ToInt32(sonStr);


long sonP;
while (true){
    Console.Write($" {son} ni nechanchi darajaga ko'tarmoqchisiz : ");
    string sonStrP = Console.ReadLine();
    bool a = false;
    for(int z = 0; z < sonStrP.Length; z++){
        if(sonStrP[z] == '.'){
            a = true;
            break;
        }
    }
    if(a == false && Convert.ToInt64(sonStrP) > 0){
        sonP = Convert.ToInt64(sonStrP);
        break;
    }
}

int result = son;
for (int i = 1; i < sonP; i++)
{
    result *= son;
}
System.Console.WriteLine($"  Output = {result}");
*/

// 4.Harajatlar to'plamini hisoblash:
/*
System.Console.WriteLine("To'plam korinishida harajatlaringizni kiriting misol -> [150, 230, 80, 120] : ");
System.Console.Write(" Input = ");
string numbers =  System.Console.ReadLine();

string[] strNumbers = numbers.Split(',');
int[] intNumbers = new int[strNumbers.Length]; 

for(int i = 0; strNumbers.Length > i; i++){
    intNumbers[i] = Convert.ToInt32(strNumbers[i]);
}
int sum = 0;
foreach(int number in intNumbers){
    sum+=number;
}

System.Console.WriteLine($" Output = {sum}");
*/

// 5.Armstrong sonlar:

/*
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
*/

// 6.Sifatli bo'luvchilar:

System.Console.WriteLine(" Output = ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int count = 0;

for (int i = 1; i < number; i++)
{
    if(number%i == 0){
        /*
            !!  ASSALOMU ALEYKUM USTOZ TUZUMUSZ HOZZI KODNI TEKSHIRVOTGAN BO'SEZ AGAR
            MASALA SHARTIGA USHBU VAZIFA TOG'RI KELMAGAN BILAMAN
            SABABI MASALA SHARTINI TUSHUNMADIM TUSHUNARSIZ EKAN.
            @Nazmiddin_505 telegram akkauntim iloji bolsa tushuntirib yuboring iltimos
            Oldindan rahmat katta. Ishizga omad :)
        */
        System.Console.WriteLine(i);
        count++;
        /*
            Hozir faqat kiritilgan songacha bo'lgan boluvchilar sonini hisobladim :(
        */
    }
}

System.Console.WriteLine(count);