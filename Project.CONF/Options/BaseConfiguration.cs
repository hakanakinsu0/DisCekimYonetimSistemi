using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseConfiguration()
        {
            // Türkçe sütun isimlendirmeleri
            Property(x => x.CreatedDate).HasColumnName("Oluşturma Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Güncelleme Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            Property(x => x.Status).HasColumnName("Durum");
        }
    }
}
