
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint generic kısıt
    //class: referans tip
    //Ientity veya Ientityden üretilmiş sınıf olmalı
    //Ientity'nin interfaceini devre dışı bırakmak için ise new() komutunu yani newlenebilir. diyoruz.
    public interface IEntityRepository<T> where T:class,IEntity,new() // T ya IEntity olabilir ya da IEntityden türetilmiş bir sınıf. T yerine rastgele bir sınıf yazıalasmın diye kullandık.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
