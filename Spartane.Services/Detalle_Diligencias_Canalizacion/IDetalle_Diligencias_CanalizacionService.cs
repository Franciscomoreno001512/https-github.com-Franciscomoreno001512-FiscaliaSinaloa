using System;
using Spartane.Core.Domain.Detalle_Diligencias_Canalizacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Diligencias_Canalizacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Diligencias_CanalizacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_CanalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
