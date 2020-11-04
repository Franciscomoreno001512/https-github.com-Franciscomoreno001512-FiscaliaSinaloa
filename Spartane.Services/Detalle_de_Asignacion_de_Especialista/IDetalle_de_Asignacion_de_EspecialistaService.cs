using System;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Asignacion_de_Especialista
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Asignacion_de_EspecialistaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
