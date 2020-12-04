using System;
using Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Delitos_Proceso_Penal
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Delitos_Proceso_PenalService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_PenalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal.Detalle_Delitos_Proceso_Penal> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
