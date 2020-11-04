using System;
using Spartane.Core.Domain.Codigo_Postal;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Codigo_Postal
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICodigo_PostalService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Codigo_Postal.Codigo_Postal GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Codigo_Postal.Codigo_PostalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
