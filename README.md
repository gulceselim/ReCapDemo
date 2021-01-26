# Yazılım Geliştirici Kampı

## Odev : ReCapDemo
Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz.

## Gereksinimler
1. Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

2. Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3. Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4. Satışlarda kampanya entegrasyonunu simule ediniz.


## N - Katmanlı Mimari
- Her katmanda; soyut classları tutuğum bir **Abstract** klasörü ve somut classları tuttuğum **Concrete** klasörü bulunmaktadır. Araştırmalarımdan yola çıkarak bu katmanlarımın her birini class library ile oluşturdum ve DataAccess katmanımı Entities katmanı ile, Business katmanımı DataAccess katmanı ile, UI Katmanımı Business katmanı ile ilişkilendirdim. Bunları niye yaptığım aşağıda daha ayrıntılı bir şekilde anlatmaya çalıştım. 


### Entities Katmanı
- Bu katmanda proje boyunca kullanacağımız ana classlarımızı belirliyoruz yani gerçek nesnelerimizi belirlediğimiz yer burası. Bunun dışında IEntity interface'i oluşturdum. Bu interface bütün gerçek nesnelerimin referansını tutuyor.
#### Gerçek Sınıflarım (Concrete Class)
1. [Player.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Entities/Concrete/Player.cs)
2. [Person.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Entities/Concrete/Person.cs)
3. [Game.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Entities/Concrete/Game.cs)

#### Soyut Sınıflarım (Abstract Class)
1. [IEntity.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Entities/Abstract/IEntity.cs)
    
### Business Katmanı
  - Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. Biz uygulamalarımızda Data Access katmanını direk olarak kullanmayız. Araya Business katmanını koyarak bizim yerimize Business’ın yapmasını sağlarız. Kullanıcıdan gelen veriler öncelikle Business katmanına gider oradan işlenerek Data Access katmanına aktarılır. Yukarıda neden business katmanını DataAccess katmanı ile ilişkilendirdiğimi daha iyi anlamışınızdır.
  
#### Gerçek Sınıflarım (Concrete Class)
1. [GameManager.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Concrete/GameManager.cs)
2. [PlayerManager.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Concrete/PlayerManager.cs) - Bu classımda kişilik kontrolü yapıyorum eğer o kontrolden geçerse DataAccess katmanındaki işlemlerini gerçekleştiriyorum.
3. [SteamPlatformManager.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Concrete/SteamPlatformManager.cs)
4. [WinterSalesManager.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Concrete/WinterSalesManager.cs)
5. [PersonCheckManager.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/ValidationRules/Concrete/PersonCheckManager.cs)
  
#### Soyut Sınıflarım (Abstract Class)
1. [IGameService.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Abstract/IGameService.cs)
2. [IPlatformService.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Abstract/IPlatformService.cs)
3. [ISalesService.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Abstract/ISalesService.cs)
4. [IPlayerService.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/Abstract/IPlayerService.cs)
5. [IPersonCheckManager.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Business/ValidationRules/Abstract/IPersonCheckService.cs)

  ####
### DataAccess Katmanı
  - Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. Bu katmanda bu işlemlerden başka herhangi bir işlem yapılmamaktadır.
#### Gerçek Sınıflarım (Concrete Class)
1. [DatabaseLoggerService.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.DataAccess/Concrete/DatabaseLoggerManager.cs)
2. [FileLoggerService.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.DataAccess/Concrete/FileLoggerManager.cs)

#### Soyut Sınıflarım (Abstract Class)
1. [ILoggerService](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.DataAccess/Abstract/ILoggerService.cs)
  
### UI (Sunum Katmanı)
  - Bu katman kullanıcı ile etkileşimin yapıldığı katmandır. Ben Console uygulaması yaptığım için adına Console koydum fakat bu Windows Form uygulamasıda olabilir veya bir Web projesi olabilirdi.
#### Gerçek Sınıflarım (Concrete Class)
1. [Program.cs](https://github.com/gulceselim/ReCapDemo/blob/master/YoutubeProject.ReCapDemo.Console/Program.cs)
