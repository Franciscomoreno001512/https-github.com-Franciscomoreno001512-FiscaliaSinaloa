using System;
using Spartane.Core.Domain.Religion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Religion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IReligionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Religion.Religion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Religion.Religion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Religion.Religion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Religion.Religion GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Religion.Religion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Religion.Religion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Religion.Religion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Religion.Religion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Religion.ReligionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Religion.Religion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
