using System;
using Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Reuniones_de_Mediacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Reuniones_de_MediacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_MediacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
