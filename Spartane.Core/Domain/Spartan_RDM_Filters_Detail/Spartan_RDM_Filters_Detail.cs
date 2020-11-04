using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Spartan_RDM_Filters_Detail
{
    /// <summary>
    /// Spartan_RDM_Filters_Detail table
    /// </summary>
    public class Spartan_RDM_Filters_Detail: BaseEntity
    {
        public int Filters_Detail_Id { get; set; }
        public int? Record_Detail_Management { get; set; }
        public int? Field_Name { get; set; }
        public string Field_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Field_Path { get; set; }
        public string Physical_Field_Name { get; set; }
        public string Logical_Field_Name { get; set; }

        [ForeignKey("Record_Detail_Management")]
        public virtual Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management Record_Detail_Management_Spartan_Record_Detail_Management { get; set; }
        [ForeignKey("Field_Name")]
        public virtual Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass Field_Name_Spartan_Attribute_Bypass { get; set; }

    }
	
	public class Spartan_RDM_Filters_Detail_Datos_Generales
    {
                public int Filters_Detail_Id { get; set; }
        public int? Record_Detail_Management { get; set; }
        public int? Field_Name { get; set; }
        public string Field_Label { get; set; }
        public short? Order_Shown { get; set; }
        public string Field_Path { get; set; }
        public string Physical_Field_Name { get; set; }
        public string Logical_Field_Name { get; set; }

		        [ForeignKey("Record_Detail_Management")]
        public virtual Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management Record_Detail_Management_Spartan_Record_Detail_Management { get; set; }
        [ForeignKey("Field_Name")]
        public virtual Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass Field_Name_Spartan_Attribute_Bypass { get; set; }

    }


}

