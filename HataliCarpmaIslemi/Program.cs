using System;

namespace HataliCarpmaIslemi
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu alıştırmada sizden istenen yanlış çarpma ve toplama işlemi yapan programı tasarlamanız.

            //Bu senaryo üzerinde şekillenen alıştırmanız belirli kriterlerden oluşmaktadır;

            // Çarpma işleminin hatası sayıları bir basamak sola kaydırmıyor oluşudur,
            // Toplama işleminin hatası ise bir basamaktaki toplam sayı 10’nu geçerse diğer basamağa herhangi bir sayı aktarmıyor oluşudur,
            // Çarpan1 ve Çarpan2nın boş geçilememesi gerekiyor ve İkinci sayının basamak sayısı 3’ten büyük olamaz.
            // Konunun daha iyi anlaşılması için aşağıdaki örneği inceleyiniz.


            // 211  // Kullanıcı tarafından girilen ilk sayı

            // 33 // Kullanıcı tarafından girilen ikinci sayı

            //X_____

            //             633// Bir basamak sola kaydırılmıyor

            //             633

            //         + _____

            //             266 // Örneğin 6+6=12. Sonuç 10’u geçti. Elde var 1 kısmı diğer basamağa aktarılmadı.

            //Sonuç: 266 olmalıdır.





           
            /*1:Başla
             * 2:ekrana kullanıcıyı selamlama mesaji yazdır
             * 3:Kullanıcıdan 0dan farklı bir sayı girmesini iste
             * 4:eğer sayı girdiyse adım 6ten devam et
             * 5:aksi halde adım3e dön
             * 4:Eğer sayı 0sa ekrana bilgi mesajı ver ve adım 3e dön
             * 5:Kullanıcıdan maximum 3 basamaklı 2. sayıyı iste
             * 6:Eğer sayı girdiyse 8. adıma git
             * 7:Eğer sayı girmediyse bilgi mesajı ver ve 5. adıma dön
             * 8: sayı -1000 ve +1000 arasındaysa 9 adıma devam et
             * 9: aksi halde bilgi ver 5. adıma dön
             * 10: 2. sayının mod10'unu alarak birler basamağını bul
             * 11:2. sayıyı 100e bölerek yüzler basamağını bul.
             * 12:2. sayıdan yüzler basamağındaki rakamın 100 le çarpımını çıkartarak sadece 2 basamak kalmasını sağla, daha sonra 10a bölerek onlar basamağını bul
             * 13: 2. sayının birler basamağı ile 1. sayıyı çarp
             * 14: 2. sayının onlar basamağı ile 1. sayıyı çarp
             * 15: 2. sayının yüzler basmağı ile 1. sayıyı çarp
             * 16: bir sayac tanımlayıp 0 ata, ve 1 elemanlı bir dizi tanımla
             * 17:Bu çarpımların son basamaklarından başlayarak toplama işlemi yap ve her seferinde mod10 al çıkan sonucu oluşturduun diziye sayac indeksiyle at ve carpımların hepsini 10'a bölerek son basamaklarını sil, sayacı 1 arttır, dizinin boyutunu 1 arttır
             * 18:bu döngü sonucunda 3 çarpım sonucununda basamak sayısı 1 e düştüğü anda son toplama işlemini yap modunu al ve dizinin uzunluğunun -1. indeksine ata
             * 19: diziyi tersine çevir
             * 20: foreach döngüsü ile diziyi ekrana yazdır.
             * 21:bitir.
             * 
             */



            Selamlama();
            KullanicidanİlkSayiAl(out int sayi1);
            KullanicidanIkinciSayiAl(out int sayi2);
            // 2. sayının Birler basamağını mod 10 ile alıyoruz
            Sayi2BirlerBasamagiBul(sayi2);
            // 2. sayının Yüzler basamağını sayiyi 100'e bölerek alıyoruz
            Sayi2YuzlerBasamagiBul(sayi2);
            // 2. sayının yüzler basamağındaki rakamı 100 ile çarpıp sayımızdan çıkardıktan sonra 10a bölerek onlar basamağını öğreniyoruz
            Sayi2OnlarBasamagiBul(sayi2);
            //2. sayının birler basmağı ile 1. sayıyı çarpıyoruz
            CarpBirlerBasamagi(sayi1, Sayi2BirlerBasamagiBul(sayi2));
            //2. sayının onlar basamağı ile 1. sayıyı çarpıyoruz
            CarpOnlarBasamagi(sayi1, Sayi2OnlarBasamagiBul(sayi2));
            //2. sayının yüzler basamağı ile 1. sayıyı çarpıyoruz
            CarpYuzlerBasamagi(sayi1, Sayi2YuzlerBasamagiBul(sayi2));
            //çıkan sonuçların basamaklarını kaydırmadan toplamak ve eldeyi hesaba katmamak için önce ToplamaYapELdesiz metodu oluşturuyoruz. carpımları toplayıp modunu alarak son rakamı öğreniyoruz.
            //Daha sonra aşağıdaki metodu oluşturup bu metotta her basamağın son rakamını mod alarak öğrendikten sonra sayılarımızı 10'a bölerek 3 sayımız da tek basamak kalana kadar while döngüsü ile son basamaklarını eksiltiyoruz.Her eksiltme sırasında 0 dan başlattığımız sayac vasıtasıyla basamakları toplamının modunu aldığımız yani son basamağını öğrendiğimiz rakamı boyutunu dinamik yaptığımız(içine eleman geldikçe büyüyen) dizimize atıyoruz. Böylece dizimiz toplam sonucumuzun rakamlarının tersten dizilmiş haliyle oluşmuş oluyor. son olarak dizimizi ters çevirip ekrana yazdırarak istenen sonucu ekrana yazdırıyoruz. 

            EldesizToplayipDiziyeAtVeYazdir(CarpBirlerBasamagi(sayi1, Sayi2BirlerBasamagiBul(sayi2)), CarpOnlarBasamagi(sayi1, Sayi2OnlarBasamagiBul(sayi2)), CarpYuzlerBasamagi(sayi1, Sayi2YuzlerBasamagiBul(sayi2)));
            Console.WriteLine();
            Kapanıs();
            Console.ReadLine();

            //    211                      9999                       44
            //     33                       999                       33
            //------------------------------------------------------------------
            //    633                     89991                      132    
            //    633                     89991                      132
            //                            89991
            //    266                     47773                      264
        }

        private static void Kapanıs()
        {
            Console.WriteLine("Umarım farklı bir deneyim olmuştur. Yine Bekleriz...");
        }

        public static void EldesizToplayipDiziyeAtVeYazdir(int carpim1, int carpim2, int carpim3 = 0)
        {
            int[] carpimBasamaklari = new int[1];
            int sayac = 0;
            while (carpim1 > 9 || carpim2 > 9 || carpim3 > 9)
            {
                carpimBasamaklari[sayac] = ToplamaYapEldesiz(carpim1, carpim2, carpim3);
                carpim1 /= 10;
                carpim2 /= 10;
                carpim3 /= 10;
                Array.Resize(ref carpimBasamaklari, carpimBasamaklari.Length + 1);
                sayac++;
            }
            carpimBasamaklari[carpimBasamaklari.Length - 1] = ToplamaYapEldesiz(carpim1, carpim2, carpim3);

            Array.Reverse(carpimBasamaklari);
            foreach (int basamak in carpimBasamaklari)
            {
                Console.Write(basamak);
            }
        }

        public static int ToplamaYapEldesiz(int carpim1, int carpim2, int carpim3 = 0)
        {
            return (carpim1 + carpim2 + carpim3) % 10;
        }

        private static int CarpYuzlerBasamagi(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public static int CarpOnlarBasamagi(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public static int CarpBirlerBasamagi(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public static int Sayi2OnlarBasamagiBul(int sayi2)
        {
            return (sayi2 - (100 * Sayi2YuzlerBasamagiBul(sayi2))) / 10;
        }

        public static int Sayi2YuzlerBasamagiBul(int sayi2)
        {
            return sayi2 / 100;
        }

        public static int Sayi2BirlerBasamagiBul(int sayi2)
        {
            return sayi2 % 10;
        }

        private static int KullanicidanIkinciSayiAl(out int sayi2)
        {
            sayi2Gir: Console.WriteLine("Lütfen çarpacağın sayılardan ikincisini  girer misin? Kafamın karışmaması en fazla 3 basamaklı olsun");
            bool sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);
            if (sonuc2)
            {
                if (sayi2 < 1000 && sayi2 > -1000)
                    return sayi2;
                else
                {
                    Console.WriteLine(" Sayiniz en fazla 3 basamaklı olabilir");
                    goto sayi2Gir;
                }
            }
            else
            {
                Console.WriteLine("Ama sayı girmen gerekiyor napiyim alfabeyi mi çarpıp toplayım");
                goto sayi2Gir;
            }
        }

        private static int KullanicidanİlkSayiAl(out int sayi1)
        {
            sayi1Gir: Console.WriteLine("Lütfen çarpacağın sayılardan ilkini girer misin? ");
            bool sonuc1 = int.TryParse(Console.ReadLine(), out sayi1);
            if (sonuc1)
            {
                if (sayi1 == 0)
                {
                    Console.WriteLine("0'ı neyle çarparsan çarp 0, Tekrar dene");
                    goto sayi1Gir;
                }
                else
                    return sayi1;
            }
            else
            {
                Console.WriteLine("Ama sayı girmen gerekiyor napiyim alfabeyi mi çarpıp toplayım");
                goto sayi1Gir;
            }
        }

        private static void Selamlama()
        {
            Console.WriteLine("Merhaba!Değişik bir Çarpma İşlemi deneyimi için hazırsan başlayalım");
        }
    }
}
