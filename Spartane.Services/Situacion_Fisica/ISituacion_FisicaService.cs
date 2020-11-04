using System;
using Spartane.Core.Domain.Situacion_Fisica;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Situacion_Fisica
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISituacion_FisicaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Situacion_Fisica.Situacion_FisicaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
