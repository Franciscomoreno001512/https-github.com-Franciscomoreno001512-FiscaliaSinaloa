﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Domain.Color_Vehiculo
{
    public class Color_VehiculoPagingModel
    {
        public List<Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo> Color_Vehiculos { set; get; }
        public int RowCount { set; get; }
    }
}
