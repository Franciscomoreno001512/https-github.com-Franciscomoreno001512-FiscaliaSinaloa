using System;
using Spartane.Core.Domain.Tipo_Clasificacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_Clasificacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_ClasificacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_Clasificacion.Tipo_ClasificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_Clasificacion.Tipo_Clasificacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
