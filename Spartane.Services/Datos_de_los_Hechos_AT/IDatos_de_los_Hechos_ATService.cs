using System;
using Spartane.Core.Domain.Datos_de_los_Hechos_AT;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Datos_de_los_Hechos_AT
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDatos_de_los_Hechos_ATService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_ATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
