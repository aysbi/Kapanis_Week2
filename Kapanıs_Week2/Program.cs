#region Soru 1
// 1.Soru: Aşağıdaki çıktıyı yazan bir program.
//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

using System.Drawing;
using System.Threading.Channels;

Console.WriteLine("-----------1.Soru-----------\n");

Console.WriteLine("Merhaba \r\nNasilsin? \r\nIyiyim \r\nSen nasilsin?"); // \r\n ile alt satıra geçmesi sağlanmıştır 
#endregion

#region Soru 2
// 2. soru : Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.
// Bunların değerlerini atayıp , ekrana yazdırınız.

Console.WriteLine("\n-----------2.Soru-----------\n");

string MetinselVeri = "Aysel"; // metinsel veriler string type a atanır
int TamSayiVerisi = 11; // tam sayı tipleri ise int var gibi değişkenlere atanır

Console.WriteLine($"Metinsel veri: {MetinselVeri} ve Sayisal veri: {TamSayiVerisi}"); //süslü parantezler ve dolar işareti kullanılarak
                                                                                      //artı işaretine gerek kalmamıştır
#endregion

#region Soru 3
// 3. soru : Rastgele bir sayı üretip , ekrana yazdırınız.

Console.WriteLine("\n-----------3.Soru-----------\n");

Random random = new Random(); //rastgele bir sayı oluşturmak için yazılan kod
int RastgeleBirSayi = random.Next(); // oluşturulan rastgele sayıyı bir değişkene atıyoruz

Console.WriteLine($"Rastgele uretilmis sayi = {RastgeleBirSayi}");
#endregion

#region Soru 4
// 4. Soru : Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Console.WriteLine("\n-----------4.Soru-----------\n");

Random random1 = new Random(); 
int RastgeleBirSayi1 = random1.Next();

Console.WriteLine($"{RastgeleBirSayi1}'nin 3'e bolumunden kalan {RastgeleBirSayi1%3}'dir"); // %3 rastgele sayının 3 modunu verir 
#endregion

#region Soru 5
// 5. Soru : Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.WriteLine("\n-----------5.Soru-----------\n");

tekrarYas: //döngü tarzı bir veridir goto terimiile kullanıldığında buraya döner

Console.Write("Yasinizi giriniz: ");
string GirilenBilgi = Console.ReadLine(); // karşıdan gelen bilgiyi değişkene atadık
int YasBilgisi; // string olan bilgiyi integera çeviriyoruz

bool TamSayiMi = int.TryParse(GirilenBilgi, out YasBilgisi); //girilen sayının tram sayı olup olmadığını yoksa içinde string içerip içermediği kontrol ediliyor

if (TamSayiMi) // girilen sayı tamsayı ise bool tipi true dönecektir ve bu döngü çalışacaktır
{
    string sonuc1 = YasBilgisi >= 18 ? "+" : "-"; //18e eşit ve büyükse + işareti çıkacaktır küçükse - işareti
    Console.WriteLine(sonuc1);
}
else //girilen değer tamsayı değilse tekrar denettiren bir koddur
{
    Console.WriteLine("Sayisal veri girip tekrar deneyiniz!");
    goto tekrarYas;
}
#endregion

#region Soru 6
// 6. Soru : Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

Console.WriteLine("\n-----------6.Soru-----------\n");

for (int i = 0; i < 10; i++) // for döngüsü 10 defa dönecek ve içindeki kodu işleyecektir
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
#endregion

#region Soru 7
// 7. Soru : Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("\n-----------7.Soru-----------\n");

Console.WriteLine("Avrupa Yakasinda Asli karakterini kim canlandirmaktadir: ");
string BirinciMetinselDeger = Console.ReadLine();

Console.WriteLine("Bahar dizisindeki Bahar karakterini kim canlandirmaktadir: ");
string IkinciMetinselDeger = Console.ReadLine();

string GeciciMetinselDeger = BirinciMetinselDeger; //ilk girilen değeri temperory yani geçici bir string değişkenine atıyoruz ki değer değişim olurken kaybolmasın
BirinciMetinselDeger = IkinciMetinselDeger;
IkinciMetinselDeger = GeciciMetinselDeger;

