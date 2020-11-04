using System;
using Spartane.Core.Domain.Abogado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Abogado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAbogadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Abogado.Abogado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Abogado.Abogado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Abogado.Abogado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Abogado.Abogado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Abogado.Abogado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Abogado.Abogado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Abogado.Abogado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Abogado.Abogado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Abogado.AbogadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Abogado.Abogado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
