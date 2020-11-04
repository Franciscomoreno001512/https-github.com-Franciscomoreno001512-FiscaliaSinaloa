using System;
using Spartane.Core.Domain.Boca;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Boca
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IBocaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Boca.Boca> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Boca.Boca> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Boca.Boca> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Boca.Boca GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Boca.Boca entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Boca.Boca entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Boca.Boca> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Boca.Boca> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Boca.BocaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Boca.Boca> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
