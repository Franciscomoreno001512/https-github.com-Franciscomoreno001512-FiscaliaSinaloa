using System;
using Spartane.Core.Domain.Forma_Comision_Delito;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Forma_Comision_Delito
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IForma_Comision_DelitoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
