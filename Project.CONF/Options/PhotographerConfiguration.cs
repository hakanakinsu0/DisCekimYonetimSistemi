using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class PhotographerConfiguration : BaseConfiguration<Photographer>
    {
        public PhotographerConfiguration()
        {
            // Türkçe sütun isimlendirmeleri
            Property(x => x.FirstName).HasColumnName("Ad");
            Property(x => x.LastName).HasColumnName("Soyad");
            Property(x => x.PhoneNumber).HasColumnName("Telefon Numarası");
        }
    }
}
