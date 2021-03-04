using System;
using Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Solicitud_Disponibles_Configuracion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Solicitud_Disponibles_ConfiguracionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_ConfiguracionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
