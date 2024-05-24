Bu projede potansiyometreden gelen verileri gösterme,inceleme ve kaydetme yapılması amaçlanmıştır.C# Form arayüzü seçilmesi en anlaşılır arayüz olduğu için C# tercih edilmiştir.
İçinde bulunan progressBar,textBox,trackBar,buton,radialgauge,digitalgauge,comboBox araçları kullanılmıştır.
Arudino USB entegresi bilgisayara bağlandıktan sonra combobox'ta gözükmesi sağlanmıştır.Bağlan ve Bağlantıyı kes butonları ile COM bağlantısı kontrolü yapılmıştır.
2 potansiyometre kullanıldığı için veriler ayrılarak kullanılmıştır.2 veri farklı durumları temsil edebilir.
Kaydet butonu ile birlikte gelen veriyi anlık olarak metin dosyasına aktarma yapılabilmiştir.
Gelen 2 veriyi de farklı RadialGauge'lere yansıtılmıştır.DigitalGauge 1 Adet kullanılmıştır isteğe göre 2 veri geldiği için 2 adet kullanılabilir.Benim tercihim RadialGauge olmuştur.
Yine trackbarda da değer artarsa radialGauge'ye yansıması olacaktır.Ancak ana konsept potansiyometre ile gauge gösterimidir.
Arduinoda bulunan    //15 milisaniye gecikme süresi 
                    delay(15);                             kısmında bulunan 15 milisaniye delay ise 15 milisaniyeden daha fazla delay koyduğum zaman RadialGaugelerde tepki süresi çok gecikti
deneyerek en iyi süreyi bulmaya çalıştım ve 15 milisaniyede optimum çalıştığına kanaat getirdim.

RadialGauge göstergeleri döner ibre sıfatında olduğu için görsel ve sınıfı eklemeyi bu linkten gelen bilgilere göre düzenledim.
https://help.syncfusion.com/windowsforms/radial-gauge/radial-gauge




