using System.ComponentModel.Design;

Console.Write("Birinci Sayıyı giriniz: ");
int birincisayi = int.Parse(Console.ReadLine());

Console.Write("ikinci Sayıyı giriniz: ");
int ikincisayi = int.Parse(Console.ReadLine());

Console.Write("İşlem türünü seçiniz (+, -, *, /): ");
string islem = Console.ReadLine();

int sonuc = 0;
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
    }
    else
    {
        sonuc = birincisayi / ikincisayi;
    }
}
else
{
    Console.Write("Geçersiz işlem türü.");
}
Console.WriteLine("Sonuç: " + sonuc);