﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core.DTOs
{
    public class TurnDTO
    {
        public int id { get; set; }
        public string day { get; set; }
        public string hour { get; set; }
        public int TouristId { get; set; }
    }
}
