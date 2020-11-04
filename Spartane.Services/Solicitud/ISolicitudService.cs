using System;
using Spartane.Core.Domain.Solicitud;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Solicitud
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISolicitudService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Solicitud.Solicitud> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Solicitud.Solicitud> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Solicitud.Solicitud> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Solicitud.Solicitud GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Solicitud.Solicitud entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Solicitud.Solicitud entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Solicitud.Solicitud> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Solicitud.Solicitud> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Solicitud.SolicitudPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Solicitud.Solicitud> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
