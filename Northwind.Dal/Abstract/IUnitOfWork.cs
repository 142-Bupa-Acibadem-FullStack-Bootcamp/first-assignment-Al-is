using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        //Transactinon =>onaylama -- Başladı mı ?
        bool BeginTransaction();
        //Geri Alındı mı ?
        bool RollBackTransaction();
        //Etkilenen satır sayısı
        int SaveChanges();
    }
}
