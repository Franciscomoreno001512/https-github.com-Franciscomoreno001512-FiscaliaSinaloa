using System;
using Spartane.Core.Domain.A_Tiempo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.A_Tiempo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IA_TiempoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.A_Tiempo.A_Tiempo GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.A_Tiempo.A_Tiempo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.A_Tiempo.A_Tiempo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.A_Tiempo.A_TiempoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
