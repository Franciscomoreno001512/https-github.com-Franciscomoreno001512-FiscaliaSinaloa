﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_WorkFlow_Phase_TypeModel
    {
        [Required]
        public short Phase_TypeId { get; set; }
        public string Description { get; set; }

    }
}

