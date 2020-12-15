using System;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Fase_de_Judicializacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IFase_de_JudicializacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_JudicializacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
