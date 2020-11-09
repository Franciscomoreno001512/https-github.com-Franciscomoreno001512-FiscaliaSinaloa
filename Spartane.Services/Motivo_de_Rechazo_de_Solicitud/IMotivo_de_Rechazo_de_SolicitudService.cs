using System;
using Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Motivo_de_Rechazo_de_Solicitud
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMotivo_de_Rechazo_de_SolicitudService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_SolicitudPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud.Motivo_de_Rechazo_de_Solicitud> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
