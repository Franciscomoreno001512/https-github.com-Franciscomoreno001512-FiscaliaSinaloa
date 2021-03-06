﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_BR_HistoryGridModel
    {
        public int Key_History { get; set; }
        public int? User_logged { get; set; }
        public string User_loggedName { get; set; }
        public short? Status { get; set; }
        public string StatusDescription { get; set; }
        public string Change_Date { get; set; }
        public string Hour_Date { get; set; }
        public int? Time_elapsed { get; set; }
        public int? Change_Type { get; set; }
        public string Change_TypeDescription { get; set; }
        public string Conditions { get; set; }
        public string Actions_True { get; set; }
        public string Actions_False { get; set; }
        
    }
}

