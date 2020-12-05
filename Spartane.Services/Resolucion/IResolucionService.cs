using System;
using Spartane.Core.Domain.Resolucion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Resolucion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IResolucionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Resolucion.Resolucion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Resolucion.Resolucion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Resolucion.Resolucion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Resolucion.Resolucion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Resolucion.ResolucionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Resolucion.Resolucion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
