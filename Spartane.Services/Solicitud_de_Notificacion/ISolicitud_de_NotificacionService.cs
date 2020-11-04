using System;
using Spartane.Core.Domain.Solicitud_de_Notificacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Solicitud_de_Notificacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISolicitud_de_NotificacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_NotificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Solicitud_de_Notificacion.Solicitud_de_Notificacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
