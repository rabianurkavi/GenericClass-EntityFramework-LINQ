using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKısıtları1Milyon
{
    class Program
    {
        static void Main(string[] args)
        {
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

    }
    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }
    class Student
    {

    }
    interface IStudentDal:IRepository</*string*/Student>// Bu şekilde bir interface yazmamız gerekiyor mesela ben buna kısıtlama getirmek istiyorum.IRepository interfacesine in(<> arasına int dersem hata verir çünkü classın referans tipi stringtir.)
    {

    }
    interface IRepository<T> where T:class ,new ()//, new() yazmasaydık sadece stringi kabul edcecekti sebebini yukarda belirttim.Ama new () yazdıktan sonra newlenebilir bir değer ister.Yani class.
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
