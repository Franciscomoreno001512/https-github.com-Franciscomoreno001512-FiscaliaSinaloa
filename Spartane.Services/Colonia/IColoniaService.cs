using System;
using Spartane.Core.Domain.Colonia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Colonia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IColoniaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Colonia.Colonia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Colonia.Colonia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Colonia.Colonia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Colonia.Colonia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Colonia.Colonia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Colonia.Colonia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Colonia.Colonia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Colonia.Colonia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Colonia.ColoniaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Colonia.Colonia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
