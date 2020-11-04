using System;
using Spartane.Core.Domain.Discapacidades_Psicosociales;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Discapacidades_Psicosociales
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDiscapacidades_PsicosocialesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
