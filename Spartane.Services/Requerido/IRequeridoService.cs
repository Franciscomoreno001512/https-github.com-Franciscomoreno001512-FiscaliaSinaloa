using System;
using Spartane.Core.Domain.Requerido;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Requerido
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRequeridoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Requerido.Requerido> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Requerido.Requerido> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Requerido.Requerido> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Requerido.Requerido GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Requerido.Requerido entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Requerido.Requerido entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Requerido.Requerido> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Requerido.Requerido> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Requerido.RequeridoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Requerido.Requerido> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
