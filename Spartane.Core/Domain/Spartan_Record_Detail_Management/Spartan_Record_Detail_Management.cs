using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_Object_ByPass;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Spartan_Record_Detail_Management
{
    /// <summary>
    /// Spartan_Record_Detail_Management table
    /// </summary>
    public class Spartan_Record_Detail_Management: BaseEntity
    {
        public int Process_Id { get; set; }
        public DateTime? Register_Date { get; set; }
        public string Register_Hour { get; set; }
        public int? Register_User { get; set; }
        public string Description { get; set; }
        public int? Object { get; set; }
        public string Reference_Label { get; set; }
        public int? Reference_Field { get; set; }
        public int? Search_Result { get; set; }
        public string Search_Result_Query { get; set; }
        public int? Image_Field { get; set; }
        public int? Data_Detail { get; set; }
        public string Query_Data_Detail { get; set; }

        [ForeignKey("Register_User")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Register_User_Spartan_User { get; set; }
        [ForeignKey("Object")]
        public virtual Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass Object_Spartan_Object_ByPass { get; set; }
        [ForeignKey("Reference_Field")]
        public virtual Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass Reference_Field_Spartan_Attribute_Bypass { get; set; }
        [ForeignKey("Image_Field")]
        public virtual Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass Image_Field_Spartan_Attribute_Bypass { get; set; }

    }
	
	public class Spartan_Record_Detail_Management_Datos_Generales
    {
                public int Process_Id { get; set; }
        public DateTime? Register_Date { get; set; }
        public string Register_Hour { get; set; }
        public int? Register_User { get; set; }
        public string Description { get; set; }
        public int? Object { get; set; }
        public string Reference_Label { get; set; }
        public int? Reference_Field { get; set; }

		        [ForeignKey("Register_User")]
        public virtual Spartane.Core.Domain.Spartan_User.Spartan_User Register_User_Spartan_User { get; set; }
        [ForeignKey("Object")]
        public virtual Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass Object_Spartan_Object_ByPass { get; set; }
        [ForeignKey("Reference_Field")]
        public virtual Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass Reference_Field_Spartan_Attribute_Bypass { get; set; }

    }

	public class Spartan_Record_Detail_Management_Busqueda
    {
                public int Process_Id { get; set; }
        public int? Search_Result { get; set; }
        public string Search_Result_Query { get; set; }

		
    }

	public class Spartan_Record_Detail_Management_Informacion_General
    {
                public int Process_Id { get; set; }
        public int? Image_Field { get; set; }
        public int? Data_Detail { get; set; }
        public string Query_Data_Detail { get; set; }

		        [ForeignKey("Image_Field")]
        public virtual Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass Image_Field_Spartan_Attribute_Bypass { get; set; }

    }

	public class Spartan_Record_Detail_Management_Operaciones
    {
                public int Process_Id { get; set; }

		
    }


}

