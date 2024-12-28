using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        // Ekleme
        void Add(T item);

        // Güncelleme
        void Update(T item);

        // Silme
        void Delete(T item); // Fiziksel Silme
        void SoftDelete(T item); // Yumuşak Silme (Soft Delete)

        // Getirme İşlemleri
        T Find(int id); // ID ile bulma
        T FirstOrDefault(Expression<Func<T, bool>> filter); // Koşula göre tek bir kayıt getirme
        List<T> GetAll(); // Tüm kayıtları getirme
        List<T> Where(Expression<Func<T, bool>> filter); // Koşula göre liste getirme

        // Sayma İşlemi
        int Count(Expression<Func<T, bool>> filter = null); // Koşullu veya tüm kayıtları sayma

        // Varlık Kontrolü
        bool Any(Expression<Func<T, bool>> filter); // Koşula göre var mı?

        // Kaydetme
        void Save();

        // Aktif kayıtları getirme
        List<T> GetActive();

        // Pasif kayıtları getirme
        List<T> GetInactive();

        // Güncellenmiş kayıtları getirme
        List<T> GetUpdated();
        bool CheckExists(Expression<Func<T, bool>> predicate);

    }
}
