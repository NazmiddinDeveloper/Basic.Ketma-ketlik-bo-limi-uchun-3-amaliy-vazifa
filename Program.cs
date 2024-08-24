// Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa
/*
Harajatlar to'plamini hisoblash:
Foydalanuvchidan bir nechta to'plam miqdorlar kiritilgan holda, ularni qo'shib yig'indisini hisoblovchi dastur yozing va natijani ekranga chiqaring. 
Input = [150, 230, 80, 120]; 
Output = 580

*/
// 4.Harajatlar to'plamini hisoblash:

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