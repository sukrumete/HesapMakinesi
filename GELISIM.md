# Hesap Makinesi 🧮

C# ile yazılmış basit bir konsol hesap makinesi. C# öğrenme sürecimdeki ilk projem.

## Ne yapıyor?
Kullanıcıdan iki sayı ve bir işlem (+, -, *, /, %, ^) alır, sonucu ekrana yazar.
- Toplama, çıkarma, çarpma, bölme, kalan (%) ve üs alma (^) yapar
- Ondalıklı sayılarla çalışır (7 / 2 = 3,5)
- Program kapanmadan art arda hesap yapılabilir
- Yanlış girişte program kapanmaz, kullanıcıdan tekrar ister:
  - Sayı yerine harf girilirse
  - Geçersiz işlem seçilirse
  - Devam sorusuna E/H dışında bir şey yazılırsa
- Sıfıra bölmeye ya da sıfıra göre kalan almaya çalışılırsa uyarı verir
- Program kapanırken yapılan hesapların geçmişini gösterir
- Hesap geçmişi bir dosyaya (`gecmis.txt`) kaydedilir; program kapatılıp açılsa bile eski hesaplar görünür

```
Birinci Sayıyı giriniz: abc
Lütfen geçerli bir sayı giriniz.
Birinci Sayıyı giriniz: 7
İkinci Sayıyı giriniz: 2
İşlem türünü seçiniz (+, -, *, /, %, ^): x
Lütfen geçerli bir işlem türü giriniz.
İşlem türünü seçiniz (+, -, *, /, %, ^): /
Sonuç: 3,5
Devam etmek istiyor musunuz? (E/H): e
Birinci Sayıyı giriniz: 2
İkinci Sayıyı giriniz: 3
İşlem türünü seçiniz (+, -, *, /, %, ^): ^
Sonuç: 8
Devam etmek istiyor musunuz? (E/H): e
Birinci Sayıyı giriniz: 10
İkinci Sayıyı giriniz: 0
İşlem türünü seçiniz (+, -, *, /, %, ^): /
Bir sayıyı 0'a bölemezsiniz.
Devam etmek istiyor musunuz? (E/H): h
Hesap Geçmişi
7 / 2 = 3,5
2 ^ 3 = 8
Görüşmek üzere!
```

## Kullanılanlar
- C#
- .NET 10

## Nasıl çalıştım?
- Bu projeyi yapay zekâ (Claude) ile soru-cevap şeklinde ilerleyerek yaptım. Her adımda yapay zekâ bana sorular sordu, ipuçları verdi ve kavramları açıkladı.
- Kod satırlarını kendim yazdım. Yapay zekâya kodu yazdırmak yerine, takıldığım yerde ipucu istedim ve hatalarımın nedenini sordum. Bazı yerlerde çözüme çok yakın ipuçları aldım.
- Planı ve fikirleri birlikte oluşturduk. README metinlerini de yapay zekâ ile birlikte düzenledim.
- Her değişiklikten sonra programı kendim test ettim.

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
- Birinci ve ikinci sayıyı alan kodlar neredeyse aynıydı (24 satır) → bunu ve iki blok arasındaki farkları (ekrana yazılan mesaj ve sonucun gittiği değişken) kendim buldum
- Bu blokları `SayiAl` metoduna taşıdım: mesajı **parametre**, sayıyı **return** yaptım, artık 2 satır
- En çok zorlandığım kısım: metot imzasındaki tür ve isim sırası (`double SayiAl(string mesaj)`) ve metodu **tanımlamak** ile **çağırmak** arasındaki fark. Yapay zekâ adım adım sorularla anlattı, çağırma satırını da gösterdi
- Blok silinince `bool gecerli` tanımı da gitti ve CS0103 hatası aldım → değişkeni kullanıldığı ilk yerde yeniden tanımladım
- Refactoring sonrası bütün testleri tekrarladım, program eskisiyle aynı çalışıyor

