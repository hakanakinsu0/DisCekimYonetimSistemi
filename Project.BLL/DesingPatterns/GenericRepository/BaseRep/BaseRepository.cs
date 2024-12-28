using Project.BLL.DesingPatterns.GenericRepository.IntRep;
using Project.BLL.DesingPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;
        DbSet<T> _table;

        public BaseRepository()
        {
            _db = DbTool.DbInstance;
            _table = _db.Set<T>(); 
        }
        // Ekleme
        public void Add(T item)
        {
            item.Status = DataStatus.Inserted;
            item.CreatedDate = DateTime.Now;
            _table.Add(item);
            Save();
        }

        // Güncelleme
        public void Update(T item)
        {
            item.Status = DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            _db.Entry(item).State = EntityState.Modified;
            Save();
        }

        // Silme
        public void Delete(T item)
        {
            _table.Remove(item);
            Save();
        }

        public void SoftDelete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        // ID ile bulma
        public T Find(int id)
        {
            return _table.Find(id);
        }

        // Koşula göre ilk öğe
        public T FirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return _table.FirstOrDefault(filter);
        }

        // Tüm öğeleri getirme
        public List<T> GetAll()
        {
            return _table.ToList();
        }

        // Aktif öğeleri getirme
        public List<T> GetActive()
        {
            return _table.Where(x => x.Status == DataStatus.Inserted).ToList();
        }

        // Pasif öğeleri getirme
        public List<T> GetInactive()
        {
            return _table.Where(x => x.Status == DataStatus.Deleted).ToList();
        }

        // Güncellenmiş öğeleri getirme
        public List<T> GetUpdated()
        {
            return _table.Where(x => x.Status == DataStatus.Updated).ToList();
        }

        // Koşula göre liste getirme
        public List<T> Where(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).ToList();
        }

        // Sayma
        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _table.Count() : _table.Count(filter);
        }

        // Koşula göre varlık kontrolü
        public bool Any(Expression<Func<T, bool>> filter)
        {
            return _table.Any(filter);
        }

        // Değişiklikleri kaydetme
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
