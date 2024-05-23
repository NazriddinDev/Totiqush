using System;

Console.Write("Ismingizni kiriting: ");
string ism = Console.ReadLine();
string salomlashish=$"Salom {ism}";

Console.Write("Yoshingizni kiriting: ");
int Sizningyosh= int.Parse(Console.ReadLine());
int TotiqushYoshi = 2;
int yoshlarFarqi = Sizningyosh-TotiqushYoshi;
Console.WriteLine($"Yoshlar farqi {yoshlarFarqi}");
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