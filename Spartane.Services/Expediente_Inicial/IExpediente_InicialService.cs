using System;
using Spartane.Core.Domain.Expediente_Inicial;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Expediente_Inicial
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IExpediente_InicialService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
