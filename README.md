# Hesap Makinesi 🧮

C# ile yazılmış basit bir konsol hesap makinesi. C# öğrenme sürecimdeki ilk projem.

## Ne yapıyor?

Kullanıcıdan iki sayı ve bir işlem alır, sonucu ekrana yazar.

- Toplama, çıkarma, çarpma, bölme, kalan (%) ve üs alma (^)
- Ondalıklı sayılarla çalışır, sonuçları 2 basamağa yuvarlar
- Program kapanmadan art arda hesap yapılabilir
- Yanlış girişte kapanmaz, tekrar sorar (harf, geçersiz işlem, E/H dışı cevap)
- Sıfıra bölmeye karşı uyarı verir
- Hesap geçmişini tarih ve saatle birlikte dosyaya kaydeder, program açılınca eski hesapları yükler, istenirse geçmişi siler

```
Birinci Sayıyı giriniz: abc
Lütfen geçerli bir sayı giriniz.
Birinci Sayıyı giriniz: 7
İkinci Sayıyı giriniz: 2
İşlem türünü seçiniz (+, -, *, /, %, ^): /
Sonuç: 3,5
Devam etmek istiyor musunuz? (E/H): h
Hesap Geçmişi
28.10.2026 19:30 - 7 / 2 = 3,5
Görüşmek üzere!
```

## Kullanılanlar

- C#
- .NET 10

## Nasıl çalıştım?

- Bu projeyi yapay zekâ ile soru-cevap şeklinde ilerleyerek yaptım. Yapay zekâ bana sorular sordu, ipuçları verdi ve kavramları açıkladı.
- Kod satırlarını kendim yazdım. Takıldığım yerde ipucu istedim, hatalarımın nedenini sordum. Bazı yerlerde çözüme çok yakın ipuçları aldım, bazı yerlerde çözümü yapay zekâ gösterdi.
- Anlamadığım kodu yapıştırmadım. Her değişiklikten sonra programı kendim test ettim.
- Nerede kendim bulduğumu, nerede yardım aldığımı versiyon versiyon [GELISIM.md](GELISIM.md) dosyasında açıkça yazdım.

## Bu projede öğrendiklerim

- **Temeller:** Kullanıcıdan veri alma, tür dönüştürme (int, double), = ile == farkı
- **Karar yapıları:** if / else if / else, iç içe if, switch-case
- **Hata yönetimi:** try / catch, ardından daha temiz bir yol olarak TryParse
- **Döngüler:** while ile hatalı girişi tekrar sorma ve programı tekrar çalıştırma
- **Metotlar:** Tekrar eden kodu SayiAl, IslemAl, DevamMi metotlarına taşıma (parametre ve return)
- **Listeler ve dosyalar:** List ile geçmiş tutma, File ile dosyaya kaydetme ve okuma
- **OOP'ye giriş:** HesapMakinesi sınıfı, özellik ve metot farkı, sınıfı ayrı dosyaya taşıma
- **Alışkanlıklar:** Refactoring (gereksiz kodu temizleme), her değişiklikten sonra test etme, Git ile versiyon versiyon commit

**En çok zorlandığım konular:** Metotlarda tanımlama ile çağırma farkı ve OOP'de sınıf, nesne, özellik ilişkisi. Bunları tekrar ederek oturtmaya devam ediyorum.

👉 Versiyon versiyon detaylı gelişim günlüğü: [GELISIM.md](GELISIM.md)
