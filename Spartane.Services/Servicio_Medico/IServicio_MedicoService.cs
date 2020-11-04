using System;
using Spartane.Core.Domain.Servicio_Medico;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Servicio_Medico
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IServicio_MedicoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Servicio_Medico.Servicio_Medico GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Servicio_Medico.Servicio_Medico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Servicio_Medico.Servicio_Medico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Servicio_Medico.Servicio_MedicoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Servicio_Medico.Servicio_Medico> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
