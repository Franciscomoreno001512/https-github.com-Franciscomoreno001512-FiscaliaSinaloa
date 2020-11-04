using System;
using Spartane.Core.Domain.Periodicidad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Periodicidad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPeriodicidadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Periodicidad.Periodicidad GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Periodicidad.Periodicidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Periodicidad.Periodicidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Periodicidad.Periodicidad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Periodicidad.Periodicidad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Periodicidad.PeriodicidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Periodicidad.Periodicidad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
