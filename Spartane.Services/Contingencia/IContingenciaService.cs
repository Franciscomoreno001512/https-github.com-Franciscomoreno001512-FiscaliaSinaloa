using System;
using Spartane.Core.Domain.Contingencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Contingencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IContingenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Contingencia.Contingencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Contingencia.Contingencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Contingencia.Contingencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Contingencia.Contingencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Contingencia.ContingenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Contingencia.Contingencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
