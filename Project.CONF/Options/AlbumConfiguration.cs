using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class AlbumConfiguration : BaseConfiguration<Album>
    {
        public AlbumConfiguration()
        {
            ToTable("Albumler");

            // Türkçe sütun isimlendirmeleri
            Property(x => x.Category).HasColumnName("Albüm Kategorisi");
            Property(x => x.Size).HasColumnName("Boyut");
            Property(x => x.IsPackage).HasColumnName("Paket Mi?");
            Property(x => x.AlbumName).HasColumnName("Albüm Adı");
            Property(x => x.CanvasSize).HasColumnName("Kanvas Boyutu");
            Property(x => x.PrintSentDate).HasColumnName("Baskı Gönderim Tarihi");
            Property(x => x.DeliveryDate).HasColumnName("Teslim Tarihi");
        }
    }
}
