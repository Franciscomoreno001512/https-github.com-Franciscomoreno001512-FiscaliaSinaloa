using System;
using Spartane.Core.Domain.Labios;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Labios
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ILabiosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Labios.Labios> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Labios.Labios> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Labios.Labios> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Labios.Labios GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Labios.Labios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Labios.Labios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Labios.Labios> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Labios.Labios> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Labios.LabiosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Labios.Labios> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
