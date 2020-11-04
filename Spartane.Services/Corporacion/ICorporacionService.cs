using System;
using Spartane.Core.Domain.Corporacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Corporacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICorporacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Corporacion.Corporacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Corporacion.Corporacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Corporacion.Corporacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Corporacion.Corporacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Corporacion.Corporacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Corporacion.Corporacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Corporacion.Corporacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Corporacion.Corporacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Corporacion.CorporacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Corporacion.Corporacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
