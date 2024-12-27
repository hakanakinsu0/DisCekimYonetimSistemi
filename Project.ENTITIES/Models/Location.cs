using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<PhotoShoot> PhotoShoots { get; set; } //1 location n photoshoot, 1 photoshoot 1 location
    }
}
