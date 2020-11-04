using System;
using Spartane.Core.Domain.Estatus_Solicitud;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_Solicitud
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_SolicitudService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_Solicitud.Estatus_SolicitudPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_Solicitud.Estatus_Solicitud> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
