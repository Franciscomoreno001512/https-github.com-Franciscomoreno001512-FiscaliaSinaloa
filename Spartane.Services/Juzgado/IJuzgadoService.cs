using System;
using Spartane.Core.Domain.Juzgado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Juzgado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IJuzgadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Juzgado.Juzgado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Juzgado.Juzgado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Juzgado.Juzgado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Juzgado.Juzgado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Juzgado.Juzgado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Juzgado.JuzgadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Juzgado.Juzgado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
