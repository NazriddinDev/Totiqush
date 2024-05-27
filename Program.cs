using System;

Console.Write("Ismingizni kiriting: ");
string ism = Console.ReadLine();
string salomlashish=$"Salom {ism}";

Console.Write("Yoshingizni kiriting: ");
int Sizningyosh= int.Parse(Console.ReadLine());
int TotiqushYoshi = 2;
int yoshlarFarqi = Sizningyosh-TotiqushYoshi;
Console.WriteLine($"Yoshlar farqi {yoshlarFarqi}");
Console.WriteLine("Operatsiya turini kiriting=> +,-,*,/,%");
string operation = Console.ReadLine();

//Switch exressions
string natijasi = operation switch
{
    "+"=>$"Sizning va to'tiqushning yoshlar yig'indisi {Sizningyosh+TotiqushYoshi}",
    "-"=>$"Sizning va to'tiqushning yoshlar ayirmasi {Sizningyosh-TotiqushYoshi}",
    "*"=>$"Sizning va to'tiqushning yoshlar ko'paytmasi {Sizningyosh*TotiqushYoshi}",
    "/"=>$"Sizning va to'tiqushning yoshlar bo'linmasisi {Sizningyosh/TotiqushYoshi}",
    "%"=>$"Sizning va to'tiqushning yoshlarining qoldiqli {Sizningyosh%TotiqushYoshi}",
    _=>"Operatsiya turi xato kiritildi...",
};
Console.WriteLine(natijasi);

// //ternary operator
// string natija =
//     yoshlarFarqi >= 0
//         ? "Sizning yoshingiz to'tiqushning yoshidan katta yok teng"
//         : "Sizning yoshingiz to'tiqushning yoshidan kichik";
//         Console.WriteLine(natija);

// Logical operator &&, ||, !
// string message =
//     (Sizningyosh > 0 && TotiqushYoshi > 0)
//         ? "Sizning va to'tiqushning yoshi noldan katta..."
//         : "Sizning yoki to'tiqushning yoki ikkalangizningham yoshlaringiz noldan kichik...";
//         Console.WriteLine(message);

// string result =
//     (Sizningyosh > 0 || TotiqushYoshi > 0)
//         ? "Sizning yoki to'tiqushning yoshi noldan katta..."
//         : "Sizning va to'tiqushning yoshi noldan kichik...";
//         Console.WriteLine(result);

// string show =
//     !(Sizningyosh > 0 || TotiqushYoshi > 0)
//         ? "Sizning yoki to'tiqushning yoshi noldan katta..."
//         : "Sizning yoki to'tiqushning yoshi noldan kichik...";
//         Console.WriteLine(show);

// if(Sizningyosh>TotiqushYoshi)
// {
//     Console.WriteLine("Siz kattasiz...");
// }
// else if(Sizningyosh==TotiqushYoshi)
// {
//     Console.WriteLine("Yoshlaringiz teng...");
// }
// else
// {
//     Console.WriteLine("Siz yoshsiz...");
// }

// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan katta {Sizningyosh > TotiqushYoshi}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan katta yoki teng {Sizningyosh >= TotiqushYoshi}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan kichik {Sizningyosh > TotiqushYoshi}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqamdan kichik yoki teng {Sizningyosh <= TotiqushYoshi}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqam teng {Sizningyosh == TotiqushYoshi}");
// Console.WriteLine($"Birinchi raqam ikkinchi raqam teng emas {Sizningyosh != TotiqushYoshi}");

//Array
Console.WriteLine("Menga do'stingiz haqida ayting...");
string[] friendsName = {"Vasya", "Nasya","Kasya","Masya"};
int[] friendsAge = {2, 4, 5, 7, 6, 5};
string[] friendsAddresss = {"Moscow", "London", "Australia", "USA"};
System.Console.WriteLine($"{friendsName[0]} ning yoshi {friendsAge[0]} da, manzili esa {friendsAddresss[0]} ...");

Console.WriteLine("Menga do'stingiz haqida ayting...");
string[] dostlarNomi = new string[4];
dostlarNomi[0] = "Vasya";
dostlarNomi[1] = "Nasya";
dostlarNomi[2] = "Kasya";
dostlarNomi[3] = ism;
int[] dostlarYoshi = {1,3, 2, Sizningyosh};

//Use foreach
foreach(string Nomi in dostlarNomi)
{
    Console.WriteLine(Nomi);
}

//Use for
for(int i = 0; i <dostlarYoshi.Length; i++)
{
    Console.WriteLine($"{dostlarNomi[i]} ning yoshi {dostlarYoshi[i]} da...");
}