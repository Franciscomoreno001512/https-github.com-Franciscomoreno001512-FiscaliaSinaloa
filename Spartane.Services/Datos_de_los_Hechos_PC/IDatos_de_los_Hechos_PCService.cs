using System;
using Spartane.Core.Domain.Datos_de_los_Hechos_PC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Datos_de_los_Hechos_PC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDatos_de_los_Hechos_PCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
