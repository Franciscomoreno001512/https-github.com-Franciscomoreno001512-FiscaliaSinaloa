using System;
using Spartane.Core.Domain.Errores_de_Replicacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Errores_de_Replicacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IErrores_de_ReplicacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_ReplicacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
