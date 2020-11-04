using System;
using Spartane.Core.Domain.Grupo_Vulnerable;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Grupo_Vulnerable
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGrupo_VulnerableService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Grupo_Vulnerable.Grupo_VulnerablePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
