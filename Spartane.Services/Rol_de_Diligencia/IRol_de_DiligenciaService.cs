using System;
using Spartane.Core.Domain.Rol_de_Diligencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Rol_de_Diligencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRol_de_DiligenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_DiligenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Rol_de_Diligencia.Rol_de_Diligencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
