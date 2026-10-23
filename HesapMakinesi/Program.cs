bool devam = true;
while (devam)
{



    double birincisayi = SayiAl("Birinci Sayıyı giriniz: ");

    double ikincisayi = SayiAl("İkinci Sayıyı giriniz: ");

    string islem = "";
    bool gecerli = false;
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
    switch (islem)
    {
        case "+":
            sonuc = birincisayi + ikincisayi;
            break;
        case "-":
            sonuc = birincisayi - ikincisayi;
            break;
        case "*":
            sonuc = birincisayi * ikincisayi;
            break;
        case "/":
            if (ikincisayi == 0)
            {
                Console.WriteLine("Bir Sayıyı 0'a Bölemezsiniz.");
                hatavar = true;
            }
            else
            {
                sonuc = birincisayi / ikincisayi;
            }
            break;
    }

    if (hatavar == false)
    {
        Console.WriteLine("Sonuç: " + sonuc);
    }

    string cevap = "";
    gecerli = false;
    while (gecerli == false)
    {
        Console.Write("Devam etmek istiyor musunuz? (E/H): ");
        cevap = Console.ReadLine();

        if (cevap == "E" || cevap == "e" || cevap == "H" || cevap == "h")
        {
            gecerli = true;
        }
        else
        {
            Console.WriteLine("Lütfen E ya da H giriniz.");
        }
    }
    if (cevap == "H" || cevap == "h")
    {
        devam = false;
    }
}
Console.WriteLine("Görüşmek üzere!");

double SayiAl(string mesaj)
{
    double sayi = 0;
    bool gecerli = false;
    while (gecerli == false)
    {
        Console.Write(mesaj);
        gecerli = double.TryParse(Console.ReadLine(), out sayi);
        if (gecerli == false)
        {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        }
    }
    return sayi;
}