Console.WriteLine($"Yerleri degistirdik => Birinci girilen kisi: {BirinciMetinselDeger} \r\nIkinci girilen kisi: {IkinciMetinselDeger}");
#endregion

#region Soru 8
// 8. Soru : Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
// Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

Console.WriteLine("\n-----------8.Soru-----------\n");

static void BenDegerDondurmem() // metot void yani değer döndürmeyendir çağırıldığında konsola değer yazdırır
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma!");
}

BenDegerDondurmem();
#endregion

#region Soru 9
// 9. Soru : İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

Console.WriteLine("\n-----------9.Soru-----------\n");

static int ToplamaIslemi(int Sayi1, int Sayi2) // girilen sayıları toplayıp integer olarak geri döndürür 
{
    return Sayi1 + Sayi2;
}

Console.Write("Toplamak istediginiz birinci sayiyi giriniz: ");
int Sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Toplamak istediginiz ikinci sayiyi giriniz: ");
int Sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Sayi1} ve {Sayi2} toplam sonucu: {ToplamaIslemi(Sayi1, Sayi2)}"); // metot burada çağırılmıştır girilen sayılar için

#endregion

#region Soru 10
// 10. Soru : Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

Console.WriteLine("\n-----------10.Soru-----------\n");

static string TrueOrFalse(bool GirilenDeger) // girilen boolean değeri stirng olarak geri döndürür 
{
    return Convert.ToString(GirilenDeger); ;
}

Console.WriteLine("Lutfen True yada False degerlerinden birini giriniz: ");
bool Girilen = Convert.ToBoolean(Console.ReadLine().Trim().ToLower()); // girilen değeri booleana çevirir burada trim yanlarki boşluğu kesmek içindir
                                                                       // tolower ise ise girilen büyük harfleri küçültüp error vermemesi içindir

Console.WriteLine($"Hangi degeri girdiginizi ekranda gorunuz: {TrueOrFalse(Girilen)}");
#endregion

#region Soru 11
// 11. Soru : 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

Console.WriteLine("\n-----------11.Soru-----------\n");

static int EnBuyukKim(int Yas1, int Yas2, int Yas3) // girilen 3 kişinin yaşını karşılaştırmak için yazılan integer olarak geri dönen metot
{
    int EnYasli = 0; // en başta sıfır olarak atanan değişken daha sonrasında en büyük sayıyla geri dönecektir

    if (Yas1 > Yas2 && Yas1 > Yas3) // yas1 için sıralama konumuna bakar 
        EnYasli = Yas1;
    else if (Yas2 > Yas3) // yas1 her türlü elenmiştir o yüzden yas2nin sıralamadaki konumu yas3e göre bakılır
        EnYasli = Yas2;
    else
        EnYasli = Yas3; // hiçbir koşul sağlanmazsa yas3 enyaslı klasörüne atanarak enyaslı olarak geri ödner  
    return EnYasli;
}

Console.WriteLine("Birinci kisinin yasini giriniz: ");
int yas1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ikinci kisinin yasini giriniz: ");
int yas2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ucuncu kisinin yasini giriniz: ");
int yas3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Girilen yaslardan en buyugu: {EnBuyukKim(yas1, yas2, yas3)}");
#endregion

#region Soru 12
// 12. Soru:  Kullanıcıdan sınırsız sayıda sayı alıp ,
// bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

Console.WriteLine("\n-----------12.Soru-----------\n");

bool DevamMiTamamMi = true; 
int sayac = 0;
int KarsilastirilacakSayilar;
int EnBuyukSayi = 0;

