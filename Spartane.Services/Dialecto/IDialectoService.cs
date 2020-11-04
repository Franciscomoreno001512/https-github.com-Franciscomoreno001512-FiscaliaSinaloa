using System;
using Spartane.Core.Domain.Dialecto;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Dialecto
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDialectoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Dialecto.Dialecto GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Dialecto.Dialecto entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Dialecto.Dialecto entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Dialecto.Dialecto> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Dialecto.Dialecto> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Dialecto.DialectoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Dialecto.Dialecto> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
