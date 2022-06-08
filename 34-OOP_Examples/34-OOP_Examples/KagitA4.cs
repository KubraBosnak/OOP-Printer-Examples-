namespace _34_OOP_Examples
{
    public class KagitA4 : Kagit  // Kagit sınıfından türeyen A4 Kağıt sınıfıdır
    {
        // 1. YÖNTEM 
        public override int Yukseklik { get { return 30; } }

        public override int Genislik { get { return 21; } }
        
        // 2. YÖNTEM 

        //public KagitA4()  // Constuctor : Kağıdın özelliğini belirtmek için ctor kullanırız.
        //{
        //    //Genislik = 15;
        //    //Yukseklik = 30;
        //}
    }









}
//Printer Örneği
//Bu uygulamada bir yazıcının temel özelliklerini ve davranışlarını nesne olarak tasarlamaya çalışacağız.
//Yazıcı nesnesinde olması beklenen temel özellikler aşağıdaki gibidir;
//•	Marka
//•	Model
//•	Kağıt haznesi
//•	Yazıcı durumu (Açık/ Kapalı)
//Yazıcı nesnesinde olması gereken temel davranışlar aşağıdaki gibidir;
//•	Aç / Kapat
//•	Yazdır()
//•	Kağıt Ekle
//•	Kağıt Çıkar
//“Kağıt” kavramını da bir nesne olarak tasarlayın.
//Kağıt nesnesinin oluşturulacağı sınıfta bulunması gereken başlıca özellikler aşağıdaki gibidir;
//•	Genişlik
//•	Yükseklik
//Yazıcı nesnesi soyut bir sınıf olarak tasarlanmalı. Uygulamanın sonunda “Ev Tipi Yazıcı” ve “Profesyonel Yazıcı” şeklinde iki adet sınıf oluşturulmalıdır. Ev tipi yazıcı yalnızca A4 tipindeki kağıtlarla çalışırken Profesyonel yazıcı birden fazla kağıt tipine baskı alabilecektir.
//Kağıt sınıfını da soyut bir sınıf olarak tasarlayın. Kağıt sınıfından miras alacak gerçek kağıt tipleri “A3, A4 ve A5 olacaktır.” İsterseniz BONUS olarak daha fazla kağıt tipi yazabilirsiniz.
//Dikkat edilmesi gereken hususlar;
//1.Kağıtlar yazıcı içerisinde yalnızca sayı olarak tutulmayacak. (Eğer ki sayı olarak tutmaya kalkarsanız yazıcıdan çıktı alırken “A4” gibi bir kağıt tipinden yeni bir nesne örneği oluşturmanız gerekir. Hiçbir yazıcı kendi kağıdını üretmez!)
//2.Kağıt tiplerinin dünya standartlarında hep aynı genişlik ve yükseklik değerleri olduğunu unutmayın. Bu sebeple Genişlik ve Yükseklik değerleri “yalnızca okunur” tipte özellikler olarak tasarlanmalı. Hiçbir A4 kağıdın genişliği üretildikten sonra değiştirilemez. Eğer ki kağıdı keserseniz artık A4 kağıt olmaz 😊
//3.	Profesyonel yazıcılar birden fazla kağıt tipiyle çalışabiliyor. Kağıt haznelerini tasarlarken bu duruma da dikkat ediniz.
//4.	Yazdırma, kağıt ekleme veya kağıt çıkarma metotlarını yazarken hangi parametreleri alması gerektiğini ve dönüş tiplerini dikkatle seçiniz.
//5.	Yazıcı durumu dışardan doğrudan atanamamalı, Aç veya Kapat metodu aracılığı ile değiştirilebilmeli.
//6.	Çıktı alırken yazıcının durumuna dikkat edilmeli.
//BONUS
//1.	Doğru tasarlandığı sürece abartmak serbesttir 😊

