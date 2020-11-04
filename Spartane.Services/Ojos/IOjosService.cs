using System;
using Spartane.Core.Domain.Ojos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Ojos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOjosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Ojos.Ojos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ojos.Ojos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ojos.Ojos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Ojos.Ojos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Ojos.Ojos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Ojos.Ojos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Ojos.Ojos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Ojos.Ojos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Ojos.OjosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Ojos.Ojos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
