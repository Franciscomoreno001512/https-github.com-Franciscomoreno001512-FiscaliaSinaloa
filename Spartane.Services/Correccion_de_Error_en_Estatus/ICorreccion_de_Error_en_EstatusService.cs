using System;
using Spartane.Core.Domain.Correccion_de_Error_en_Estatus;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Correccion_de_Error_en_Estatus
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICorreccion_de_Error_en_EstatusService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
