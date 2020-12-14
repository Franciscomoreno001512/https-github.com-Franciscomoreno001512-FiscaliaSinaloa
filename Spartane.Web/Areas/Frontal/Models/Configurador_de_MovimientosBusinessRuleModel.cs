using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Configurador_de_MovimientosBusinessRuleModel
    {
        public int BusinessRuleId { get; set; }
        public string FieldId { get; set; }
        public string FieldName { get; set; }
        public string ObjectId { get; set; }
        public string Attribute { get; set; }
    }
}
