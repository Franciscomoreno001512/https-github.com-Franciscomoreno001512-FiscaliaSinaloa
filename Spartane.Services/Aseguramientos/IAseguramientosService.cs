using System;
using Spartane.Core.Domain.Aseguramientos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Aseguramientos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAseguramientosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Aseguramientos.Aseguramientos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Aseguramientos.Aseguramientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Aseguramientos.Aseguramientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Aseguramientos.AseguramientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
