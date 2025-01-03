﻿using Project.BLL.DesingPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.ConcRep
{
    public class LocationRepository : BaseRepository<Location>
    {
        public bool IsLocationExists(string locationName)
        {
            return CheckExists(x => x.Name.ToLower() == locationName.ToLower());
        }
    }
}
