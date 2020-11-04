using System;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Identificacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_IdentificacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_IdentificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Identificacion.Tipo_de_Identificacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
