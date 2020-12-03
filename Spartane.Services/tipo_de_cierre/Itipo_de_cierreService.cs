using System;
using Spartane.Core.Domain.tipo_de_cierre;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.tipo_de_cierre
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface Itipo_de_cierreService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierrePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
