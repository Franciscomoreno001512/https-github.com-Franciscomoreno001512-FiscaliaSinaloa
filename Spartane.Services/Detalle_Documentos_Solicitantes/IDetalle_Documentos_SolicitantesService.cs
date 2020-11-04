using System;
using Spartane.Core.Domain.Detalle_Documentos_Solicitantes;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Documentos_Solicitantes
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Documentos_SolicitantesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_SolicitantesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
