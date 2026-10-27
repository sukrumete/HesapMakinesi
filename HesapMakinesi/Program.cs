
HesapMakinesi makine = new HesapMakinesi();
makine.GecmisiYukle();
bool devam = true;
while (devam)
{



    double birincisayi = SayiAl("Birinci Sayıyı giriniz: ");

    double ikincisayi = SayiAl("İkinci Sayıyı giriniz: ");

    string islem = IslemAl();

    double sonuc = 0;
    bool hatavar = false;
    if ((islem == "/" || islem == "%") && ikincisayi == 0)
    {
        Console.WriteLine("Bir sayıyı 0'a bölemezsiniz.");
        hatavar = true;
    }
    else
    {
        sonuc = makine.Hesapla(birincisayi, ikincisayi, islem);
    }


    if (hatavar == false)
    {
        Console.WriteLine("Sonuç: " + sonuc);
        makine.GecmiseEkle(birincisayi + " " + islem + " " + ikincisayi + " = " + sonuc);
    }

    devam = DevamMi();
}

Console.WriteLine("Hesap Geçmişi");
foreach (string hesap in makine.Gecmis)
{
    Console.WriteLine(hesap);
}

Console.WriteLine("Görüşmek üzere!");

string IslemAl()
{
    string islem = "";
    bool gecerli = false;
    while (gecerli == false)
    {
        Console.Write("İşlem türünü seçiniz (+, -, *, /, %, ^): ");
        islem = Console.ReadLine();
        if (islem == "+" || islem == "-" || islem == "*" || islem == "/" || islem == "%" || islem == "^")
        {
            gecerli = true;
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir işlem türü giriniz.");
        }
    }
    return islem;
}

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

bool DevamMi()
{
    string cevap = "";
    bool gecerli = false;
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
        return false;
    }
    else
    {
        return true;
    }
}



class HesapMakinesi
{
    public List<string> Gecmis = new List<string>();


    public void GecmisiYukle()
    {
        if (File.Exists("gecmis.txt"))
        {
            string[] eskiHesaplar = File.ReadAllLines("gecmis.txt");
            foreach (string hesap in eskiHesaplar)
            {
                Gecmis.Add(hesap);
            }
        }
    }



    public void GecmiseEkle(string hesap)
    {
        Gecmis.Add(hesap);
        File.AppendAllText("gecmis.txt", hesap + "\n");
    }

    public double Hesapla(double birincisayi, double ikincisayi, string islem)
    {
        double sonuc = 0;
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
                sonuc = birincisayi / ikincisayi;
                break;
            case "%":
                sonuc = birincisayi % ikincisayi;
                break;
            case "^":
                sonuc = Math.Pow(birincisayi, ikincisayi);
                break;
        }
        return sonuc;
    }
}