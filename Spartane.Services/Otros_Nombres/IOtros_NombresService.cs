using System;
using Spartane.Core.Domain.Otros_Nombres;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Otros_Nombres
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOtros_NombresService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Otros_Nombres.Otros_Nombres GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Otros_Nombres.Otros_Nombres entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Otros_Nombres.Otros_Nombres entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Otros_Nombres.Otros_NombresPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Otros_Nombres.Otros_Nombres> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
