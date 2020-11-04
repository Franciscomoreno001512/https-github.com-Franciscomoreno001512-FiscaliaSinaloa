using System;
using Spartane.Core.Domain.Bigote;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Bigote
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IBigoteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Bigote.Bigote> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Bigote.Bigote> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Bigote.Bigote> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Bigote.Bigote GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Bigote.Bigote entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Bigote.Bigote entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Bigote.Bigote> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Bigote.Bigote> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Bigote.BigotePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Bigote.Bigote> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
