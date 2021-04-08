using System;
using Spartane.Core.Domain.Situacion_del_Imputado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Situacion_del_Imputado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISituacion_del_ImputadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_ImputadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
