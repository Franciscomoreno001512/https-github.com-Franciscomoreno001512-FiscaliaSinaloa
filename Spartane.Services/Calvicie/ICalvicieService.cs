using System;
using Spartane.Core.Domain.Calvicie;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Calvicie
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICalvicieService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Calvicie.Calvicie GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Calvicie.Calvicie entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Calvicie.Calvicie entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Calvicie.Calvicie> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Calvicie.Calvicie> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Calvicie.CalviciePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Calvicie.Calvicie> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
