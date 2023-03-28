# Dependency-Inversion Özetle Nedir ?
Bağımlılık Tersine Çevirme (Dependency Inversion), yazılım geliştirme sürecinde kullanılan bir prensiptir. Bu prensip, yazılım bileşenleri arasındaki bağımlılıkları azaltmak için tasarlanmıştır.

Bağımlılık Tersine Çevirme prensibi, yüksek seviyeli bileşenlerin düşük seviyeli bileşenlere doğrudan bağımlı olması yerine, her ikisinin de soyutlamalara bağımlı olduğu bir tasarım şeklidir. Bu prensip, yazılım bileşenlerinin birbirlerine olan bağımlılıklarını azaltarak, yeniden kullanılabilirliği artırır ve kodun bakımını kolaylaştırır.

Bu prensibi uygulamak için, soyutlama (abstraction) ve enjeksiyon (injection) tekniklerini kullanmak gerekir. Örneğin, bir üst seviye bileşen (örneğin, bir hizmet) bir alt seviye bileşen (örneğin, bir veritabanı erişim katmanı) kullanması gerektiğinde, bu bağımlılık doğrudan bir şekilde oluşturulmamalıdır. Bunun yerine, üst seviye bileşen, bir arayüz veya soyutlama kullanarak alt seviye bileşene erişmelidir. Bu şekilde, üst seviye bileşen, alt seviye bileşenin iç detaylarından bağımsız hale gelir ve yeniden kullanılabilirliği artırır.

Bağımlılık Tersine Çevirme prensibi, SOLID prensipleri içinde yer alan bir prensiptir ve yazılım tasarımında geniş çapta kullanılmaktadır.


## Diyagram
https://www.gencayyildiz.com/blog/bagimliligin-ters-cevrilmesi-prensibidependency-inversion-principle-dip/bagimliligin-ters-cevrilmesi-prensibidependency-inversion-principle-dip-3/

### Kaynaklar
https://www.gencayyildiz.com/blog/bagimliligin-ters-cevrilmesi-prensibidependency-inversion-principle-dip/
https://altaygencaslan.medium.com/dependency-injection-ve-dependency-inversion-principle-d20578c793b8
