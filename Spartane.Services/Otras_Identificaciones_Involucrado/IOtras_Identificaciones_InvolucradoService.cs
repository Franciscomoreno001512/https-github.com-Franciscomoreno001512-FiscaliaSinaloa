using System;
using Spartane.Core.Domain.Otras_Identificaciones_Involucrado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Otras_Identificaciones_Involucrado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IOtras_Identificaciones_InvolucradoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
