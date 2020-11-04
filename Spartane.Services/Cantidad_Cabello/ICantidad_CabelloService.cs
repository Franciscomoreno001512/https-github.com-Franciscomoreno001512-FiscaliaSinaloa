using System;
using Spartane.Core.Domain.Cantidad_Cabello;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Cantidad_Cabello
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICantidad_CabelloService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Cantidad_Cabello.Cantidad_CabelloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Cantidad_Cabello.Cantidad_Cabello> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
