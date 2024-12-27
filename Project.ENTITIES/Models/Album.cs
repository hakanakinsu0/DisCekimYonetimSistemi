using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Album : BaseEntity
    {
        public AlbumCategory Category { get; set; }
        public string Size { get; set; }
        public bool IsPackage { get; set; }
        public string AlbumName { get; set; }
        public string CanvasSize { get; set; }
        public DateTime PrintSentDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        //Foreign Keys
        public int CustomerId { get; set; }

        //Relational Properties
        public virtual PhotoShoot PhotoShoot { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
