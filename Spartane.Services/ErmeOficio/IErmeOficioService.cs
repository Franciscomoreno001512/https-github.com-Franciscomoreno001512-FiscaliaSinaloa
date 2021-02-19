using System;
using Spartane.Core.Domain.ErmeOficio;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.ErmeOficio
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IErmeOficioService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.ErmeOficio.ErmeOficio GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.ErmeOficio.ErmeOficio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.ErmeOficio.ErmeOficio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.ErmeOficio.ErmeOficioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
