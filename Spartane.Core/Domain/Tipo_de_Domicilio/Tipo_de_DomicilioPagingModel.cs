﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Tipo_de_Domicilio
{
    public class Tipo_de_DomicilioPagingModel
    {
        public List<Spartane.Core.Domain.Tipo_de_Domicilio.Tipo_de_Domicilio> Tipo_de_Domicilios { set; get; }
        public int RowCount { set; get; }
    }
}