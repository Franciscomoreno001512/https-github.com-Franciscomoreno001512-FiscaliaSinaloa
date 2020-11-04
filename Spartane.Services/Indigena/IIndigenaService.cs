using System;
using Spartane.Core.Domain.Indigena;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Indigena
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IIndigenaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Indigena.Indigena> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Indigena.Indigena> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Indigena.Indigena> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Indigena.Indigena GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Indigena.Indigena entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Indigena.Indigena entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Indigena.Indigena> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Indigena.Indigena> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Indigena.IndigenaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Indigena.Indigena> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
