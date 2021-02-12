using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir","Adana");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2=utilities.BuildList<Customer>(new Customer { FirstName = "Rabia" },new Customer { FirstName = "Hakan" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();

        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)//paramsla parametre sayısını otomatik girebiliyoruz.
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }
    //  tek tek interfacelere benzer özelliklerle belirtmek yerine generic sınıf kullanıp Irepository ile interfaceı mızı oluşturup onlara miras vermemiz bu işin kısa yoludur.
    interface IProductDal : IRepository<Product>
    {
    }
    class Customer
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }
    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class PorductDal : IProductDal
    {//bakın her şey producta göre geldi.
        //mirası IRepository olarakda alabiliriz ama IcustomerDala özel:  ayın en popüler müşterisi özelliği repositoryde bulunmayacağı için oraya eklenemez, hata vermez ama böylesi daha sağlıklıdır.
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
