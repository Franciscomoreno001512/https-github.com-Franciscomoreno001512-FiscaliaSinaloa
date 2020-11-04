using System;
using Spartane.Core.Domain.Medios_Alternativos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Medios_Alternativos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMedios_AlternativosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Medios_Alternativos.Medios_AlternativosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
