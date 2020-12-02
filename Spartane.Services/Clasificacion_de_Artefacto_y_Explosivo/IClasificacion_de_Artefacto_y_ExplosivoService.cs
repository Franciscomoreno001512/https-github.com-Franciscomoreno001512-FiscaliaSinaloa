using System;
using Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Clasificacion_de_Artefacto_y_Explosivo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IClasificacion_de_Artefacto_y_ExplosivoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
