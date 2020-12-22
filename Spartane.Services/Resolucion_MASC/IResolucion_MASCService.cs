using System;
using Spartane.Core.Domain.Resolucion_MASC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Resolucion_MASC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IResolucion_MASCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Resolucion_MASC.Resolucion_MASC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
