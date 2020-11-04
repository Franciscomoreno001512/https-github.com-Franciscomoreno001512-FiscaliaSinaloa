using System;
using Spartane.Core.Domain.Dilgencia_MASC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Dilgencia_MASC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDilgencia_MASCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Dilgencia_MASC.Dilgencia_MASC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
