using System;
using Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Datos_Adicionales_Movimiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Datos_Adicionales_MovimientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_MovimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
