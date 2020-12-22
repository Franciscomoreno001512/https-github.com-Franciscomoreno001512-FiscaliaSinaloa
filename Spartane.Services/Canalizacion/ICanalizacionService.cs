using System;
using Spartane.Core.Domain.Canalizacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Canalizacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICanalizacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Canalizacion.Canalizacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Canalizacion.Canalizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Canalizacion.Canalizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Canalizacion.Canalizacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Canalizacion.Canalizacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Canalizacion.CanalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Canalizacion.Canalizacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
