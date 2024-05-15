Console.Write("Ismingizni kiriting: ");
string ism = Console.ReadLine();
string salomlashish=$"Salom {ism}";

Console.Write("Yoshingizni kiriting: ");
int Sizningyosh= int.Parse(Console.ReadLine());

int TotiqushYoshi = 2;
int yoshlarFarqi = Sizningyosh-TotiqushYoshi;
Console.Write($"Siz va to'tiqushning yoshlar farqi: {yoshlarFarqi}");

