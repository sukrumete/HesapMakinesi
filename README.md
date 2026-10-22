# Hesap Makinesi 🧮

C# ile yazılmış basit bir konsol hesap makinesi. C# öğrenme sürecimdeki ilk projem.

## Ne yapıyor?
Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alır, sonucu ekrana yazar.
- Ondalıklı sayılarla çalışır (7 / 2 = 3,5)
- Sıfıra bölmeye çalışılırsa program çökmez, uyarı verir
- Sayı yerine harf girilirse program çökmez, uyarı verir
- Geçersiz işlem seçilirse uyarı verir

```
Birinci Sayıyı giriniz: 7
ikinci Sayıyı giriniz: 2
İşlem türünü seçiniz (+, -, *, /): /
Sonuç: 3,5
```

```
Birinci Sayıyı giriniz: abc
Lütfen Geçerli Bir sayı Giriniz
```

## Kullanılanlar
- C#
- .NET 10

## Bu projede öğrendiklerim

**Versiyon 1**
- `Console.ReadLine()` ile kullanıcıdan veri almak
- `int.Parse()` ile metni sayıya çevirmek
- Metin + metin = birleştirme ("3" + "4" = "34") hatasını bulup düzeltmek

**Versiyon 2**
- `if / else if / else` ile karar vermek
- `=` (atama) ile `==` (karşılaştırma) farkı
- İç içe `if` ile sıfıra bölme kontrolü
- Kendi test senaryolarımı yazıp hataları bulmak

**Versiyon 3**
- 7 / 2 = 3 çıkıyordu (küsurat atılıyordu) → `int` yerine `double` kullandım
- Hata olunca ekranda yanıltıcı "Sonuç: 0" çıkıyordu → `bool` flag ile çözdüm
- Harf girilince program çöküyordu (`FormatException`) → `try / catch` ile çözdüm
- Kapsam (scope): `{ }` içinde oluşturulan değişken dışarıda kullanılamaz (CS0103 hatası aldım)

## Sonraki adımlar
- [x] İşlem seçimi (+, -, *, /)
- [x] Sıfıra bölme kontrolü
- [x] Hatalı girişleri yakalama (harf girilirse)
- [x] Ondalıklı sayılar (7 / 2 = 3,5)
- [x] Hata durumunda "Sonuç: 0" yazmaması
- [ ] Hatalı girişte programı kapatmak yerine tekrar sormak
- [ ] Program kapanmadan art arda hesap yapabilmek (döngü)
- [ ] Kodu metotlara bölmek
