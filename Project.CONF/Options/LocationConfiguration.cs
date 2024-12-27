using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class LocationConfiguration : BaseConfiguration<Location>
    {
        public LocationConfiguration()
        {
            ToTable("Çekim Alanları");

            // Türkçe sütun isimlendirmeleri
            Property(x => x.Name).HasColumnName("Mekan Adı");
            Property(x => x.Address).HasColumnName("Adres");
            Property(x => x.District).HasColumnName("İlçe");
            Property(x => x.City).HasColumnName("Şehir");
            Property(x => x.Description).HasColumnName("Açıklama");
        }
    }
}
