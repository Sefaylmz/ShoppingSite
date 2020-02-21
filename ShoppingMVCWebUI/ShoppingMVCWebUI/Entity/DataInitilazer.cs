using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingMVCWebUI.Entity
{
    public class DataInitilazer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){ Name="Phone", Description="Telefon" },
                new Category(){ Name="Notebook", Description="Computer, Notebook" },
                new Category(){ Name="Elektronik", Description="Elektronik Ürünleri" },
                new Category(){ Name="Beyaz Eşya", Description="Beyaz eşya ürünleri" }
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>()
            {
                new Product(){ Name="iPhone 11", Description="iPhone 11 teknik özellikleri Ekran: 6,1 inç LCD ekran, 828 x 1792 piksel – 326 ppi İşlemci: Apple A13 Bionic RAM: 4 GB RAM Depolama: 64 / 128 / 256 GB Ana Kamera: 12 Megapiksel, f / 1.8 geniş açılı ana kamera, 12 Megapiksel f/ 2.4 ultra geniş açılı kamera – OIS / PDAF Ön Kamera: 12 Megapiksel Yeni TrueDepth kamera, f/ 2.2 diyafram Pil: 3110 mAh, 18W hızlı şarj, Qi kablosuz şarj İşletim Sistemi: iOS 13 Bağlantı: Wi - Fi 802.11 a / b / g / n / ac, Bluetooth 5, NFC,A - GPS, GLONASS, GALILEO, QZSS Boyut ve Ağırlık: 150.9 x 75.7 x 8.3 mm ve 194 gram", Stock=1, IsApproved=true, Price=10200 , categoryId=1, IsHome=true, Image="https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone11-select-2019-family?wid=882&hei=1058&fmt=jpeg&qlt=80&op_usm=0.5,0.5&.v=1567022175704"},
                new Product(){ Name="iPhone XR", Description="White 64 GB", Stock=1, IsApproved=true, Price=8150, categoryId=1, IsHome=true, Image="https://www.jasemx.com/wp-content/uploads/2019/10/IPhone-XR.jpg"},
                new Product(){ Name="Alienware", Description="17 R5", Stock=1, IsApproved=true, Price=15340, categoryId=2, IsHome=true, Image="https://images-na.ssl-images-amazon.com/images/I/51-fjP2WZyL._AC_SY355_.jpg"},
                new Product(){ Name="Macbook Air", Description="14 inc screen", Stock=1, IsApproved=true, Price=7120, categoryId=2,  IsHome=true, Image="https://news-cdn.softpedia.com/images/news2/14-Inch-MacBook-Air-Possibly-Headed-to-China-2.jpg"},
                new Product(){ Name="Camera", Description="Canon 17d", Stock=1, IsApproved=true, Price=3340, categoryId=3, IsHome=false, Image="https://www.dpreview.com/files/p/articles/4325164765/images/frontpage.jpeg"},
            };
            foreach (var item in products)
            {
                context.Products.Add(item);

            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}