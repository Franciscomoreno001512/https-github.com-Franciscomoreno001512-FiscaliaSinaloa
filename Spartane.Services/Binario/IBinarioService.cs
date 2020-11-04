using System;
using Spartane.Core.Domain.Binario;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Binario
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IBinarioService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Binario.Binario> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Binario.Binario> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Binario.Binario> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Binario.Binario GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Binario.Binario entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Binario.Binario entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Binario.Binario> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Binario.Binario> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Binario.BinarioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Binario.Binario> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
