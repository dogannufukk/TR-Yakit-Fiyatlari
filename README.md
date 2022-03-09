
# TR-Yakit-Fiyatlari

# V1 #
  Türkiye'deki Petrol Ofisi, BP, Opet firmalarına ait yakıt fiyatlarını anlık ve toplu olarak çekmeyi sağlar.
  
  # Kullanılan Teknolojiler
  - .Net Core
  - MSSQL
  - EntityFrameworkCore
  
  # Patterns
  - UnitOfWork & Repository Design Pattern

  # Kullanım
  - Projeyi kullanılabilir hale getirmek için öncelikle veri tabanını oluşturmanız gerekmektedir.
  - Bunun için Update-Database komutunu çalıştırarak veri tabanınızda ilgili tabloların oluşmasını sağlayabilirsiniz.
  - Veri tabanı bağlantı yolunu API projesi içerisindeki appsettings.json dosyası içerisinden değiştirebilirsiniz.


# V2 İçin Planlananlar #
- Çekilen dataların görüntülenmesi için server-side pagination yapısının geliştirilmesi.
- Background-service ile apilerin 24 saatte bir çekilip sisteme yazılmasının sağlanması.
- Dataların görüntülenmesi ve yönetilmesi için bir arayüz tasarlanması ve api ile bağlantısının sağlanması.


# Ekran Ön Tasarım Çalışması
![image](https://user-images.githubusercontent.com/42574385/157512590-802f6272-2bbd-4567-8318-4eed8587654f.png)

# Filtreleme mekanizması
![image](https://user-images.githubusercontent.com/42574385/157512512-6a918647-8dbc-4416-8fa2-c7b6a820600b.png)



