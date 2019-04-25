﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Contract
    {
        public int ID { get; set; }
        public int CarID{ get; set; }
        public int SpecialistID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Defect { get; set; }
        public int Payment { get; set; }

        public override string ToString()
        {
            return $"{ID} {CarID} {SpecialistID} {Date} {Time} {Defect} {Payment}";

        }
    }
}
