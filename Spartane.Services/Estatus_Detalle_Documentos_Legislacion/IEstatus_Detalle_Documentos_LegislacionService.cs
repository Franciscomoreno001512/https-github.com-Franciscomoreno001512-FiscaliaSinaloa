using System;
using Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_Detalle_Documentos_Legislacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_Detalle_Documentos_LegislacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_LegislacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
