using System;
using Spartane.Core.Domain.Especialidad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Especialidad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEspecialidadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Especialidad.Especialidad GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Especialidad.Especialidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Especialidad.Especialidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Especialidad.Especialidad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Especialidad.Especialidad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Especialidad.EspecialidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Especialidad.Especialidad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
