using System;
using Spartane.Core.Domain.PC_CanalizarA;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.PC_CanalizarA
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPC_CanalizarAService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarAPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
