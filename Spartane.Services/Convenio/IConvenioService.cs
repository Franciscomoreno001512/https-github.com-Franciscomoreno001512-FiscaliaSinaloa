using System;
using Spartane.Core.Domain.Convenio;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Convenio
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IConvenioService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Convenio.Convenio> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Convenio.Convenio> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Convenio.Convenio> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Convenio.Convenio GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Convenio.Convenio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Convenio.Convenio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Convenio.Convenio> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Convenio.Convenio> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Convenio.ConvenioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Convenio.Convenio> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
