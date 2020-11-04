using System;
using Spartane.Core.Domain.Turnos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Turnos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITurnosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Turnos.Turnos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Turnos.Turnos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Turnos.Turnos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Turnos.Turnos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Turnos.Turnos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Turnos.Turnos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Turnos.Turnos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Turnos.Turnos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Turnos.TurnosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Turnos.Turnos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
