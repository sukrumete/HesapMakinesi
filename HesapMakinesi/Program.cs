
Console.Write("Birinci Sayıyı giriniz: ");
int birincisayi = int.Parse(Console.ReadLine());

Console.Write("ikinci Sayıyı giriniz: ");
int ikincisayi = int.Parse(Console.ReadLine());

Console.Write("İşlem türünü seçiniz (+, -, *, /): ");
string islem = Console.ReadLine();

int sonuc = 0;
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