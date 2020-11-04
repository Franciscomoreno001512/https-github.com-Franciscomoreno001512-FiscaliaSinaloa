using System;
using Spartane.Core.Domain.Nacionalidad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Nacionalidad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface INacionalidadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Nacionalidad.Nacionalidad GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Nacionalidad.Nacionalidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Nacionalidad.Nacionalidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Nacionalidad.NacionalidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
