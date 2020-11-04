using System;
using Spartane.Core.Domain.Razon_de_Incumplimiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Razon_de_Incumplimiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRazon_de_IncumplimientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_IncumplimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
