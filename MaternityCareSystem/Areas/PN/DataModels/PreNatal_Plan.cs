﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PreNatal_Plan
    {
        public int PreNatalPlanId { get; set; }
        
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        [Required]
        public string Notes { get; set; }

      
    }
}