using System;
using Spartane.Core.Domain.Otros_Nombres_Requerido_MASC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Otros_Nombres_Requerido_MASC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOtros_Nombres_Requerido_MASCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Otros_Nombres_Requerido_MASC.Otros_Nombres_Requerido_MASC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
