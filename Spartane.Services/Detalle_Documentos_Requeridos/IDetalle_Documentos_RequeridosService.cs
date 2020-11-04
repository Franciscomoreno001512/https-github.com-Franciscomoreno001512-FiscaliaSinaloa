using System;
using Spartane.Core.Domain.Detalle_Documentos_Requeridos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Documentos_Requeridos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Documentos_RequeridosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_RequeridosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Documentos_Requeridos.Detalle_Documentos_Requeridos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