**Versiyon 6**
- `if / else if` zincirindeki tekrar eden `islem ==` kontrollerini `switch` ile daha düzenli yazdım
- `switch` parantezine karşılaştırma yazmıştım (`switch (islem == "+")`) → yapay zekâ sadece değişken yazıldığını gösterdi
- `case` sonunda iki nokta (`:`), `break` sonunda noktalı virgül (`;`) olduğunu karıştırdım → yapay zekâ fark ettirdi, düzelttim
- `case` içine `if / else` yazılabildiğini öğrendim (sıfıra bölme kontrolü)
- Taşırken fazladan bir bölme satırı kalmıştı (kontrolden önce bölüyordu) → yapay zekâ gösterdi, sildim

**Versiyon 7**
- İşlem seçme kodunu `IslemAl()` metoduna taşıdım (parametresiz, `string` döndüren metot)
- Devam sorusunu `DevamMi()` metoduna taşıdım (`bool` döndüren metot)
- Metotlar V5'te zorlamıştı; bu sefer dönüş türlerini (`string`, `bool`) kendim buldum ve çok daha az yardım aldım
- Metodu çağırırken tanımdaki parantez nasılsa öyle yazılır: `IslemAl()` boş, `SayiAl("...")` dolu
- İlk denemede `return true;` satırını yanlış yere koydum, "h" yazınca da devam ediyordu → yapay zekâ robot gibi adım adım takip etmeyi gösterdi, düzelttim
- `bool` döndüren metodun cevabını değişkene atamayı (`devam = DevamMi();`) yapay zekâdan öğrendim
- Blok silinince `bool gecerli` tanımı yine gitti → bu sefer sorunu kendim fark edip çözdüm

**Versiyon 8**
- Yapılan hesapları saklamak için `List<string>` kullandım (kaç hesap yapılacağı belli olmadığı için boyutu değişebilen liste)
- Listeyi döngünün **içinde** oluşturmayı düşünmüştüm → yapay zekâ her turda yeni, boş liste oluşacağını ve eski hesapların kaybolacağını açıkladı, **dışında** oluşturdum
- `gecmis.Add(...)` satırının yerini kendim buldum: sadece başarılı hesaplar ekleniyor (sıfıra bölme gibi hatalar geçmişe girmiyor)
- Sayıları metinle birleştirerek `"7 / 2 = 3,5"` gibi satırlar oluşturdum (sayı + metin = metin)
- Program kapanırken `foreach` ile geçmişi ekrana yazdırdım
- `foreach` içinde iki yerde farklı isim kullanmıştım (`hesaplar` / `hesap`) → yapay zekâ fark ettirdi, aynı isim olması gerektiğini öğrendim

**Versiyon 9**
- Yeni işlem eklemek için kodda değiştirilmesi gereken yerleri düşündüm: ekrandaki mesajı ve işlem kontrolünü (`IslemAl` içinde) kendim buldum, hesaplamanın `switch` içinde yapıldığını yapay zekâ hatırlattı
- Kalan (`%`) için de sıfır kontrolü ekledim (aksi halde sonuç `NaN`, yani "sayı değil" çıkıyordu)
- C#'ta `^` işaretinin üs almak olmadığını bilmiyordum. Yapay zekâ bana `Math.Pow(taban, üs)` metodunu gösterdi, nasıl kullanıldığını öğrenip uyguladım
- İlk denemede `Math.Pow`'u `+` gibi iki sayının arasına yazdım → yapay zekâ metotların parantez ve virgülle çağrıldığını hatırlattı
- Kontrol satırında `==` yerine `=` yazmışım → yapay zekâ fark ettirdi. V2'de öğrendiğim atama (`=`) ile karşılaştırma (`==`) farkını tekrar karıştırdığımı gördüm

