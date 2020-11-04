using System;
using Spartane.Core.Domain.Elemento_Robado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Elemento_Robado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IElemento_RobadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Elemento_Robado.Elemento_Robado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Elemento_Robado.Elemento_RobadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
