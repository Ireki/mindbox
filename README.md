# Задание 2

В задании описана связь, которая устанавливается между таблицами в отношении "многие ко многим" и требует использования дополнительной таблицы. В результате, мы имеем следующие таблицы:
- Product (Id, Name)  
- Category (Id, Name)  
- ProductCategory (ProductId, CategoryId)  


Запрос для выбора всех пар «Имя продукта – Имя категории» будет выглядить следующим образом:
``` sql
      select 
             p.Name,
             c.Name
      from Products p
      left join ProductCategory pc on p.Id = pc.ProductId
      left join Category c on pc.CategoryId = c.Id
```
