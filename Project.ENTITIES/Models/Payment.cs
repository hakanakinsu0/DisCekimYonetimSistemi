using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Payment : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string Notes { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        //Foreign Keys
        public int PhotoShootId { get; set; }

        //Relational Properties
        public virtual PhotoShoot PhotoShoot { get; set; } //1 photoshoot n Payment, 1 payment 1 photoshoot
    }
}