**Versiyon 10**
- Program kapanınca listenin silindiğini, çünkü geçici hafızada durduğunu öğrendim → hesapları kalıcı olarak bir dosyaya kaydettim
- Yapay zekâ `File.AppendAllText` (dosyanın sonuna ekleme) metodunu anlattı; dosyaya yazma satırının yerini kendim buldum: `gecmis.Add` satırının hemen altı (böylece sadece başarılı hesaplar kaydediliyor)
- Her hesabın ayrı satıra yazılması için `"\n"` ekledim; ilk denemede `\n`'i tırnaksız yazmıştım → yapay zekâ metin olarak eklenmesi gerektiğini gösterdi
- Program açılırken eski hesapları okumak için yapay zekâdan `File.Exists` ve `File.ReadAllLines` metotlarını öğrendim
- Okuma kodunun yerini kendim buldum: liste oluşturulduktan sonra, döngüden önce (döngünün içinde olsaydı aynı hesaplar tekrar tekrar eklenirdi)
- Hesapları yine `gecmis` yerine `devam` listesine eklemeye çalıştım ve değişken adına boşluk koydum → yapay zekâ fark ettirdi, düzelttim

**Versiyon 11 (OOP'ye giriş)**
- Sınıf (kalıp), nesne (kalıptan çıkan şey) ve metot (nesnenin yaptığı iş) farkını yapay zekâ benzetmelerle anlattı (kurabiye kalıbı, telefon modeli). Bir Araba sınıfının özelliklerini ve metotlarını kendim düşünerek kavramı oturttum
- Hesap makinesinin asıl işinin "hesaplamak", aklında tuttuğu şeyin de "geçmiş" olduğunu yapay zekânın sorularıyla buldum
- `Hesapla` metodunun girişlerini (iki sayı ve işlem) ve çıkışını (sonuç) kendim buldum, imza satırını yazdım: `double Hesapla(double birincisayi, double ikincisayi, string islem)`
- İlk denemede `double sonuc = new sonuc` ve `return hesapla;` yazdım → yapay zekâ `new`'in sadece nesne oluştururken kullanıldığını ve metodun adını değil kutunun içindekini döndürmem gerektiğini gösterdi
- `switch`'i `Hesapla` metoduna taşıdım. Metodun içinde `hatavar` kırmızı çizgi verdi (metot dışarıdaki değişkeni göremiyor) → yapay zekâ açıkladı. Metot sadece hesaplasın diye sıfır kontrolünü ana programa aldım
- Sıfır kontrolünün koşulunu önce Türkçe cümle olarak kendim kurdum ("işlem / veya % ise VE ikinci sayı 0 ise"), sonra `&&` (ve) ile C#'a çevirdim
- İlk denemede yine `==` yerine `=` yazdım, gereksiz bir `birincisayi == 0` kontrolü ekledim ve `%`'yi unuttum → yapay zekâ boşluk doldurma şeklinde bir kalıp verdi, ben doldurdum. `if / else` bloğunun son birleştirilmiş halini de yapay zekâ gösterdi
- Kendi ilk sınıfımı yazdım (`class HesapMakinesi`) ve `Hesapla`'yı içine taşıdım. Ana programın metodu kullanabilmesi için `public` gerektiğini yapay zekâdan öğrendim
- Sınıftan nesne oluşturmak için `List` satırını örnek aldım: `HesapMakinesi makine = new HesapMakinesi();` İlk denemelerde `new` kelimesini unuttum → yapay zekâ fark ettirdi. Nesneyi döngünün dışına koymam gerektiğini kendim buldum (her hesapta yeni makine üretmek gereksiz)
- Metodu nesne üzerinden çağırdım: `makine.Hesapla(...)` (`gecmis.Add(...)` ile aynı mantık)
- İstenmeyen girişlerle de (harf, geçersiz işlem) ekstra testler yaptım

**Versiyon 12**
- Hesap geçmişini (`Gecmis` listesi) sınıfın **özelliği** yaptım; dosyadan okuma (`GecmisiYukle`) ve kaydetme (`GecmiseEkle`) işlerini de sınıfın metotlarına taşıdım. Ana program artık sadece `makine.` ile sınıfa ne yapacağını söylüyor
- Özellik ile metodu karıştırdım (listeyi `void` ile metot gibi yazdım) → yapay zekâ farkı tablo ile anlattı
- `GecmiseEkle` içinde metodu kendi kendini çağıracak şekilde yazdım (`GecmiseEkle(hesap)`) → yapay zekâ fark ettirdi, `Gecmis.Add(hesap)` olarak düzelttim
- Metot adında Türkçe karakter (`ü`) kullandım, `File.AppendAllText` yazımında hata yaptım → yapay zekâ gösterdi
- Bu versiyonda yapay zekâ çok daha fazla yönlendirme yaptı: her adımda neyi silip neyi ekleyeceğimi madde madde anlattı. Yapay zekâ bir ara kodun tamamını da verdi ama anlamadığım kodu kullanmak istemediğim için yapıştırmadım; adım adım kendim yazdım
- OOP benim için en zor konulardan biri oldu, tekrar ederek oturtmaya devam edeceğim

**Versiyon 13**
- `HesapMakinesi` sınıfını kendi dosyasına (`HesapMakinesi.cs`) taşıdım. `Program.cs`'te sadece ana program kaldı
- Visual Studio'nun hazır sınıf kalıbındaki `namespace HesapMakinesi`, sınıfla aynı isimde olduğu için çakışma yaratacaktı → yapay zekânın önerisiyle kalıbı silip boş dosyaya taşıdım
- İlk denemede sınıfı kesmek yerine kopyaladım, iki dosyada aynı metotlar oldu ve CS0121 ("belirsiz çağrı") hatası aldım → hata mesajındaki dosya ve satır numaralarına bakarak sınıfın Program.cs'te de kaldığını gördüm, sildim

**Ek geliştirmeler**
- Uzun ondalıklı sonuçları `Math.Round(sonuc, 2)` ile 2 basamağa yuvarladım (`0,6666...` → `0,67`). İlk denemelerde basamak sayısını yazmayı unuttum ve `000` yazdım → yapay zekâ ikinci değerin basamak **sayısı** olduğunu açıkladı
- Geçmiş boşsa `Count == 0` ile "Henüz bir işlem yapılmadı." mesajı gösterdim. Yapay zekâ `if / else` yapısını gösterdi, karşılaştırma için `==` kullanmam gerektiğini kendim buldum
- Program kapanırken geçmişi silme seçeneği ekledim: sınıfa `GecmisiTemizle()` metodu yazdım (`Clear()` ve `File.Delete`). İlk denemede liste yerine sınıfın adını kullandım ve tırnakları unuttum → yapay zekâ fark ettirdi
- Aynı E/H sorusunu iki farklı yerde kullanabilmek için `DevamMi` metoduna parametre ekledim: `DevamMi(string soru)`. Bu fikri yapay zekâ önerdi, `SayiAl(string mesaj)` ile aynı mantık olduğunu görünce anladım
- `Console.ReadLine()` satırlarındaki null uyarılarını (`CS8600`) `?? ""` ile giderdim. `??` operatörünü yapay zekâdan öğrendim
- Boş geçmişi test etmek için dosyanın adını geçici olarak değiştirdim, silme özelliğini de "evet" ve "hayır" cevaplarıyla ayrı ayrı test ettim
- Geçmişteki her hesabın başına `DateTime.Now.ToString("dd.MM.yyyy HH:mm")` ile tarih ve saat ekledim. Yapay zekâ `DateTime` ve biçim harflerini (`dd`, `MM`, `HH`...) anlattı; satırı kendim yazdım. Değişikliği sadece sınıftaki `GecmiseEkle` metodunda yaptım.

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
- [x] `if / else if` zincirini `switch` ile yazmak
- [x] İşlem seçme ve devam sorusunu metoda çevirmek (`IslemAl`, `DevamMi`)
- [x] Yapılan hesapların geçmişini tutmak (List)
- [x] Yeni işlemler: kalan (%) ve üs alma (^)
- [x] Hesap geçmişini dosyaya kaydetmek
- [x] Hesaplama kodlarını bir sınıfa taşımak (OOP)
- [x] Hesap geçmişini ve dosya işlemlerini de sınıfın içine taşımak
- [x] Sınıfı ayrı bir dosyaya taşımak (`HesapMakinesi.cs`)
