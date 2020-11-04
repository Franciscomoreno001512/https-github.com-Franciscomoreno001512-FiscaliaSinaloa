using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class TTFolioConsecutivoModel
    {
        [Required]
        public int Folio { get; set; }
        public string Texto { get; set; }

    }
	
	public class TTFolioConsecutivo_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public string Texto { get; set; }

    }


}

