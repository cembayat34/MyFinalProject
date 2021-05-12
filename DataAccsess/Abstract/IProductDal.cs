using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
    public interface IProductDal //I -> Interface, Product -> Hangi Tabloya karsilik geldigi, Dal -> Hangi katmana karsilik geldigi
    {                            //Dal = Data accsess layer
                                 //burada product ile ilgili veritabaninda yapacagim opersayonlari iceren interface. (Operasyon = bunu ekle, sunu sil, bunu getir, bunu listele vb..) 

        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);
    }
}
