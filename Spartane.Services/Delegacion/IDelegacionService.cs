using System;
using Spartane.Core.Domain.Delegacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Delegacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDelegacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Delegacion.Delegacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Delegacion.Delegacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Delegacion.Delegacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Delegacion.Delegacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Delegacion.DelegacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Delegacion.Delegacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
