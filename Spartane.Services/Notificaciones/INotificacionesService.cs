using System;
using Spartane.Core.Domain.Notificaciones;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Notificaciones
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface INotificacionesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Notificaciones.Notificaciones GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Notificaciones.Notificaciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Notificaciones.Notificaciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Notificaciones.Notificaciones> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Notificaciones.NotificacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Notificaciones.Notificaciones> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
