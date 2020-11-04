using System;
using Spartane.Core.Domain.PasaTurnos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.PasaTurnos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPasaTurnosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.PasaTurnos.PasaTurnos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.PasaTurnos.PasaTurnos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.PasaTurnos.PasaTurnos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.PasaTurnos.PasaTurnosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.PasaTurnos.PasaTurnos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
