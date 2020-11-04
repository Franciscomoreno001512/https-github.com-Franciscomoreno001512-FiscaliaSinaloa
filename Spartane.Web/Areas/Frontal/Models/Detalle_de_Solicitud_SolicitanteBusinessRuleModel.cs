using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_de_Solicitud_SolicitanteBusinessRuleModel
    {
        public int BusinessRuleId { get; set; }
        public string FieldId { get; set; }
        public string FieldName { get; set; }
        public string ObjectId { get; set; }
        public string Attribute { get; set; }
    }
}
