// Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa
/*
Sifatli bo'luvchilar: Foydalanuvchidan son qabul qilib,
shu sonni nechta sifatli bo'luvchilarini hisoblang. 
Sifatli bo'luvchilar, faqat bittadan o'zidan keyincha bo'lan sonlar hisoblanadi. 
Masalan: 
Input = 20; 
Output = 4 
20 raqamining sifatli bo'luvchilari 1, 2, 4, va 5 sonlari hisoblanadi.

*/
// 6.Sifatli bo'luvchilar::
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