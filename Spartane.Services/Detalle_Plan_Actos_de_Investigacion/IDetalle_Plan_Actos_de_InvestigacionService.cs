using System;
using Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Plan_Actos_de_Investigacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Plan_Actos_de_InvestigacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_InvestigacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion.Detalle_Plan_Actos_de_Investigacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
