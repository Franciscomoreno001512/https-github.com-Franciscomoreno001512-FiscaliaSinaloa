using System;
using Spartane.Core.Domain.Estatus_de_Asignacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_de_Asignacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_de_AsignacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_AsignacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
