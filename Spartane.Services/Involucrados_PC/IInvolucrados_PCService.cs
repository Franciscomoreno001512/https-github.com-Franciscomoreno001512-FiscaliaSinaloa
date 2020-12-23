using System;
using Spartane.Core.Domain.Involucrados_PC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Involucrados_PC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IInvolucrados_PCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Involucrados_PC.Involucrados_PC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Involucrados_PC.Involucrados_PC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Involucrados_PC.Involucrados_PC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Involucrados_PC.Involucrados_PCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Involucrados_PC.Involucrados_PC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
