using System;
using Spartane.Core.Domain.Cejas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Cejas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICejasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Cejas.Cejas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Cejas.Cejas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Cejas.Cejas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Cejas.Cejas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Cejas.Cejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Cejas.Cejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Cejas.Cejas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Cejas.Cejas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Cejas.CejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Cejas.Cejas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
