# Hesap Makinesi 🧮

C# ile yazılmış basit bir konsol hesap makinesi. C# öğrenme sürecimdeki ilk projem.

## Ne yapıyor?
Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alır, sonucu ekrana yazar.
- Ondalıklı sayılarla çalışır (7 / 2 = 3,5)
- Program kapanmadan art arda hesap yapılabilir
- Yanlış girişte program kapanmaz, kullanıcıdan tekrar ister:
  - Sayı yerine harf girilirse
  - Geçersiz işlem seçilirse
  - Devam sorusuna E/H dışında bir şey yazılırsa
- Sıfıra bölmeye çalışılırsa uyarı verir

```
Birinci Sayıyı giriniz: abc
Lütfen geçerli bir sayı giriniz.
Birinci Sayıyı giriniz: 7
İkinci Sayıyı giriniz: 2
İşlem türünü seçiniz (+, -, *, /): x
Lütfen geçerli bir işlem türü giriniz.
İşlem türünü seçiniz (+, -, *, /): /
Sonuç: 3,5
Devam etmek istiyor musunuz? (E/H): e
Birinci Sayıyı giriniz: 10
İkinci Sayıyı giriniz: 0
İşlem türünü seçiniz (+, -, *, /): /
Bir sayıyı 0'a bölemezsiniz.
Devam etmek istiyor musunuz? (E/H): h
Görüşmek üzere!
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

**Versiyon 4**
- Yanlış girişte program kapanıyordu → `while` döngüsü ile tekrar sordum
- `try / catch` yerine `double.TryParse` kullandım (çökmeden `true` / `false` döner)
- `TryParse` gelince `try / catch` gereksiz kaldı → kodu temizledim (refactoring)
- Geçersiz işlem kontrolü döngüye taşındı → eski `else` bloğu gereksiz kaldı, sildim
- `||` (veya) ile birden fazla koşulu kontrol etmek (`"H" || "h"`)
- Bütün programı bir `while` döngüsüne alarak art arda hesap yapmak
- Devam sorusuna "x" yazınca program devam ediyordu → testte fark ettim, E/H kontrolü ekledim
- Kod silerken yanlışlıkla sonuç satırını da sildim → testte fark edip geri ekledim

**Versiyon 5**
- Birinci ve ikinci sayıyı alan kodlar neredeyse aynıydı (24 satır) → `SayiAl` metoduna taşıdım, artık 2 satır
- İki blok arasındaki farkları buldum (ekrana yazılan mesaj ve sonucun gittiği değişken) → mesajı **parametre**, sayıyı **return** yaptım
- En çok zorlandığım kısım: metot imzasındaki tür ve isim sırası (`double SayiAl(string mesaj)`) ve metodu **tanımlamak** ile **çağırmak** arasındaki fark
- Blok silinince `bool gecerli` tanımı da gitti ve CS0103 hatası aldım → değişkeni kullanıldığı ilk yerde yeniden tanımladım
- Refactoring sonrası bütün testleri tekrarladım, program eskisiyle aynı çalışıyor

**Versiyon 6**
- `if / else if` zincirindeki tekrar eden `islem ==` kontrollerini `switch` ile daha düzenli yazdım
- `switch (islem)` parantezine karşılaştırma değil, sadece değişken yazıldığını öğrendim
- `case` sonunda iki nokta (`:`), `break` sonunda noktalı virgül (`;`) olduğunu karıştırdım → düzelttim
- `case` içine `if / else` yazılabildiğini öğrendim (sıfıra bölme kontrolü)
- Taşırken fazladan bir bölme satırı kalmıştı (kontrolden önce bölüyordu) → fark edip sildim

## Sonraki adımlar
- [x] İşlem seçimi (+, -, *, /)
- [x] Sıfıra bölme kontrolü
- [x] Hatalı girişleri yakalama (harf girilirse)
- [x] Ondalıklı sayılar (7 / 2 = 3,5)
- [x] Hata durumunda "Sonuç: 0" yazmaması
- [x] Hatalı girişte programı kapatmak yerine tekrar sormak
- [x] Program kapanmadan art arda hesap yapabilmek (döngü)
- [x] Devam sorusunda sadece E/H kabul etmek
- [x] Kodu metotlara bölmek (tekrar eden sayı sorma kodları gibi)
- [x] `if / else if` zincirini `switch`
