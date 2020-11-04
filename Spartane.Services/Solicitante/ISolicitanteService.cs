using System;
using Spartane.Core.Domain.Solicitante;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Solicitante
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISolicitanteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Solicitante.Solicitante GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Solicitante.Solicitante entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Solicitante.Solicitante entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Solicitante.Solicitante> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Solicitante.SolicitantePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Solicitante.Solicitante> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
