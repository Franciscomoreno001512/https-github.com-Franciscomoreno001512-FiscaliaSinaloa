using System;
using Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Aseguramiento_Artefactos_y_Explosivos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Aseguramiento_Artefactos_y_ExplosivosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_ExplosivosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
