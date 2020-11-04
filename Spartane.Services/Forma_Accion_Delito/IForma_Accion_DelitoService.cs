using System;
using Spartane.Core.Domain.Forma_Accion_Delito;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Forma_Accion_Delito
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IForma_Accion_DelitoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
