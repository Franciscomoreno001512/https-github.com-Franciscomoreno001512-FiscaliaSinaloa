using System;
using Spartane.Core.Domain.Autoridad_Externa;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Autoridad_Externa
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAutoridad_ExternaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Autoridad_Externa.Autoridad_ExternaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
