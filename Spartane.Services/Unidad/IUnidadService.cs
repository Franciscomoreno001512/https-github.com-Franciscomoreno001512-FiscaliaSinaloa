using System;
using Spartane.Core.Domain.Unidad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Unidad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IUnidadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Unidad.Unidad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad.Unidad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad.Unidad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Unidad.Unidad GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Unidad.Unidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Unidad.Unidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Unidad.Unidad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Unidad.Unidad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Unidad.UnidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Unidad.Unidad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
