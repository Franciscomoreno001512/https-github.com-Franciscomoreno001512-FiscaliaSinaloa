using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using Spartane.Core.Domain.Spartan_Object_ByPass;
using Spartane.Core.Domain.Spartane_File;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Spartan_RDM_Operations_Detail
{
    /// <summary>
    /// Spartan_RDM_Operations_Detail table
    /// </summary>
    public class Spartan_RDM_Operations_Detail: BaseEntity
    {
        public int DetailId { get; set; }
        public int? Record_Detail_Management { get; set; }
        public int? Object_Name { get; set; }
        public string Object_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Count_Query { get; set; }
        public string Query_Data { get; set; }
        public int? Icono { get; set; }
        public string Icono_URL { get; set; }

        [ForeignKey("Record_Detail_Management")]
        public virtual Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management Record_Detail_Management_Spartan_Record_Detail_Management { get; set; }
        [ForeignKey("Object_Name")]
        public virtual Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass Object_Name_Spartan_Object_ByPass { get; set; }
        [ForeignKey("Icono")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Icono_Spartane_File { get; set; }

    }
	
	public class Spartan_RDM_Operations_Detail_Datos_Generales
    {
                public int DetailId { get; set; }
        public int? Record_Detail_Management { get; set; }
        public int? Object_Name { get; set; }
        public string Object_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Count_Query { get; set; }
        public string Query_Data { get; set; }
        public int? Icono { get; set; }
        public string Icono_URL { get; set; }

		        [ForeignKey("Record_Detail_Management")]
        public virtual Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management Record_Detail_Management_Spartan_Record_Detail_Management { get; set; }
        [ForeignKey("Object_Name")]
        public virtual Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass Object_Name_Spartan_Object_ByPass { get; set; }
        [ForeignKey("Icono")]
        public virtual Spartane.Core.Domain.Spartane_File.Spartane_File Icono_Spartane_File { get; set; }

    }


}

