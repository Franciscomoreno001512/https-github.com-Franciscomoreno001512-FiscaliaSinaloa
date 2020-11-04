using System;
using Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Mensaje_de_Historial
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Mensaje_de_HistorialService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_HistorialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial.Detalle_de_Mensaje_de_Historial> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
