# SomeBoxes2

# Developer : Timur Gündoğdu, 16.03.2021

Proje code first mantığı ile oluşturulduğundan , çalıştırmak için kısa notlarım var. 

- Sql Server üzerinde boxdb isimli bir veritabanı oluşturulmalıdır.
- SomeBoxes.DataLayer projesinin içindeki App.Config içinde connection stringden istenirse veritabanı yolu ve adı değiştirilebilir.
- SomeBoxes.DataLayer projesi "Set as startup project" olarak seçilir.
- Tool \ Nuget Package Manager \ Package Manager Console açılır.
- "Update-Database -verbose" komutu ile veritabanında ilgili tablolar oluşturulur. 2 adet tablo oluşturur. Boxes ve BoxReadies.
- console uygulaması çalıştırıldığında, istenen çözüm veritabanındaki BoxReadies tablosuna yazılır.
