using System;
using Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Personas_donde_se_ejecuto_mandamiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPersonas_donde_se_ejecuto_mandamientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
