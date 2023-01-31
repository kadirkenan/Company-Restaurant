# Company Restaurant Projesi
Bilge Adam Bitirme Projesidir.

## Projenin Mimarisi
- Codefirst yaklaşımı ile oluşturulmuştur.
    ```
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DataAccess.Entity 
    {
        public class MenuProduct:BaseEntity
        {
            public string MenuName { get; set; }
            public bool Selected { get; set; }
            public int MenuCategoryId { get; set; }
            public string Description { get; set; }
            public int MenuPrice { get; set; }
            public bool StockStatus { get; set; }
            public string MenuImagePath { get; set; }
            public int Unit { get; set; }
            public int StorageProductUnits { get; set; }
            public virtual MenuCategory MenuCategory { get; set; }
        }
    }
    ```
- MVC (Model-View-Controller) mimarisi kullanılmıştır.
- User register ve rol modelleri oluşturuldu.

## Projenin özellikleri
- Bir restaurantın ihtiyacı olan stok takibi, menü takibi, masa takibi, hesap takibi gibi kısımları desteklemektedir.
- Rol bazlı admin,chef,waiter,warehouseattendant için belli yetkiler ve yetkinlikleri desteklemektedir.
