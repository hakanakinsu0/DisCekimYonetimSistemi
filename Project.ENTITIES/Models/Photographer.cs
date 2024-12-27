using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Photographer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        //Relational Properties
        public virtual List<PhotoShoot> PhotoShoots { get; set; } // 1 photographer n photoshoot, 1 photoshoot 1 photographer
    }
}
