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

// 5.Armstrong sonlar:

// 6.Sifatli bo'luvchilar:


