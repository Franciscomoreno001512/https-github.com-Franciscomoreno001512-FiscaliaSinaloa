using System;
using Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Asignacion_responsable_servicios_apoyo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAsignacion_responsable_servicios_apoyoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
