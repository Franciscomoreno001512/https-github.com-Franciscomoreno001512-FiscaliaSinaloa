using System;
using Spartane.Core.Domain.Especificacion_Detencion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Especificacion_Detencion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEspecificacion_DetencionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Especificacion_Detencion.Especificacion_DetencionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
