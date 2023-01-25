﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTracker.Classes
{
    public class Election
    {
        public Election() { }

        public string ElectionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ElectionGroupID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}