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