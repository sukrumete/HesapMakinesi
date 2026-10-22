
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

Console.Write("İşlem türünü seçiniz (+, -, *, /): ");
string islem = Console.ReadLine();

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
else
{
    Console.WriteLine("Geçersiz işlem türü.");
    hatavar = true;
}
if (hatavar == false)
{
    Console.WriteLine("Sonuç: " + sonuc);
}