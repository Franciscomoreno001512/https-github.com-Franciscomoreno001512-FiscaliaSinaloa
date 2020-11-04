using System;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Asignacion_de_Turnos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAsignacion_de_TurnosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_TurnosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
