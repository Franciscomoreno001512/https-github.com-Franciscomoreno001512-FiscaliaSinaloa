using System;
using Spartane.Core.Domain.Estatus_Orientador;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_Orientador
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_OrientadorService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_Orientador.Estatus_OrientadorPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
