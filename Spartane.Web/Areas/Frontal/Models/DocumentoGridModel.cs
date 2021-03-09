﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class DocumentoGridModel
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Diligencia { get; set; }
        public string DiligenciaDescripcion { get; set; }
        public int? Origen { get; set; }
        public string OrigenDescripcion { get; set; }
        public int? Tipo_de_Documento { get; set; }
        public string Tipo_de_DocumentoDescripcion { get; set; }
        public int? SubArea_de_Servicios_de_Apoyo { get; set; }
        public string SubArea_de_Servicios_de_ApoyoDescripcion { get; set; }
        public int? idFormato { get; set; }
        public bool? Requerido { get; set; }
        public bool? Solicitante { get; set; }
        public bool? Requerido_o_Solicitante { get; set; }
        public bool? Solicitar_Archivo_Adjunto { get; set; }
        public bool? Solicitar_Numero_de_Oficio { get; set; }
        
    }
}

