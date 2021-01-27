# .net-core-mvc-Personel-Birim

### Description
```
Projeye öncelikle "Manage NuGet Packages" üzerinden aşağıda vereceğim paketleri yükleyiniz.

1) Microsoft.EntityFrameworkCore

2) Microsoft.EntityFrameworkCore.Design

3) Microsoft.EntityFrameworkCore.SqlServer

4) Microsoft.EntityFrameworkCore.Tools

5) DB bağlantısı için gerekli Context yapısını girmeniz gerekmekte. Bunun için;

5.1) Models>Models içerisinde bulunan "Context.cs" içerisindeki bu satırısı kendi ayarlarınızı giriniz.

5.2) optionsBuilder.UseSqlServer("server=ServerinizinAdı; database=DatabaseAdı; integrated security=true");

6) Proje üzerinde gerekli migration ayarları ve Code Fisrt yapısı kurulmuştur.

6.1) View>Other Windows>Package Manager Console "update-database" dediğiniz. Gerekli adımlar çalışarak DB üzerinde Tablolar oluşacaktır.

```
### SceenShots
![Optional Text](https://github.com/ahmet-yigit/.net-core-mvc-Personel-Birim/blob/main/ss/1.JPG?raw=true)
![Optional Text](https://github.com/ahmet-yigit/.net-core-mvc-Personel-Birim/blob/main/ss/2.JPG?raw=true)
![Optional Text](https://github.com/ahmet-yigit/.net-core-mvc-Personel-Birim/blob/main/ss/3.JPG?raw=true)
