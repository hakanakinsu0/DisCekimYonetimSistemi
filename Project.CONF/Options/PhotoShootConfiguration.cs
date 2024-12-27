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
            // Türkçe sütun isimlendirmeleri
            Property(x => x.ShootDate).HasColumnName("Çekim Tarihi");
            Property(x => x.ShootTime).HasColumnName("Çekim Saati");
            Property(x => x.PhotoShootStatus).HasColumnName("Çekim Durumu");
            Property(x => x.Notes).HasColumnName("Notlar");
        }
    }
}
