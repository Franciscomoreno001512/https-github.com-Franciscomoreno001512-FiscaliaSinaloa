using System;
using Spartane.Core.Domain.Director_de_Agencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Director_de_Agencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDirector_de_AgenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Director_de_Agencia.Director_de_AgenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Director_de_Agencia.Director_de_Agencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
