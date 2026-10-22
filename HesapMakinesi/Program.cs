
using System.Data;

double birincisayi = 0;
bool gecerli = false;
while (gecerli == false)
{
    Console.Write("Birinci Sayıyı giriniz: ");
    gecerli = double.TryParse(Console.ReadLine(), out birincisayi);

    if (gecerli == false)
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    }
}

double ikincisayi = 0;
gecerli = false;
while (gecerli == false)
{
    Console.Write("İkinci Sayıyı giriniz: ");
    gecerli = double.TryParse(Console.ReadLine(), out ikincisayi);

    if (gecerli == false)
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    }
}

string islem = "";
gecerli = false;
while (gecerli == false)
{
    Console.Write("İşlem türünü seçiniz (+, -, *, /): ");
    islem = Console.ReadLine();

    if (islem == "+" || islem == "-" || islem == "*" || islem == "/")
    {
        gecerli = true;
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir işlem türü giriniz.");
    }
}

double sonuc = 0;
bool hatavar = false;
if (islem == "+")
{
    sonuc = birincisayi + ikincisayi;
}
else if (islem == "-")
{
    sonuc = birincisayi - ikincisayi;

}
else if (islem == "*")
{
    sonuc = birincisayi * ikincisayi;
}
else if (islem == "/")
{
    if (ikincisayi == 0)
    {
        Console.WriteLine("Bir sayıyı 0'a bölemezsiniz.");
        hatavar = true;
    }
    else
    {
        sonuc = birincisayi / ikincisayi;
    }
}
if (hatavar == false)
{
    Console.WriteLine("Sonuç: " + sonuc);
}