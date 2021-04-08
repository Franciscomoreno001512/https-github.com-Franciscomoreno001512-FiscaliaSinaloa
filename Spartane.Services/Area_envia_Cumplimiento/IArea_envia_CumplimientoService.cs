﻿using System;
using Spartane.Core.Domain.Area_envia_Cumplimiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Area_envia_Cumplimiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IArea_envia_CumplimientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
