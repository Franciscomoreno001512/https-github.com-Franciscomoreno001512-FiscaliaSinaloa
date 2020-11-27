using System;
using Spartane.Core.Domain.expediente_ministerio_publico;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.expediente_ministerio_publico
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface Iexpediente_ministerio_publicoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
