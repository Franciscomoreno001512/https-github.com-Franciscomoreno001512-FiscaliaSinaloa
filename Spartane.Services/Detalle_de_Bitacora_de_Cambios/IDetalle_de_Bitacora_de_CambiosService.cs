using System;
using Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Bitacora_de_Cambios
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Bitacora_de_CambiosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_CambiosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios.Detalle_de_Bitacora_de_Cambios> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
