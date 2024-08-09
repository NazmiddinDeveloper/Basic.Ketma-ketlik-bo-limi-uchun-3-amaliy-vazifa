// 2 . Boluvchisiz-sonlar
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

