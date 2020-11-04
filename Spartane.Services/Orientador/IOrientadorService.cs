using System;
using Spartane.Core.Domain.Orientador;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Orientador
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOrientadorService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Orientador.Orientador> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Orientador.Orientador> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Orientador.Orientador> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Orientador.Orientador GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Orientador.Orientador entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Orientador.Orientador entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Orientador.Orientador> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Orientador.Orientador> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Orientador.OrientadorPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Orientador.Orientador> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
