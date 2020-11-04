using System;
using Spartane.Core.Domain.Barba;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Barba
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IBarbaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Barba.Barba> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Barba.Barba> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Barba.Barba> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Barba.Barba GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Barba.Barba entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Barba.Barba entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Barba.Barba> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Barba.Barba> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Barba.BarbaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Barba.Barba> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
