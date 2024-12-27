using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class PaymentConfiguration : BaseConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            // Türkçe sütun isimlendirmeleri
            Property(x => x.TotalPrice).HasColumnName("Toplam Tutar");
            Property(x => x.PaidAmount).HasColumnName("Ödenen Tutar");
            Property(x => x.RemainingAmount).HasColumnName("Kalan Tutar");
            Property(x => x.PaymentStatus).HasColumnName("Ödeme Durumu");
            Property(x => x.Notes).HasColumnName("Notlar");
            Property(x => x.PaymentDate).HasColumnName("Ödeme Tarihi");
            Property(x => x.PaymentMethod).HasColumnName("Ödeme Yöntemi");
        }
    }
}
