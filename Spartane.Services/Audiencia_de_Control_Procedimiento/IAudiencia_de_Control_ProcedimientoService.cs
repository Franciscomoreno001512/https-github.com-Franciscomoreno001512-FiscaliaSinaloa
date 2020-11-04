using System;
using Spartane.Core.Domain.Audiencia_de_Control_Procedimiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Audiencia_de_Control_Procedimiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAudiencia_de_Control_ProcedimientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
