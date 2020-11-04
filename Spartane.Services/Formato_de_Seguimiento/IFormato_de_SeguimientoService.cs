using System;
using Spartane.Core.Domain.Formato_de_Seguimiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Formato_de_Seguimiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IFormato_de_SeguimientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_SeguimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
