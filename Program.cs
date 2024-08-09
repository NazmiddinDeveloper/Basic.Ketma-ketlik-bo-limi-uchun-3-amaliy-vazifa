
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



