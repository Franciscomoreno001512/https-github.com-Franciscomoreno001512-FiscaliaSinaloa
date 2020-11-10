using System;
using Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Solicitud_Historial_de_Asignaciones
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Solicitud_Historial_de_AsignacionesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_AsignacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones.Detalle_Solicitud_Historial_de_Asignaciones> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
