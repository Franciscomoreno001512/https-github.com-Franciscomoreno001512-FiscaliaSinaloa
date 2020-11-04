using System;
using Spartane.Core.Domain.Discapacidades_Sensoriales;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Discapacidades_Sensoriales
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDiscapacidades_SensorialesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_SensorialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
