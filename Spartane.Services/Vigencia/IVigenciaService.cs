using System;
using Spartane.Core.Domain.Vigencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Vigencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IVigenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Vigencia.Vigencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Vigencia.Vigencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Vigencia.Vigencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Vigencia.Vigencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Vigencia.VigenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Vigencia.Vigencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
