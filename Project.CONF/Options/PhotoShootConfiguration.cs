using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class PhotoShootConfiguration : BaseConfiguration<PhotoShoot>
    {
        public PhotoShootConfiguration()
        {
            ToTable("Çekimler");

            // Türkçe sütun isimlendirmeleri
            Property(x => x.ShootDate).HasColumnName("Çekim Tarihi");
            Property(x => x.ShootTime).HasColumnName("Çekim Saati");
            Property(x => x.PhotoShootStatus).HasColumnName("Çekim Durumu");
            Property(x => x.Notes).HasColumnName("Notlar");

            //// Cascade delete kapatma düzenlemeleri

            //// Customer ile ilişki (1 Müşteri -> N Çekim)
            //HasRequired(ps => ps.Customer)
            //    .WithMany(c => c.PhotoShoots)
            //    .HasForeignKey(ps => ps.CustomerId)
            //    .WillCascadeOnDelete(false);

            //// Location ile ilişki (1 Mekan -> N Çekim)
            //HasRequired(ps => ps.Location)
            //    .WithMany(l => l.PhotoShoots)
            //    .HasForeignKey(ps => ps.LocationId)
            //    .WillCascadeOnDelete(false);

            //// Photographer ile ilişki (1 Fotoğrafçı -> N Çekim)
            //HasRequired(ps => ps.Photographer)
            //    .WithMany(p => p.PhotoShoots)
            //    .HasForeignKey(ps => ps.PhotographerId)
            //    .WillCascadeOnDelete(false);

            //// Payments ile ilişki (1 Çekim -> N Ödeme)
            //HasMany(ps => ps.Payments)
            //    .WithRequired(p => p.PhotoShoot)
            //    .HasForeignKey(p => p.PhotoShootId)
            //    .WillCascadeOnDelete(false);

            //// Albums ile ilişki (1 Çekim -> N Albüm)
            //HasMany(ps => ps.Albums)
            //    .WithRequired(a => a.PhotoShoot)
            //    .HasForeignKey(a => a.PhotoShootId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
