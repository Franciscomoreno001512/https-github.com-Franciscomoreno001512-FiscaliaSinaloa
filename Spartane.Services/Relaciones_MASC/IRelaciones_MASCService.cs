using System;
using Spartane.Core.Domain.Relaciones_MASC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Relaciones_MASC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRelaciones_MASCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Relaciones_MASC.Relaciones_MASC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
