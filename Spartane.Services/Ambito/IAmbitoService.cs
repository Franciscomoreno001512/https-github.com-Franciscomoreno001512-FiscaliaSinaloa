using System;
using Spartane.Core.Domain.Ambito;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Ambito
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAmbitoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Ambito.Ambito> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ambito.Ambito> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ambito.Ambito> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Ambito.Ambito GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Ambito.Ambito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Ambito.Ambito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Ambito.Ambito> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Ambito.Ambito> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Ambito.AmbitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Ambito.Ambito> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
