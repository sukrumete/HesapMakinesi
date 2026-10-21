# Hesap Makinesi 🧮

C# ile yazılmış basit bir konsol hesap makinesi. C# öğrenme sürecimdeki ilk projem.

## Ne yapıyor?
Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alır, sonucu ekrana yazar.
Sıfıra bölmeye çalışılırsa program çökmez, uyarı verir.

```
Birinci Sayıyı giriniz: 8
ikinci Sayıyı giriniz: 2
İşlem türünü seçiniz (+, -, *, /): *
Sonuç: 16
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

## Sonraki adımlar
- [x] İşlem seçimi (+, -, *, /)
- [x] Sıfıra bölme kontrolü
- [ ] Hatalı girişleri yakalama (harf girilirse)
- [ ] Ondalıklı sayılar (7 / 2 = 3,5)
- [ ] Hata durumunda "Sonuç: 0" yazmaması
