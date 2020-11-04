using System;
using Spartane.Core.Domain.Reporte_Principal;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Reporte_Principal
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IReporte_PrincipalService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Reporte_Principal.Reporte_Principal GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Reporte_Principal.Reporte_Principal entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Reporte_Principal.Reporte_PrincipalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Reporte_Principal.Reporte_Principal> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
