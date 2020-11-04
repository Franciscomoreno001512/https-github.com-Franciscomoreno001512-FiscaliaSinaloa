using System;
using Spartane.Core.Domain.Bitacora_de_Sincronizacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Bitacora_de_Sincronizacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IBitacora_de_SincronizacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_SincronizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
