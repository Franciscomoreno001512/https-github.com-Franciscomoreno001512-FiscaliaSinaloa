using System;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Modulo_Atencion_Inicial
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IModulo_Atencion_InicialService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
