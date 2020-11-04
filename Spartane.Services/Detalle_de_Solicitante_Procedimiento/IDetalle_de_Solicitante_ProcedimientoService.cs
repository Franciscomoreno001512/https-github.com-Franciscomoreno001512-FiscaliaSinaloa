using System;
using Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Solicitante_Procedimiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Solicitante_ProcedimientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_ProcedimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento.Detalle_de_Solicitante_Procedimiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
