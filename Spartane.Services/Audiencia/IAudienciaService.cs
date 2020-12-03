using System;
using Spartane.Core.Domain.Audiencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Audiencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAudienciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Audiencia.Audiencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Audiencia.Audiencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Audiencia.Audiencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Audiencia.Audiencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Audiencia.AudienciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Audiencia.Audiencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