while (DevamMiTamamMi) //sınırsız sayıda sayı almak için true olarak başlatılır ve devam edilir 
{
    sayac++;
    Console.WriteLine($"{sayac}. Sayiyi giriniz ve en büyük sayıyı öğrenmek için bir harfe basınız: "); //istenilen sayı kaçıncı sayı olduğu gösterilerek
                                                                                                        //konsolda karşıdan istenir
    string Sayii = Console.ReadLine();
    
    bool DevamMi = int.TryParse(Sayii, out KarsilastirilacakSayilar); // eğer girilen değer bir sayı değilse 1. if else bloğunda else kısmına girer
                                                                      // ve enbüyük sayıyı konsola yazıp döngüyü bitirir
  
    if (DevamMi) 
    {
        if (KarsilastirilacakSayilar > EnBuyukSayi) // ilk gelen sayı her türlü enbüyük sayı seçilir daha sonrasında bu ikinci if else bloğunda
                                                    // ise gelen ikinci sayı önceki sayı ile karşılaştırılır eğer en büyük sayı oysa yeni değer o olur 
            EnBuyukSayi = KarsilastirilacakSayilar; 
        else // ama eğer en büyük sayı o değilse kod continue ile bir işlem yapmadan devam eder
            continue;
    }
    else
    {
        Console.WriteLine($"Girdikleriniz arasindan en buyuk sayi =  {EnBuyukSayi}");
        DevamMiTamamMi = false; //burada while içindeki boolean false yapılır ki döngü bitsin
    }
    
}

#endregion

#region Soru 13
// 13. Soru : Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.WriteLine("\n-----------13.Soru-----------\n");

Console.WriteLine("Bir isim giriniz: ");
string Isim1 = Console.ReadLine();

Console.WriteLine("Bir isim daha giriniz: ");
string Isim2 = Console.ReadLine();

Degis(ref Isim1, ref Isim2);

Console.WriteLine("Giris siralari degistirilmis hali: " + Isim1 + Isim2);

static void Degis(ref string isim1, ref string isim2) //bu metot dönmeyen metot ama bir şekilde isimleri değiştirip bunu dışarıya yansıtması lazım
                                                      //ref metot içinde yapılan değişikliklerin, metot dışında da etkili olmasını sağlar.
{
    string temp = isim1;
    isim1 = isim2;
    isim2 = temp;
}
#endregion

#region Soru 14
//14. soru : Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.WriteLine("\n-----------14.Soru-----------\n");

static bool TrueMuFalseMi (int a) //sayı çift ise true döner tek ise false dönen bir metot
{
    if (a % 2== 0)
        return true;
    else
        return false;
}

Console.WriteLine("Sayiyi giriniz: ");
int SAYI = Convert.ToInt32(Console.ReadLine());

if (TrueMuFalseMi(SAYI))
    Console.WriteLine("Girilen sayi cifttir.");
else
    Console.WriteLine("Girilen sayi tektir.");
#endregion

#region Soru 15
// 15. Soru: Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.WriteLine("\n-----------15.Soru-----------\n");

static int YolHesabi( int hiz,  int zaman) //bu metot hız ve zaman tam sayılarını alıp bunu yol ile geri verir
{
    return hiz * zaman;
}

Console.WriteLine("Hiz ve zamani giriniz: ");
int Hiz  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
int Zaman = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gidilen yol: " + YolHesabi(Hiz, Zaman));

#endregion

#region Soru 16
//16. Soru: Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.WriteLine("\n-----------16.Soru-----------\n");

static double DaireninAlani (int r) //dairenin yarıçapını alıp bunu pi sayısı ile çarpıp karesini alarak alanını hesaplar
{
    return Math.PI * r * r;
}

int r = 8;
Console.WriteLine($"Yaricapi {r} olan bir dairenin alani {DaireninAlani(r)}");

#endregion

#region Soru 17
// 17.Soru : "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
Console.WriteLine("\n-----------17.Soru-----------\n");

string Soz = "Zaman bir GeRi SayIm";
Console.WriteLine(Soz.ToLower()); //tolower fonksiyonu hepsini küçük harf ile yazdırır
Console.WriteLine(Soz.ToUpper()); //toupper ise hepsini büyük harf yapar

#endregion

#region Soru 18
// 18. Soru : "   Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
Console.WriteLine("\n-----------18.Soru-----------\n");

string Selam = "   Selamlar   ";
Selam = Selam.Trim(); //trim fonksiyonu gereksiz boşlukları siler

Console.WriteLine(Selam);

#endregion