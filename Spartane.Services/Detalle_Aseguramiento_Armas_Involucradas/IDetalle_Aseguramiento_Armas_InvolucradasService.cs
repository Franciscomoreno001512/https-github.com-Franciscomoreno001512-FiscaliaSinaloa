using System;
using Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Aseguramiento_Armas_Involucradas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Aseguramiento_Armas_InvolucradasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_InvolucradasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas.Detalle_Aseguramiento_Armas_Involucradas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
