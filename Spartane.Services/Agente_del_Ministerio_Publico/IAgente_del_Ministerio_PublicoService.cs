using System;
using Spartane.Core.Domain.Agente_del_Ministerio_Publico;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Agente_del_Ministerio_Publico
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAgente_del_Ministerio_PublicoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_PublicoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Agente_del_Ministerio_Publico.Agente_del_Ministerio_Publico> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
