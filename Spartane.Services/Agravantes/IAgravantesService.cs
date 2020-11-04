using System;
using Spartane.Core.Domain.Agravantes;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Agravantes
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAgravantesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Agravantes.Agravantes GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Agravantes.Agravantes entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Agravantes.Agravantes entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Agravantes.Agravantes> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Agravantes.AgravantesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Agravantes.Agravantes> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
