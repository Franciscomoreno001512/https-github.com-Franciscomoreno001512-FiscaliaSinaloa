using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.TTFolioConsecutivo
{
    /// <summary>
    /// TTFolioConsecutivo table
    /// </summary>
    public class TTFolioConsecutivo: BaseEntity
    {
        public int Folio { get; set; }
        public string Texto { get; set; }


    }
	
	public class TTFolioConsecutivo_Datos_Generales
    {
                public int Folio { get; set; }
        public string Texto { get; set; }

		
    }


}

