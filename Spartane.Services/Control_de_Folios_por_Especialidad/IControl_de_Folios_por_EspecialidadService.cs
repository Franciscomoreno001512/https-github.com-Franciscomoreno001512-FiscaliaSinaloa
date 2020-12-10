using System;
using Spartane.Core.Domain.Control_de_Folios_por_Especialidad;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Control_de_Folios_por_Especialidad
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IControl_de_Folios_por_EspecialidadService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
