using System;
using Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_subareas_responsable_servicio_apoyo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_subareas_responsable_servicio_apoyoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
