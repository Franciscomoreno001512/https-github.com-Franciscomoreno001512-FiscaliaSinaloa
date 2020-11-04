using System;
using Spartane.Core.Domain.Indicios;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Indicios
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IIndiciosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Indicios.Indicios> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Indicios.Indicios> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Indicios.Indicios> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Indicios.Indicios GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Indicios.Indicios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Indicios.Indicios entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Indicios.Indicios> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Indicios.Indicios> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Indicios.IndiciosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Indicios.Indicios> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
