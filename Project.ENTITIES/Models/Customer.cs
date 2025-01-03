﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BrideName { get; set; }
        public string GroomName { get; set; }
        public DateTime WeddingDate { get; set; }

        //Relational Properties
        public virtual List<PhotoShoot> PhotoShoots { get; set; } //1 customer n photoshoot, 1 photoshoot 1 customer
        public virtual List<Album> Albums { get; set; } // 1 album 1 customer, 1 customer n album
    }
}
