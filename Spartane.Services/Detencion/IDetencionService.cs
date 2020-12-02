using System;
using Spartane.Core.Domain.Detencion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detencion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetencionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detencion.Detencion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detencion.Detencion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detencion.Detencion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detencion.Detencion GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Detencion.Detencion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Detencion.Detencion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detencion.Detencion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detencion.Detencion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detencion.DetencionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detencion.Detencion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
