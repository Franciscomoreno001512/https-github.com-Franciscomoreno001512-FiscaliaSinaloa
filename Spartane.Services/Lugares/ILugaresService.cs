using System;
using Spartane.Core.Domain.Lugares;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Lugares
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ILugaresService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Lugares.Lugares> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugares.Lugares> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugares.Lugares> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Lugares.Lugares GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Lugares.Lugares entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Lugares.Lugares entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Lugares.Lugares> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Lugares.Lugares> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Lugares.LugaresPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Lugares.Lugares> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
