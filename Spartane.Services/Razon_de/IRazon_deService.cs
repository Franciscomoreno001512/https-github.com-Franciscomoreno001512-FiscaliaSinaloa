using System;
using Spartane.Core.Domain.Razon_de;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Razon_de
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRazon_deService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Razon_de.Razon_de GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Razon_de.Razon_de entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Razon_de.Razon_de entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Razon_de.Razon_de> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Razon_de.Razon_dePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Razon_de.Razon_de> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
