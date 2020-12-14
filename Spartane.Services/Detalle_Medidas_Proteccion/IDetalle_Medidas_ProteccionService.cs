using System;
using Spartane.Core.Domain.Detalle_Medidas_Proteccion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Medidas_Proteccion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Medidas_ProteccionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_ProteccionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Medidas_Proteccion.Detalle_Medidas_Proteccion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
