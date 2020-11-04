using System;
using Spartane.Core.Domain.Agencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Agencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAgenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Agencia.Agencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Agencia.Agencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Agencia.Agencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Agencia.Agencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Agencia.Agencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Agencia.Agencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Agencia.Agencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Agencia.Agencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Agencia.AgenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Agencia.Agencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
