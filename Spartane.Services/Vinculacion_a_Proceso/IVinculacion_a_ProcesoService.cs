using System;
using Spartane.Core.Domain.Vinculacion_a_Proceso;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Vinculacion_a_Proceso
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IVinculacion_a_ProcesoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_ProcesoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
