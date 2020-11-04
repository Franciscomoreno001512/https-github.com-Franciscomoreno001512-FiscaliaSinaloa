using System;
using Spartane.Core.Domain.Frente;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Frente
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IFrenteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Frente.Frente> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Frente.Frente> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Frente.Frente> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Frente.Frente GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Frente.Frente entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Frente.Frente entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Frente.Frente> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Frente.Frente> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Frente.FrentePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Frente.Frente> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
