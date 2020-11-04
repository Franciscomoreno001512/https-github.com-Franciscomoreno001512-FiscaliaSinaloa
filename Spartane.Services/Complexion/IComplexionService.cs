using System;
using Spartane.Core.Domain.Complexion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Complexion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IComplexionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Complexion.Complexion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Complexion.Complexion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Complexion.Complexion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Complexion.Complexion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Complexion.Complexion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Complexion.Complexion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Complexion.Complexion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Complexion.Complexion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Complexion.ComplexionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Complexion.Complexion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
