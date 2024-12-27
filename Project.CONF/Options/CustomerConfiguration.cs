using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class CustomerConfiguration : BaseConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("Müşteriler");

            // Türkçe sütun isimlendirmeleri
            Property(x => x.FirstName).HasColumnName("Ad");
            Property(x => x.LastName).HasColumnName("Soyad");
            Property(x => x.PhoneNumber).HasColumnName("Telefon Numarası");
            Property(x => x.BrideName).HasColumnName("Gelin Adı");
            Property(x => x.GroomName).HasColumnName("Damat Adı");
            Property(x => x.WeddingDate).HasColumnName("Düğün Tarihi");
        }
    }
}
