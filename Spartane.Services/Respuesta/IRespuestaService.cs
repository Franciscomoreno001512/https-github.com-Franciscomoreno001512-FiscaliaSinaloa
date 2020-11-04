using System;
using Spartane.Core.Domain.Respuesta;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Respuesta
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRespuestaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Respuesta.Respuesta GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Respuesta.Respuesta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Respuesta.Respuesta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Respuesta.Respuesta> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Respuesta.Respuesta> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Respuesta.RespuestaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Respuesta.Respuesta> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
