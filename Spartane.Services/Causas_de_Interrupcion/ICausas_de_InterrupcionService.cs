using System;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Causas_de_Interrupcion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICausas_de_InterrupcionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_InterrupcionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
