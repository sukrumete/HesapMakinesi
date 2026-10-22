
try
{
    Console.Write("Birinci Sayıyı giriniz: ");
    double birincisayi = double.Parse(Console.ReadLine());

    Console.Write("ikinci Sayıyı giriniz: ");
    double ikincisayi = double.Parse(Console.ReadLine());

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
}
catch (FormatException)
{
    Console.WriteLine("Lütfen Geçerli Bir sayı Giriniz");
}