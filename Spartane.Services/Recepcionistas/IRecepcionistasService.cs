using System;
using Spartane.Core.Domain.Recepcionistas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Recepcionistas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRecepcionistasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Recepcionistas.Recepcionistas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Recepcionistas.Recepcionistas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Recepcionistas.Recepcionistas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Recepcionistas.RecepcionistasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
