using System;
using Spartane.Core.Domain.Ocupacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Ocupacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOcupacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Ocupacion.Ocupacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Ocupacion.Ocupacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Ocupacion.Ocupacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Ocupacion.Ocupacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Ocupacion.Ocupacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Ocupacion.OcupacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Ocupacion.Ocupacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
