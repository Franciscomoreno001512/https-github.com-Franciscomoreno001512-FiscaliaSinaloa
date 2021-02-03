using System;
using Spartane.Core.Domain.Pension;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Pension
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPensionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Pension.Pension> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Pension.Pension> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Pension.Pension> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Pension.Pension GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Pension.Pension entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Pension.Pension entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Pension.Pension> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Pension.Pension> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Pension.PensionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Pension.Pension> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
