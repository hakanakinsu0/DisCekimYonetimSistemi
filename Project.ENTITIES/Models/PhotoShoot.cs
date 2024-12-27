using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PhotoShoot : BaseEntity
    {
        public DateTime ShootDate { get; set; }
        public TimeSpan ShootTime { get; set; }
        public PhotoShootStatus PhotoShootStatus { get; set; }
        public string Notes { get; set; }

        //Foreign Keys
        public int CustomerId { get; set; }
        public int LocationId { get; set; }
        public int PhotographerId { get; set; }

        //Relational Properties
        public virtual Customer Customer { get; set; } //1 customer n photoshoot, 1 photoshoot 1 customer
        public virtual Photographer Photographer { get; set; } // 1 photographer n photoshoot, 1 photoshoot 1 photographer
        public virtual Location Location { get; set; } //1 location n photoshoot, 1 photoshoot 1 location
        public virtual List<Payment> Payments { get; set; } //1 photoshoot n Payment, 1 payment 1 photoshoot
        public virtual List<Album> Albums { get; set; } // 1 photoshop n album, 1 album 1 photoshop
    }
}
