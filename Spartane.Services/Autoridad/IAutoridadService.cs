using System;
using Spartane.Core.Domain.Autoridad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Autoridad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAutoridadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Autoridad.Autoridad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Autoridad.Autoridad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Autoridad.Autoridad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Autoridad.Autoridad GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Autoridad.Autoridad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Autoridad.Autoridad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Autoridad.Autoridad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Autoridad.Autoridad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Autoridad.AutoridadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Autoridad.Autoridad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
