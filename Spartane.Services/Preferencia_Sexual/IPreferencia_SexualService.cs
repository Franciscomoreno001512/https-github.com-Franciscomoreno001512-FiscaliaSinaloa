using System;
using Spartane.Core.Domain.Preferencia_Sexual;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Preferencia_Sexual
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPreferencia_SexualService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Preferencia_Sexual.Preferencia_SexualPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Preferencia_Sexual.Preferencia_Sexual> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
