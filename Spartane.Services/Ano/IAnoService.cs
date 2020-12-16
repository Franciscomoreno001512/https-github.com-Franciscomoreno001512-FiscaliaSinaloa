using System;
using Spartane.Core.Domain.Ano;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Ano
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAnoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Ano.Ano> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ano.Ano> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ano.Ano> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Ano.Ano GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Ano.Ano entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Ano.Ano entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Ano.Ano> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Ano.Ano> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Ano.AnoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Ano.Ano> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
