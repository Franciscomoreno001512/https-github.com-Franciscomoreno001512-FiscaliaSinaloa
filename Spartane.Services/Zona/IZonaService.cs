using System;
using Spartane.Core.Domain.Zona;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Zona
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IZonaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Zona.Zona> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Zona.Zona> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Zona.Zona> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Zona.Zona GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Zona.Zona entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Zona.Zona entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Zona.Zona> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Zona.Zona> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Zona.ZonaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Zona.Zona> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
