using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},

            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=15},
                new Product{ProductId=5, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitsInStock=0},
            };
            //  Test(products);
            //  GetProducts(products);
            //  AnyTest(products);
            //  FindTest(products);
            //  FindAllTest(products);
            //  AscDescTest(products);

            //birinci kullanım
            Console.WriteLine("-------Birinci Kullanım--------");

            var result = from p in products//productaki her bir pden from den dan
                         select p;//her bir pnin şarta uyanları ekliyor.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName );//bu şekilde yazdırabiliriz
            }

            //ikinci kullanım 
            Console.WriteLine("-------İkinci Kullanım---------");
            var resultt = from p in products
                          where p.UnitPrice > 6000
                          select p;
            foreach (var product in resultt)
            {
                Console.WriteLine(product.ProductName);
            }
            //order by kullanımı
            Console.WriteLine("-------OrderBy Kullanım--------");

            var sonuc = from p in products
                        where p.UnitPrice > 6000
                        orderby p.UnitPrice descending //büyükten küçüğe doğru sıralar descendingi hiç yazmazsak tam tersi olur.
                        select p;
            foreach (var product in sonuc)
            {
                Console.WriteLine(product.ProductName);//Acer Laptop, Asus Laptop,Apple Telefon çıktı bunlar olur
            }
            //ascending kullanımı
            Console.WriteLine("-------Ascending Kullanım--------");

            var sonucc = from p in products
                        where p.UnitPrice > 6000
                        orderby p.UnitPrice descending,p.ProductName ascending //ilkini yapıp sonra ikincisini yazdırır
                        select p;
            foreach (var product in sonucc)
            {
                Console.WriteLine(product.ProductName);//Acer Laptop,Apple Telefon, Asus Laptop çıktısı bu olur (yukarıdan aşağıya)
            }
            Console.ReadKey();
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single Line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);//Order.By yazarsam  aslında order Order.ByAscending tir bu ascending=yükselen yani düşükten yükseğe doğru yazdırır.OrderByDecending dersem de yüksekten aşağı doğru sıralar descending=alçalan demektir.
            //Then by =ondan sonra alfabetik sıranın ters yönünde sıralama yapar.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);//içinde top olan kelimeleri yazdıracak
                Console.WriteLine(product.UnitPrice);


            }
            // Console.WriteLine(result);//System.Linq.Enumerable+WhereListIterator`1[LinqProject.Product] çıktısı budur.
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));//yine bir sorgu içerir
                                                                              /* FindAll()List<T>tür üzerinde bir fonksiyondur , gibi bir LINQ genişletme metodu değildir Where. LINQ genişletme yöntemleri, 
                                                                               * uygulayan herhangi bir tür üzerinde çalışır IEnumerable, ancak FindAllyalnızca List<T>örneklerde (veya elbette ondan devralan sınıfların örneklerinde) kullanılabilir.*/
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);//ürünlerde top bulunanları yazdırır.
            }
            Console.WriteLine(result);//System.Collections.Generic.List`1[LinqProject.Product] çıktısıdır.
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);//aradığımız kritere uygun nesnenin kendini verir.
           
            Console.WriteLine(result); //Çıktısı LinqProject.Product olur.Biz gerçek hayatta bunu nasıl kullanırız bir ürünün detayına gitmek isteriz.
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Dell Laptop");//any ile bir listenin içerisinde eleman var mı yok mu onu ararız.
            Console.WriteLine(result);//çıktı ya true ya false olur.
        }

        private static void Test(List<Product> products)
        {
            //Normalde listelemeyi böyle yaparız
            Console.WriteLine("-----------Algoritmik-----------");
            foreach (var product in products)
            {
                //Console.WriteLine(product.ProductName);
                //Ben şimdi fiyatı 8 bin tlden büyük olan ürünleri listelemek istersem ve stock adeti 4ten büyük olanları
                if (product.UnitPrice >= 8000 && product.UnitsInStock > 4)
                {
                    Console.WriteLine(product.ProductName + " " + product.UnitPrice);
                }
            }
            Console.WriteLine("-----------Linq-----------");

            var result = products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 4);//Yukarıdaki sorgu datasını buraya yazmış olduk.

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //Eğer linq yoksa işin içinde bunu yazmamız gerekir. 
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                //Console.WriteLine(product.ProductName);
                //Ben şimdi fiyatı 8 bin tlden büyük olan ürünleri listelemek istersem ve stock adeti 4ten büyük olanları
                if (product.UnitPrice >= 8000 && product.UnitsInStock > 4)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        //Linq olsaydı
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 4).ToList();//array tabanlı olduğu için liste çeviriyoruz.
        }

        /* static List<Product> GetProducts()//burdaki amaç kategori ve ürünleri filtrelemek yani listelemek.
        {

        } */

     
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
       
    }
}
