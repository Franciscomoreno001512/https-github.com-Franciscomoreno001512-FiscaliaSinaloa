using System;
using Spartane.Core.Domain.Lugares_Frecuentes_Involucrado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Lugares_Frecuentes_Involucrado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ILugares_Frecuentes_InvolucradoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
