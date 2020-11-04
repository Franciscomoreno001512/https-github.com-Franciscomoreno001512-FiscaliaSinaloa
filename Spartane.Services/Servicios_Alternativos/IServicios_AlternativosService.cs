using System;
using Spartane.Core.Domain.Servicios_Alternativos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Servicios_Alternativos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IServicios_AlternativosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Servicios_Alternativos.Servicios_AlternativosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
