using System;
using Spartane.Core.Domain.Modulo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Modulo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IModuloService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Modulo.Modulo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modulo.Modulo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modulo.Modulo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Modulo.Modulo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Modulo.Modulo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Modulo.Modulo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Modulo.Modulo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Modulo.Modulo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Modulo.ModuloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Modulo.Modulo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
